<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertar.aspx.cs" Inherits="Prueba.insertar" %>

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
            <asp:Label ID="lblrut" runat="server" Text="Rut">Rut</asp:Label>
            <asp:TextBox ID="txtrut" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblnombre" runat="server" Text="Rut">Nombre</asp:Label>
            <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblapellido" runat="server" Text="Rut">Apellido</asp:Label>
            <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox><br />
            <asp:Label ID="lbledad" runat="server" Text="Rut">Edad</asp:Label>
            <asp:TextBox ID="txtedad" runat="server"></asp:TextBox><br />
            <asp:Button ID="btninsertar" runat="server" Text="Insertar" OnClick="btninsertar_Click" PostBackUrl="~/Controladores/Procesarinsertar.aspx"></asp:Button>
        </center>



        </div>
    </form>
</body>
</html>
