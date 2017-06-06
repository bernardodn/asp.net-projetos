<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroEmpresa.aspx.cs" Inherits="ProjetoFinal.Views.Empresas.CadastroEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Cadastro de Empresas</h3>
    <asp:Label ID="lblCnpjEmpresa" runat="server" Text="CNPJ: "></asp:Label>
    <br />
    <asp:TextBox ID="txtCnpjEmpresa" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblNomeEmpresa" runat="server" Text="Nome da empresa:"></asp:Label> 
    <br />
    <asp:TextBox ID="txtNomeEmpresa" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDescricaoEmpresa" runat="server" Text="Descrição: "></asp:Label>
    <br />
    <asp:TextBox ID="txtDescricaoEmpresa" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnSalvar" cssclass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <br /> 
    <h3>Editar Empresas</h3>
    <asp:Label ID="lblIdEmpresaEditar" runat="server" Text="ID da empresa que gostaria de editar:"></asp:Label>
    <asp:TextBox ID="txtIdEmpresaEditar" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblNomeEmpresadaEditado" runat="server" Text="Nome desejado:"></asp:Label>
    <asp:TextBox ID="txtNomeEmpresaEditado"  cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblCnpjEmpresaEditado" runat="server" Text="CNPJ desejado: "></asp:Label>
    <asp:TextBox ID="txtCnpjEmpresaEditado" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDescricaoEmpresaEditado" runat="server" Text="Descrição desejada: "></asp:Label>
    <asp:TextBox ID="txtDescricaoEmpresaEditado" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnEditar" cssclass="btn btn-primary" runat="server" Text="Editar" OnClick="btnEditar_Click" />
    <br />
    <h3>Lista de Empresas Cadastradas</h3>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
    <asp:GridView ID="gdvEmpresas" runat="server" CellPadding="3" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
        </ContentTemplate>
        </asp:UpdatePanel>
    <h3>Excluir Empresa</h3>
    <asp:Label ID="lblExcluir" runat="server" Text="ID da empresa: "></asp:Label> <asp:TextBox  ID="txtExcluir" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnExcluir" cssclass="btn btn-danger" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
</asp:Content>
