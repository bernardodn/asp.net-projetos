<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroFuncionario.aspx.cs" Inherits="ProjetoFinal.Views.Funcionarios.CadastroFuncionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="lblCpfFuncionario" runat="server" Text="CPF:"></asp:Label> <asp:TextBox ID="txtCpfFuncionario" runat="server"></asp:TextBox> 
    <asp:Label ID="lblNomeFuncionario" runat="server" Text="Nome:"></asp:Label> <asp:TextBox ID="txtNomeFuncionario" runat="server"></asp:TextBox>
    <asp:Label ID="lblDataDeNascimentoFuncionario" runat="server" Text="Data de nascimento:"></asp:Label> <asp:TextBox ID="txtDataDeNascimentoFuncionario" runat="server"></asp:TextBox> 
    <asp:Label ID="lblIdEmpresaFuncionario" runat="server" Text="ID da empresa:"></asp:Label> <asp:TextBox ID="txtIdEmpresaFuncionario" runat="server"></asp:TextBox>
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    

</asp:Content>
