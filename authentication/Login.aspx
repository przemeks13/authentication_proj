<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="authentication.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login:<br />
            <asp:TextBox ID="tbxLogin" runat="server"></asp:TextBox>
            <br />
            Password:<br />
            <asp:TextBox ID="tbxPassword" runat="server" ></asp:TextBox>
        </div>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" style="margin-left: 40px" Text="Register" />
    </form>
</body>
</html>
