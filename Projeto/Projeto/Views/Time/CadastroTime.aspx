<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroTime.aspx.cs" Inherits="Projeto.Views.Time.CadastroTime" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cadastro de Time</h1>
    Nome: <asp:TextBox ID="txtNomeTime" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnSalvarTime" runat="server" Text="Salvar" />
    <asp:Button ID="btnCancelarTime" runat="server" Text="Cancelar" />
</asp:Content>
