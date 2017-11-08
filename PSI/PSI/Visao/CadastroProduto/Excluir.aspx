<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Excluir.aspx.cs" Inherits="PSI.Visao.CadastroProduto.Excluir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Exclusão de Produto</h2>
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Código:"></asp:Label></td>
                <td><asp:Label ID="Label2" runat="server" Text="" Font-Bold="True"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Descrição:"></asp:Label></td>
                <td><asp:Label ID="Label4" runat="server" Text="" Font-Bold="True"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="Excluir" OnClick="Button1_Click" /></td>
                <td><asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
