<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroEmpresa.aspx.cs" Inherits="ProjetoFinal.Views.Empresas.CadastroEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblNomeEmpresa" runat="server" Text="Nome da empresa:"></asp:Label> 
    <asp:TextBox ID="txtNomeEmpresa" runat="server"></asp:TextBox><asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" /> 
    <asp:Button ID="btnRemover" runat="server" Text="Remover" OnClick="btnRemover_Click" />
    <br />
    <asp:GridView ID="gdvEmpresas" runat="server"></asp:GridView>
</asp:Content>
