<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test4.aspx.cs" Inherits="Proje.Site.Test4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Gorsel Kodu<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br/>
            Kullanıcı No<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            Yönlendir
            <br />
            <asp:Button ID="btn_ekle" runat="server" Text="Gönder" OnClick="btn_ekle_Click" />
        </div>
    </form>
</body>
</html>
