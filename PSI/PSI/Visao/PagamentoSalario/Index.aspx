<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PSI.Visao.CadastroPagamentoSalario.Index" Theme="css" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Pagamento de Salário de Funcionários</h2>
    <asp:Button ID="Button1" runat="server" Text="Incluir" OnClick="Button1_Click" /><br />
    <br />

    Selecione o Funcionário:
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <br />
    Mês/Ano de Referência:
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList>
    /
        <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="Button2" runat="server" Text="Pesquisar" PostBackUrl="~/Visao/PagamentoSalario/Index.aspx" />

    <br /><br />
    Salário:
    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Blue"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="Codigo" OnDataBound="GridView1_DataBound" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" Visible="False"></asp:BoundField>
            <asp:BoundField DataField="Data" HeaderText="Data Pagamento" SortExpression="Data" DataFormatString="{0:dd/MM/yyyy}"></asp:BoundField>
            <asp:BoundField DataField="MesReferente" HeaderText="Mês Referência" SortExpression="MesReferente"></asp:BoundField>
            <asp:BoundField DataField="AnoReferente" HeaderText="Ano Referência" SortExpression="AnoReferente"></asp:BoundField>
            <asp:BoundField DataField="ValorPago" HeaderText="Valor Pago" SortExpression="ValorPago"></asp:BoundField>
            <asp:BoundField DataField="Funcionario_codigo" HeaderText="Funcionario_codigo" ReadOnly="True" SortExpression="Funcionario_codigo" Visible="False"></asp:BoundField>
            <asp:ButtonField CommandName="Alterar" Text="Alterar" />
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectByFuncionarioEMesEAno" TypeName="PSI.DAL.DALPagamentoSalario">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" PropertyName="SelectedValue" Name="funcionario_codigo" Type="Int32"></asp:ControlParameter>
            <asp:ControlParameter ControlID="DropDownList2" PropertyName="SelectedValue" Name="mesReferente" Type="Int32"></asp:ControlParameter>
            <asp:ControlParameter ControlID="DropDownList3" PropertyName="SelectedValue" Name="anoReferente" Type="Int32"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    Valor dos Pagamentos Feitos:
    <asp:Label ID="Label2" runat="server" Text="" ForeColor="Blue"></asp:Label>
    <br />
    Valor Devido:
    <asp:Label ID="Label3" runat="server" Text="" ForeColor="Red"></asp:Label>
</asp:Content>
