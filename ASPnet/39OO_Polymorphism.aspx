<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="39OO_Polymorphism.aspx.cs" Inherits="ASPnet._39OO_Polymorphism" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Text="person"></asp:ListItem>
                <asp:ListItem Text="dog"></asp:ListItem>
                <asp:ListItem Text="cat"></asp:ListItem>
                <asp:ListItem Text="fish"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="Button1" runat="server" Text="按我就叫(類別)" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="按我就叫(介面)" OnClick="Button1_Click"  />
            <hr />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
