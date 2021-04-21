<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Proje.Site.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">                
            DropDownList<br/>
            
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>-<asp:Button ID="Button1" runat="server" style="background-color:slateblue; color:cyan" Text="Button" OnClick="Button1_Click" />

            <br/>

            <asp:DropDownList ID="drp_liste" runat="server" Width="100%" OnSelectedIndexChanged="drp_liste_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Selected="True" Value="-1">Seçiniz</asp:ListItem>
            </asp:DropDownList>
        
    <p>
        Seçilen Değerin Özelliğini Almak:
    </p>

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
     <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"> LinkButton</asp:LinkButton>
     </p>
            <asp:ImageButton ID="img_button" runat="server" ImageUrl="~/Template/assets/img/portfolio/portfolio-7.jpg" Width="100" OnClick="img_button_Click" />
    </form>
</body>
</html>
