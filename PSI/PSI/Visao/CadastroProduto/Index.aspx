<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PSI.Visao.CadastroProduto.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Cadastro de Produtos</h2>
        <asp:Button ID="Button1" runat="server" Text="Incluir" PostBackUrl="~/Visao/CadastroProduto/Incluir.aspx" /><br /><br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" DataKeyNames="Codigo" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo"></asp:BoundField>
                <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao"></asp:BoundField>
                <asp:ButtonField CommandName="Alterar" Text="Alterar" />
                <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" DataObjectTypeName="PSI.Modelo.Produto" DeleteMethod="Delete" SelectMethod="SelectAll" TypeName="PSI.DAL.DALProduto" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="codigo" Type="Int32"></asp:Parameter>
            </DeleteParameters>
        </asp:ObjectDataSource>

        <br /><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Visao/Index.aspx">Voltar</asp:HyperLink>
    </div>
    </form>
</body>
</html>
