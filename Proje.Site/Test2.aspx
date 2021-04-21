<%@ Page Title="" Language="C#" MasterPageFile="~/AnaSayfa.Master" AutoEventWireup="true" CodeBehind="Test2.aspx.cs" Inherits="Proje.Site.Test2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        LİNQ SORGULARI</p><br/>
    <asp:ListBox ID="list" runat="server"></asp:ListBox>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <p/>

</asp:Content>
