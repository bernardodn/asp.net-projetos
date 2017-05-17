<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Aula1705.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br />
            <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
            <asp:Button ID="btnSoma" runat="server" Text="+" OnClick="btnSoma_Click" />
            <asp:Button ID="btnIgual" runat="server" Text="=" OnClick="btnIgual_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
