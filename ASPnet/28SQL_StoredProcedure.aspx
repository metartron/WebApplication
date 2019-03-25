<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="28SQL_StoredProcedure.aspx.cs" Inherits="ASPnet._28SQL_StoredProcedure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:教務系統ConnectionString %>" SelectCommand="學生選課明細" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server"  DataSourceID="SqlDataSource1">  </asp:GridView>

            <hr />
            輸入姓名關鍵字：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="搜尋" />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:教務系統ConnectionString %>" SelectCommand="學生查詢" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter Name="name" Type="String" ControlID="txtName" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView2" runat="server"  DataSourceID="SqlDataSource2"  >
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
