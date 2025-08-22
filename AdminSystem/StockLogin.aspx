<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Management — Login</title>

    <!-- Bootstrap 5 + Icons -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" rel="stylesheet" />

    <style>
        :root{
            --ink:#0f172a; --panel:#111827; --panel-2:#1f2937; --line:#2d3748;
            --muted:#9ca3af; --brand:#14b8a6; --brand-2:#0ea5a4;
        }
        body{
            height:100vh; display:flex; align-items:center; justify-content:center;
            background: radial-gradient(1000px 600px at 10% -10%, #0b2447 0%, #000 40%) fixed,
                        radial-gradient(800px 400px at 110% 10%, #051937 0%, #000 50%) fixed,
                        #000; color:#e5e7eb;
        }
        .login-card{
            background: linear-gradient(180deg, rgba(17,24,39,.95), rgba(17,24,39,.88));
            border:1px solid var(--line);
            border-radius:16px;
            padding:40px 32px;
            width:100%; max-width:420px;
            box-shadow:0 10px 30px rgba(0,0,0,.5);
        }
        .login-card h3{ font-weight:600; color:#fff; }
        .form-label{ color:#cbd5e1; font-weight:500; }
        .form-control{
            background:#0b1220; border:1px solid var(--line); color:#e5e7eb;
        }
        .form-control::placeholder{ color:#94a3b8; }
        .form-control:focus{ border-color:var(--brand); box-shadow:0 0 0 0.2rem rgba(20,184,166,.35); }

        .btn-brand{ background:var(--brand); border-color:var(--brand); color:#001b1a; font-weight:600; }
        .btn-brand:hover{ background:var(--brand-2); border-color:var(--brand-2); color:#001b1a; }
        .btn-ghost{ background:transparent; border:1px solid var(--line); color:#e5e7eb; }
        .btn-ghost:hover{ background:#0f172a; border-color:#384151; }

        .error-message{ color:#fca5a5; font-weight:600; font-size:.9rem; }
        .icon-circle{
            width:60px; height:60px; border-radius:50%;
            display:grid; place-items:center;
            margin:0 auto 18px auto;
            background:rgba(20,184,166,.12);
            border:1px solid rgba(20,184,166,.35);
            color:var(--brand); font-size:28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-card text-center">
            <div class="icon-circle"><i class="bi bi-box-seam"></i></div>
            <h3 class="mb-4">Stock System Login</h3>

            <!-- Username -->
            <div class="mb-3 text-start">
                <asp:Label ID="lblUserName" runat="server" Text="Username" AssociatedControlID="txtUserName" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="Enter your username"></asp:TextBox>
            </div>

            <!-- Password -->
            <div class="mb-3 text-start">
                <asp:Label ID="lblPassword" runat="server" Text="Password" AssociatedControlID="txtPassword" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter your password"></asp:TextBox>
            </div>

            <!-- Error -->
            <asp:Label ID="lblErrorLogin" runat="server" CssClass="error-message d-block mb-3"></asp:Label>

            <!-- Buttons -->
            <div class="d-grid gap-2">
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-brand" OnClick="btnLogin_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-ghost" OnClick="btnCancel_Click" />
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
