<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="Excluir.aspx.cs" Inherits="PSI.Visao.CadastroProduto.WebForm4" Theme="css" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
