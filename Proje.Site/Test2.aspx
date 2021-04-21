<%@ Page Title="" Language="C#" MasterPageFile="~/AnaSayfa.Master" AutoEventWireup="true" CodeBehind="Test2.aspx.cs" Inherits="Proje.Site.Test2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        LİNQ SORGULARI</p><br/>
    <asp:ListBox ID="list" runat="server"></asp:ListBox>
    <p>
    
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="EntityFramework İle Getir" OnClick="Button2_Click" />
    </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    <p>
        &nbsp;<p/>

</asp:Content>
