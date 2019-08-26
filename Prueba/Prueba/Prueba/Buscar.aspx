<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="Prueba.Buscar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblrut" runat="server" Text="Rut">Rut</asp:Label><asp:TextBox ID="txtrut" runat="server"></asp:TextBox><asp:Button ID="Btnbuscar" runat="server" Text="Buscar" PostBackUrl="~/validaBuscar.aspx" OnClick="Btnbuscar_Click" />
        <br /><asp:Label ID="lblnombre" runat="server" Text="Nombre">Nombre</asp:Label>
            <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        <br /><asp:Label ID="lblapellido" runat="server" Text="Apellido">Apellido</asp:Label> 
            <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
        <br /><asp:Label ID="lbledad" runat="server" Text="Edad">Edad</asp:Label>

            <asp:TextBox ID="txtedad" runat="server"></asp:TextBox>

        </div>
    </form>
</body>
</html>
