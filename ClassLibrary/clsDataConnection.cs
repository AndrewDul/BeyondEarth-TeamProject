using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class clsDataConnection : IDisposable
{
    // connection + ADO helpers
    private SqlConnection connectionToDB;
    private SqlDataAdapter dataChannel;
    private SqlCommandBuilder commandBuilder;

    // stored proc parameters
    private readonly List<SqlParameter> SQLParams = new List<SqlParameter>();

    // results
    private DataTable dataTable = new DataTable();
    public DataTable DataTable
    {
        get => dataTable;
        set => dataTable = value ?? new DataTable();
    }
    public int Count => dataTable?.Rows?.Count ?? 0;

    // connection string
    private readonly string connectionString;

    public clsDataConnection()
    {
        connectionString = GetConnectionString();
        System.Diagnostics.Debug.WriteLine(">>> USING HARDCODED MDF CONNECTION <<<");
    }

    // Hard-coded LocalDB AttachDbFilename to your MDF.
    private string GetConnectionString()
    {
        return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\local database\StockData.mdf;Integrated Security=True;";
    }


    // Add an input parameter for the next Execute() call.
    public void AddParameter(string ParamName, object ParamValue)
    {
        SQLParams.Add(new SqlParameter(ParamName, ParamValue ?? DBNull.Value));
    }

    // Execute a stored procedure:
    // - Fills DataTable for SELECT procs.
    // - Returns stored procedure RETURN value (insert/update/delete should RETURN).
    public int Execute(string SProcName)
    {
        if (string.IsNullOrWhiteSpace(SProcName))
            throw new ArgumentException("Stored procedure name cannot be null/empty.", nameof(SProcName));

        int returnCode = 0;
        DataTable = new DataTable();

        using (connectionToDB = new SqlConnection(connectionString))
        using (var cmd = new SqlCommand(SProcName, connectionToDB) { CommandType = CommandType.StoredProcedure })
        {
            foreach (var p in SQLParams) cmd.Parameters.Add(p);

            var returnParam = new SqlParameter("@ReturnValue", SqlDbType.Int)
            {
                Direction = ParameterDirection.ReturnValue
            };
            cmd.Parameters.Add(returnParam);

            connectionToDB.Open();

            using (dataChannel = new SqlDataAdapter(cmd))
            {
                commandBuilder = new SqlCommandBuilder(dataChannel);
                dataChannel.Fill(DataTable);
            }

            if (returnParam.Value != null && returnParam.Value != DBNull.Value)
                returnCode = Convert.ToInt32(returnParam.Value);

            cmd.Parameters.Clear();
            SQLParams.Clear();
        }

        return returnCode;
    }

    // ===== Optional legacy helpers (retained for compatibility) =====
    public string GetDBName()
    {
        string[] filePaths;
        int PathArrayIndex = 0;
        string[] dirConts;
        bool Found = false;
        int Counter;
        List<string> DBNames = new List<string>();
        string BaseDir = TrimPath(AppDomain.CurrentDomain.BaseDirectory);

        do
        {
            filePaths = System.IO.Directory.GetDirectories(BaseDir);
            PathArrayIndex = 0;
            while (PathArrayIndex < filePaths.Length & Found == false)
            {
                filePaths[PathArrayIndex] = filePaths[PathArrayIndex].ToLower();
                if (filePaths[PathArrayIndex].Contains("app_data") == true)
                {
                    dirConts = System.IO.Directory.GetFiles(filePaths[PathArrayIndex], "*.mdf", System.IO.SearchOption.AllDirectories);
                    Counter = 0;
                    while (Counter < dirConts.Length)
                    {
                        if (dirConts[Counter].Contains("ASPNETDB.MDF") == false)
                            DBNames.Add(dirConts[Counter]);
                        Counter++;
                    }
                    if (DBNames.Count == 1) Found = true; else PathArrayIndex++;
                }
                else PathArrayIndex++;
            }
            if (Found == false) BaseDir = TrimPath(BaseDir);
        }
        while (BaseDir != "" & Found == false);

        if (DBNames.Count == 1) return DBNames[0];
        else if (DBNames.Count == 0) throw new Exception("There is no database in your App_Data folder");
        else throw new Exception("You have too many database files in your App_Data folder");
    }

    private string TrimPath(string OldPath)
    {
        int Posn = OldPath.LastIndexOf("\\");
        if (Posn != -1) OldPath = OldPath.Substring(0, Posn); else OldPath = "";
        return OldPath;
    }

    public void Dispose()
    {
        try { commandBuilder?.Dispose(); } catch { }
        try { dataChannel?.Dispose(); } catch { }
        try
        {
            if (connectionToDB != null)
            {
                if (connectionToDB.State != ConnectionState.Closed) connectionToDB.Close();
                connectionToDB.Dispose();
            }
        }
        catch { }
    }
}
