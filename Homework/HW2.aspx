<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HW2.aspx.cs" Inherits="Homework.HW2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="質數判斷:"></asp:Label>
            <asp:TextBox ID="txtBox1" runat="server"></asp:TextBox>
            <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="判斷" />
            <br />
            <asp:Label ID="lblResult1" runat="server" Text="結果:"></asp:Label>
            <br />
            <hr />
        </div>
    </form>
</body>
</html>
