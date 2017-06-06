<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroFuncionario.aspx.cs" Inherits="ProjetoFinal.Views.Funcionarios.CadastroFuncionario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Cadastro de Funcionários</h3>
    <asp:Label ID="lblNomeFuncionario" runat="server" Text="Nome do funcionário:"></asp:Label>
    <asp:TextBox cssclass="form-control" ID="txtNomeFuncionario" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblCpfFuncionario" runat="server" Text="CPF:"></asp:Label>
    <asp:TextBox cssclass="form-control" ID="txtCpfFuncionario" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDataDeNascimentoFuncionario" runat="server" Text="Data de nascimento:"></asp:Label>
    <asp:TextBox cssclass="form-control" ID="txtDataDeNascimentoFuncionario" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblIdEmpresaFuncionario" runat="server" Text="ID da empresa:"></asp:Label>
    <asp:TextBox cssclass="form-control" ID="txtIdEmpresaFuncionario" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <h3>Editar Funcionários</h3>
    <br />
    <asp:Label ID="lblNomeFuncionarioEditar" runat="server" Text="Nome do funcionário a ser editado: "></asp:Label>
    <br />
    <asp:TextBox ID="txtNomeFuncionarioEditar" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblCpfFuncionarioEditado" runat="server" Text="CPF desejado: "></asp:Label>
    <br />
    <asp:TextBox ID="txtCpfFuncionarioEditado" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblNomeFuncionarioEditado" runat="server" Text="Nome desejado: "></asp:Label>
    <br />
    <asp:TextBox ID="txtNomeFuncionarioEditado" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDataDeNascimentoFuncionarioEditado" runat="server" Text="Data de nascimento desejada: "></asp:Label>
    <br />
    <asp:TextBox ID="txtDataDeNascimentoFuncionarioEditado" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblIdEmpresaFuncionarioEditado" runat="server" Text="ID da empresa desejado: "></asp:Label>
    <br />
    <asp:TextBox ID="txtIdEmpresaFuncionarioEditado" cssclass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnEditar" cssclass="btn btn-primary" runat="server" Text="Editar" OnClick="btnEditar_Click" />
    <br />
    <h3>Lista de Funcionários</h3>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="gdvFuncionarios" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
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
    <h3>Excluir Funcionário</h3>
    <asp:Label ID="lblExcluir" runat="server" Text="Nome do funcionário: "></asp:Label> <asp:TextBox cssclass="form-control" ID="txtExcluir" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnExcluir" CssClass="btn btn-danger" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
</asp:Content>
