<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="PSI.Visao.CadastroFuncionario.Alterar" Theme="css" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Alteração de Funcionário</h2>
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Código"></asp:Label></td>
                <td><asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox2">*</asp:RequiredFieldValidator>
                </td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Telefone(s)"></asp:Label></td>
                <td><asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="Identidade"></asp:Label></td>
                <td><asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Carteira de Trabalho"></asp:Label></td>
                <td><asp:TextBox ID="TextBox5" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Salário"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox6">*</asp:RequiredFieldValidator>
                </td>
                <td><asp:TextBox ID="TextBox6" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label7" runat="server" Text="Motorista"></asp:Label></td>
                <td><asp:CheckBox ID="CheckBox1" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label8" runat="server" Text="Técnico"></asp:Label></td>
                <td><asp:CheckBox ID="CheckBox2" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label9" runat="server" Text="Observação"></asp:Label></td>
                <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click" /></td>
                <td><asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" CausesValidation="False" /></td>
            </tr>
        </table>
</asp:Content>
