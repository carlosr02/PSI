<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PSI.Visao.CadastroFuncionario.Index" Theme="css" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cadastro de Funcionário</h2>
    <asp:Button ID="Button1" runat="server" Text="Incluir" PostBackUrl="~/Visao/CadastroFuncionario/Incluir.aspx" /><br />
    <br />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" DataKeyNames="Codigo">
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Código" SortExpression="Codigo" ReadOnly="True"></asp:BoundField>
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome"></asp:BoundField>
            <asp:BoundField DataField="Telefones" HeaderText="Telefones" SortExpression="Telefones"></asp:BoundField>
            <asp:BoundField DataField="Identidade" HeaderText="Identidade" SortExpression="Identidade"></asp:BoundField>
            <asp:BoundField DataField="Clt" HeaderText="CLT" SortExpression="Clt"></asp:BoundField>
            <asp:BoundField DataField="Salario" HeaderText="Salário" SortExpression="Salario"></asp:BoundField>
            <asp:CheckBoxField DataField="Motorista" HeaderText="Motorista" SortExpression="Motorista"></asp:CheckBoxField>
            <asp:CheckBoxField DataField="Tecnico" HeaderText="Técnico" SortExpression="Tecnico"></asp:CheckBoxField>
            <asp:BoundField DataField="Observacao" HeaderText="Observação" SortExpression="Observacao"></asp:BoundField>
            <asp:ButtonField CommandName="Alterar" Text="Alterar" />
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="PSI.DAL.DALFuncionario"></asp:ObjectDataSource>
</asp:Content>
