<%@ Page Title="" Language="C#" MasterPageFile="~/AnaSayfa.Master" AutoEventWireup="true" CodeFile="GorselListele.aspx.cs" Inherits="Proje.Site.GorselListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <asp:Image runat="server" ID="image1" ImageUrl='<%# Eval("GorselAd") %>' />
            </ItemTemplate>
    </asp:Repeater>
</asp:Content>
