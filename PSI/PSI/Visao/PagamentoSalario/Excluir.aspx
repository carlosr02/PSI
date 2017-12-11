<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="Excluir.aspx.cs" Inherits="PSI.Visao.CadastroPagamentoSalario.Excluir" Theme="css" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Exclusão de Pagamento de Salário</h2>
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Código:"></asp:Label></td>
                <td><asp:Label ID="Label2" runat="server" Text="" Font-Bold="True"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Funcionário:"></asp:Label></td>
                <td><asp:Label ID="Label4" runat="server" Text="" Font-Bold="True"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Data:"></asp:Label></td>
                <td><asp:Label ID="Label6" runat="server" Text="" Font-Bold="True"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label7" runat="server" Text="Mês / Ano de Referência:"></asp:Label></td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="" Font-Bold="True"></asp:Label> /
                    <asp:Label ID="Label9" runat="server" Text="" Font-Bold="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label10" runat="server" Text="Valor Pago:"></asp:Label></td>
                <td><asp:Label ID="Label11" runat="server" Text="" Font-Bold="True"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="Excluir" OnClick="Button1_Click" /></td>
                <td><asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" /></td>
            </tr>
        </table>
</asp:Content>
