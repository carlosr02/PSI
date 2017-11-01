<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PSI.Visao.CadastroProduto.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Cadastro de Produtos</h1>
        <asp:Button ID="Button1" runat="server" Text="Incluir" PostBackUrl="~/Visao/CadastroProduto/Incluir.aspx" /><br /><br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo"></asp:BoundField>
                <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao"></asp:BoundField>
                <asp:CommandField DeleteText="Excluir" EditText="Alterar" ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" DataObjectTypeName="PSI.Modelo.Produto" DeleteMethod="Delete" SelectMethod="SelectAll" TypeName="PSI.DAL.DALProduto" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="codigo" Type="Int32"></asp:Parameter>
            </DeleteParameters>
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
