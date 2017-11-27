<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="PSI.Visao.CadastroProduto.WebForm3" Theme="css" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
