<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Prueba.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblrut" runat="server" Text="Rut"></asp:Label>
        <asp:TextBox ID="txtrut" runat="server"></asp:TextBox>
        <asp:Button ID="btnrut" runat="server" OnClick="btnrut_Click" PostBackUrl="~/validarEliminar.aspx" Text="Eliminar" />
    </form>
</body>
</html>
