<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="PSI.Visao.CadastroProduto.Alterar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Alteração de Produto</h2>
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Código"></asp:Label></td>
                <td><asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Descrição"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox2">*</asp:RequiredFieldValidator>
                </td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click" /></td>
                <td><asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" CausesValidation="False" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
