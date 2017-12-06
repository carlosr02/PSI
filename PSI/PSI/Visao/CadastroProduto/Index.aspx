<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PSI.Visao.CadastroProduto.WebForm1" Theme="css" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cadastro de Produtos</h2>
    <asp:Button ID="Button1" runat="server" Text="Incluir" PostBackUrl="~/Visao/CadastroProduto/Incluir.aspx" /><br />
    <br />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" DataKeyNames="Codigo" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Código" ReadOnly="True" SortExpression="Codigo"></asp:BoundField>
            <asp:BoundField DataField="Descricao" HeaderText="Descrição" SortExpression="Descricao"></asp:BoundField>
            <asp:ButtonField CommandName="Alterar" Text="Alterar" />
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" DataObjectTypeName="PSI.Modelo.Produto" DeleteMethod="Delete" SelectMethod="SelectAll" TypeName="PSI.DAL.DALProduto" UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="codigo" Type="Int32"></asp:Parameter>
        </DeleteParameters>
    </asp:ObjectDataSource>
</asp:Content>
