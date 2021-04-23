<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test3.aspx.cs" Inherits="Proje.Site.Test3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="scriptmanagerbilgi" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    

                     <asp:Button ID="Button1" runat="server" Text="Göster" OnClick="Button1_Click" />



                </ContentTemplate>
                <Triggers>
                        <asp:AsyncPostbackTrigger ControlID="Button1" EventName="Click"/>
                </Triggers>

            </asp:UpdatePanel>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>eqwewq</asp:ListItem>
                        <asp:ListItem>sadasdsa</asp:ListItem>
                        <asp:ListItem>gdfgdf</asp:ListItem>
                        <asp:ListItem>qwefsda</asp:ListItem>
                        <asp:ListItem Value="sd">fsdfsd</asp:ListItem>
                        <asp:ListItem>fsdfsdfa</asp:ListItem>
                    </asp:DropDownList>
    </form>
</body>
</html>
