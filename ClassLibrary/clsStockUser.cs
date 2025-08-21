using System;

namespace ClassLibrary
{
    public class clsStockUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }

        // Find user by username/password via stored proc
        public bool FindUser(string userName, string password)
        {
            var DB = new clsDataConnection();
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            DB.Execute("sproc_tblStockUsers_FindUserNamePW");

            if (DB.Count == 1)
            {
                var row = DB.DataTable.Rows[0];
                UserID = Convert.ToInt32(row["UserID"]);
                UserName = Convert.ToString(row["UserName"]);
                Password = Convert.ToString(row["Password"]);
                Department = Convert.ToString(row["Department"]);
                return true;
            }
            return false;
        }
    }
}
