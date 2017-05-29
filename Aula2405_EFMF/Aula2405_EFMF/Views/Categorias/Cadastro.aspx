<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Aula2405_EFMF.Views.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h5>Nome da categoria:</h5>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <br />
    <h5>Descrição da categoria:</h5>
    <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
</asp:Content>
