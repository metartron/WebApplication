<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="27DataList-Edit.aspx.cs" Inherits="ASPnet._27DataList_Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="3" CellSpacing="10" RepeatDirection="Horizontal" 
               OnItemCommand="DataList1_ItemCommand"
                ><%--GridLines="Both"--%>
                <ItemTemplate>
                    <div >
                        <%--///////////////////////////////////////////////////////////////////////////////--%>
                        <asp:Button ID="Button1" runat="server" Text="編輯資料" CommandName="Edit" />
                        
                        <br/>
                        <img src='ProductsImg/s<%# Eval("Product_Img") %>' />
                        <br />
                        <asp:Label ID="Lbl2" Font-Names="微軟正黑體" Font-Bold="true" Font-Size="14pt"  runat="server" Text='<%# Eval("Product_Name") %>'/>
                        <br />
                        原價：
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Product_Price","{0:C0}") %>' ForeColor="#999999" CssClass="line_through" />
                        <br />
                        特價：
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Product_Price2","{0:C0}") %>' ForeColor="#ff0066" Font-Names="Arial Black" Font-Size="18pt" />
                        <%--///////////////////////////////////////////////////////////////////////////////--%>
                    </div>
                </ItemTemplate>
               <EditItemTemplate>
                   Product_ID:
                    <asp:Label ID="Product_IDLabel" runat="server" Text='<%# Eval("Product_ID") %>' />
                    <br />
                    Product_Name:
                   
                   <asp:TextBox ID="txtProduct_Name" runat="server" Text='<%# Eval("Product_Name") %>' Width="200"></asp:TextBox>
                    <br />
                    <%--Product_Img:
                    <asp:Label ID="Product_ImgLabel" runat="server" Text='<%# Eval("Product_Img") %>' />
                    <br />--%>
                    Product_Price:
                    
                   <asp:TextBox ID="txtProduct_Price" runat="server" Text='<%# Eval("Product_Price") %>' Width="100"></asp:TextBox>
                    <br />
                    Product_price2:
                    
                   <asp:TextBox ID="txtProduct_price2" runat="server" Text='<%# Eval("Product_price2") %>' Width="100"></asp:TextBox>
                    <br />
                    Product_Intro:
                    
                   <asp:TextBox ID="txtProduct_Intro" runat="server" Text='<%# Eval("Product_Intro") %>' TextMode="MultiLine" Width="200" Height="100"></asp:TextBox>
                    <br />
                    Product_Status:
                    
                   <asp:RadioButtonList ID="rblProduct_Status" runat="server">
                       <asp:ListItem Text="上架" Value="1" Selected="True"></asp:ListItem>
                       <asp:ListItem Text="下架" Value="0"></asp:ListItem>
                   </asp:RadioButtonList>
                    <br />
                   <asp:Label ID="lblProduct_Status" runat="server" Text='<%# Eval("Product_Status") %>' />
               </EditItemTemplate>
               
            </asp:DataList>
        </div>



        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MySystemConnectionString1 %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
        
    </form>
</body>
</html>
