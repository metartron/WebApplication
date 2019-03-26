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

             <%--===================================================================--%>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:教務系統ConnectionString %>" SelectCommand="select TABLE_NAME from INFORMATION_SCHEMA.TABLES
where TABLE_TYPE='base table'"></asp:SqlDataSource>
            <asp:DropDownList ID="ddltablename" runat="server" DataSourceID="SqlDataSource3" DataTextField="TABLE_NAME" DataValueField="TABLE_NAME" AutoPostBack="True" OnSelectedIndexChanged="ddltablename_SelectedIndexChanged"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:教務系統ConnectionString %>" SelectCommand="table_query" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddltablename" Name="tableName" Type="String"  />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource4"></asp:GridView>
            <%--===================================================================--%>
            產品編號：<asp:TextBox ID="txtPID" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="檢查可用性" />
            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:MySystemConnectionString1 %>" 
                SelectCommand="check_productID" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="txtPID" Name="productID" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView4" runat="server"  DataSourceID="SqlDataSource5">
                
            </asp:GridView>

        </div>
    </form>
</body>
</html>
