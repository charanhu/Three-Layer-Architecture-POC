<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css"/>
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="Scripts/Employee.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <asp:Label ID="Label3" runat="server" Text="Login" Font-Size="20pt"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
            <br />
            <br />
            <asp:TextBox class="form-control" ID="txtUsername" runat="server" Width="200px" MaxLength="30"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <br />
            <br />
            <asp:TextBox class="form-control" ID="txtPassword" runat="server" TextMode="Password" Width="200px" MaxLength="15"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" class="btn btn-primary" runat="server" Text="Login" OnClientClick="Javascript:return LoginValidation();" OnClick="OnLoginButtonClick" Width="200px" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
