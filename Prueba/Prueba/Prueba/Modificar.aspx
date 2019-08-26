<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="Prueba.Modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <asp:Label ID="lblrut" runat="server" Text="Label">Rut</asp:Label><asp:TextBox ID="txtrut" runat="server"></asp:TextBox><asp:Button ID="Btnbuscar" runat="server" Text="Buscar" PostBackUrl="~/validaBuscar.aspx" />
            <br /><asp:Label ID="lblNombre" runat="server" Text="Label">Nombre</asp:Label><asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            <br /><asp:Label ID="lblapellido" runat="server" Text="Label">Apellido</asp:Label><asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
            <br /><asp:Label ID="lbledad" runat="server" Text="Label">Edad</asp:Label><asp:TextBox ID="txtedad" runat="server"></asp:TextBox>
            <br /><asp:Button ID="btnmodificar" runat="server" Text="Modificar" PostBackUrl="~/ValidarModificar.aspx" />
            </center>
        </div>
    </form>
</body>
</html>
