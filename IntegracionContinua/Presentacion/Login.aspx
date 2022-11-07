<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>BIENVENIDOS</div>
        <div>
            Correo
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        </div>
        <div>
            Password
            <asp:TextBox ID="txtPasword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Ingresar" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html> 
