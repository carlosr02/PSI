<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PSI.Visao.Index1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Visao/CadastroCliente/Index.aspx">Cadastro de Clientes</asp:HyperLink>
        <br /><br /><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Visao/CadastroProduto/Index.aspx">Cadastro de Produtos</asp:HyperLink>
    </div>
    </form>
</body>
</html>
