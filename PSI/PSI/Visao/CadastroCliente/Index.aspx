﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PSI.Visao.CadastroCliente.WebForm1" Theme="css" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cadastro de Clientes</h2>
        <asp:Button ID="Button1" runat="server" Text="Incluir" PostBackUrl="~/Visao/CadastroCliente/Incluir.aspx" /><br /><br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" DataKeyNames="Codigo" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Código" ReadOnly="True" SortExpression="Codigo"></asp:BoundField>
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome"></asp:BoundField>
                <asp:BoundField DataField="Telefones" HeaderText="Telefones" SortExpression="Telefones"></asp:BoundField>
                <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade"></asp:BoundField>
                <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado"></asp:BoundField>
                <asp:BoundField DataField="Endereco" HeaderText="Endereço" SortExpression="Endereco"></asp:BoundField>
                <asp:BoundField DataField="Cpf_cnpj" HeaderText="CPF/CNPJ" SortExpression="Cpf_cnpj"></asp:BoundField>
                <asp:BoundField DataField="Email" HeaderText="E-mail" SortExpression="Email"></asp:BoundField>
                <asp:ButtonField CommandName="Alterar" Text="Alterar" />
                <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="PSI.DAL.DALCliente" DataObjectTypeName="PSI.Modelo.Cliente">
        </asp:ObjectDataSource>
</asp:Content>
