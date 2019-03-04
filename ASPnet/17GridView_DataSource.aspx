﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="17GridView_DataSource.aspx.cs" Inherits="ASPnet._17GridView_DataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Account" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Account" HeaderText="Account" ReadOnly="True" SortExpression="Account" />
                    <asp:BoundField DataField="Pswd" HeaderText="Pswd" SortExpression="Pswd" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Birthday" HeaderText="Birthday" SortExpression="Birthday" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:CheckBoxField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                    <asp:BoundField DataField="EduLevel" HeaderText="EduLevel" SortExpression="EduLevel" />
                    <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes" />
                </Columns>
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="姓名" DataFormatString="<{0}>"/>
                    <asp:BoundField DataField="Birthday" HeaderText="生日" DataFormatString="{0:D}" />
                    <asp:BoundField DataField="Email" HeaderText="Email"  />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                    <asp:BoundField DataField="EduLevel" HeaderText="EduLevel"  />
                    <asp:BoundField DataField="Notes" HeaderText="Notes" Visible="false" />
                    <asp:BoundField DataField="Account" HeaderText="Account" ReadOnly="True" />
                    <asp:BoundField DataField="Pswd" HeaderText="Pswd" DataFormatString="*****" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:MySystemConnectionString1 %>" 
                SelectCommand="SELECT * FROM [Members]"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
