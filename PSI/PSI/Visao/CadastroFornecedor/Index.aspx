<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PSI.Visao.CadastroFornecedor.Index" Theme="css" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cadastro de Fornecedores</h2>
    <asp:Button ID="Button1" runat="server" Text="Incluir" PostBackUrl="~/Visao/CadastroFornecedor/Incluir.aspx" /><br />
    <br />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" DataKeyNames="Codigo">
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" ReadOnly="True"></asp:BoundField>
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome"></asp:BoundField>
            <asp:BoundField DataField="Telefones" HeaderText="Telefones" SortExpression="Telefones"></asp:BoundField>
            <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade"></asp:BoundField>
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado"></asp:BoundField>
            <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco"></asp:BoundField>
            <asp:BoundField DataField="Cpf_cnpj" HeaderText="Cpf_cnpj" SortExpression="Cpf_cnpj"></asp:BoundField>
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"></asp:BoundField>
            <asp:ButtonField CommandName="Alterar" Text="Alterar" />
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="PSI.DAL.DALFornecedor">
    </asp:ObjectDataSource>
</asp:Content>
