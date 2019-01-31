<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="05if_statement.aspx.cs" Inherits="ASPnet._05if_statement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            判斷分數:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <p>
            結果:<asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
