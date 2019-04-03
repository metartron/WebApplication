<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="36FormView.aspx.cs" Inherits="ASPnet._36FormView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        #container {
            border:2px solid;
            width:1200px;
            margin:auto;
            clear:both;
        }
        #left {
            width:200px;
            float:left;
        }
        #right {
            width:1000px;
            float:right;
        }
        #bottom{
              clear:both;
          }
        #tbMember {
            width: 450px;
                height: 500px;
                margin: auto;
                border:3px double;
        }
            #tbMember table {
                width: 100%;
            }
            #tbMember tr > td:first-child {
                text-align: right;
            }
            #tbMember tr:last-child > td {
                text-align: center;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
        
        <div id="container">
            <div id="left">
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MySystemConnectionString1 %>" SelectCommand="SELECT * FROM [Members]"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Account" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="Account" HeaderText="Account" ReadOnly="True" SortExpression="Account" />
                  
                    <asp:CommandField ShowSelectButton="True" />
                  
                </Columns>
            </asp:GridView>




            </div>
            <div id="right">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MySystemConnectionString1 %>" 
                SelectCommand="SELECT [Members].*,[Edu].EduLevel as EduName ,iif(Members.gender=1,'男','女') as GenderName
                FROM [Members] 
                inner join [Edu] on [Edu].EduLevel_Code=[Members].EduLevel   
                where [Members].account=@account">
                <SelectParameters >
                    <asp:ControlParameter Name="account" ControlID="GridView1" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:FormView ID="FormView1" runat="server" DataKeyNames="Account" DataSourceID="SqlDataSource1" OnModeChanged="FormView1_ModeChanged" OnLoad="FormView1_Load" >
                <EditItemTemplate>
                    Account:
                    <asp:Label ID="AccountLabel1" runat="server" Text='<%# Eval("Account") %>' />
                    <br />
                    Pswd:
                    <asp:TextBox ID="PswdTextBox" runat="server" Text='<%# Bind("Pswd") %>' />
                    <br />
                    Name:
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Birthday:
                    <asp:TextBox ID="BirthdayTextBox" runat="server" Text='<%# Bind("Birthday") %>' />
                    <br />
                    Email:
                    <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                    <br />
                    Gender:
                    <asp:CheckBox ID="GenderCheckBox" runat="server" Checked='<%# Bind("Gender") %>' />
                    <br />
                    EduLevel:
                    <asp:TextBox ID="EduLevelTextBox" runat="server" Text='<%# Bind("EduLevel") %>' />
                    <br />
                    Notes:
                    <asp:TextBox ID="NotesTextBox" runat="server" Text='<%# Bind("Notes") %>' />
                    <br />
                    Photo:
                    <asp:TextBox ID="PhotoTextBox" runat="server" Text='<%# Bind("Photo") %>' />
                    <br />
                    IsAuth:
                    <asp:CheckBox ID="IsAuthCheckBox" runat="server" Checked='<%# Bind("IsAuth") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="更新" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    <table id="tbMember">
                <caption>會員資料</caption>
                <tr>
                    <td >帳號:</td>
                    <td >
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
            <asp:TextBox ID="txtAccount" runat="server" placeholder="10碼" Text='<%# Bind("Account") %>'></asp:TextBox><asp:Button ID="btnCheckAccount" runat="server" Text="檢查帳號可用性" ValidationGroup="abc123"  />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  runat="server" Text="(必填)" ErrorMessage="帳號為必填欄位" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtAccount" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="(格式有誤)"  ForeColor="Red" Font-Size="10pt" ControlToValidate="txtAccount" ValidationExpression="[A-C][A-Za-z0-9]{4}" Display="Dynamic"></asp:RegularExpressionValidator>
                        <%--<asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="(帳號重複)" ValidationGroup="abc123"  ForeColor="Red" Font-Size="10pt" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>--%>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                            </td>
                </tr>
                <tr>
                    <td  >密碼:</td>
                    <td >
            <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" placeholder="8-12碼" Text='<%# Bind("Pswd") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="(必填)" ErrorMessage="密碼為必填欄位" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtPwd" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="(密碼不可含有空白)"  ForeColor="Red" Font-Size="10pt" ControlToValidate="txtPwd" ValidationExpression="\S{8,12}" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td  >密碼確認:</td>
                    <td >
            <asp:TextBox ID="txtPwd2" runat="server" TextMode="Password" placeholder="請再輸入一次密碼"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Text="(必填)" ErrorMessage="密碼為必填欄位" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtPwd2" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtPwd2" ErrorMessage="(兩次密碼輸入不相同)" ForeColor="Red" Font-Size="10pt"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td  >&nbsp;</td>
                    <td >
                        &nbsp;</td>
                </tr>
                <tr>
                    <td >姓名:</td>
                    <td >
                        <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="(必填)" ErrorMessage="姓名為必填欄位" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td >生日:</td>
                    <td >
                        <asp:TextBox ID="txtBirthday" runat="server" placeholder="1990-01-01" Text='<%# Bind("Birthday") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="(必填)" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtBirthday" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="(格式錯誤)" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtBirthday" Operator="DataTypeCheck" Type="Date" Display="Dynamic"></asp:CompareValidator>
                        <%--<asp:RangeValidator ID="ranForBirthday" runat="server" ErrorMessage="(超出範圍)" ForeColor="Red" Font-Size="10pt"  MinimumValue="1911/1/1" ControlToValidate="txtBirthday"></asp:RangeValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td >E-mail:</td>
                    <td >
                        <asp:TextBox ID="txtEmail" runat="server"  placeholder="ex:abc@abc.com" Text='<%# Bind("Email") %>'></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="(格式錯誤)" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td >性別:</td>
                    <td >
          
                        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="男" Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="女" Value="0" Selected="False"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td >學歷:</td>
                    <td  >
            <asp:DropDownList ID="ddlEduLevel" runat="server">
                            <asp:ListItem Text="請選擇"></asp:ListItem>
                        </asp:DropDownList>

                        <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="(請選擇)" ForeColor="Red" Font-Size="10pt" ControlToValidate="ddlEduLevel" Operator="NotEqual" ValueToCompare="請選擇"></asp:CompareValidator>

                    </td>
                </tr>
                <tr>
                    <td >照片：</td>
                    <td  ><asp:FileUpload ID="fulPhoto" runat="server"  /><asp:Label id="lblPhoto" Font-Size="10pt" ForeColor="red" runat="server"></asp:Label>
                       </td>
                </tr>
                <tr>
                    <td >備註：</td>
                    <td  ><asp:TextBox ID="txtNote" TextMode="MultiLine" runat="server" Width="200" Height="150" Text='<%# Bind("Notes") %>'></asp:TextBox>
                       </td>
                </tr>
                <tr>
                    <td  colspan="2">
            <asp:Button ID="Button1" runat="server" Text="加入會員"   CommandName="Insert"/>
            <asp:Button ID="Button2" runat="server" Text="取消"   CommandName="Cancel" CausesValidation="False"/>
                    </td>
                </tr>
            </table>
                   
                    <%--<asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="插入" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />--%>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">編輯</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="New">新增</asp:LinkButton>
                    <hr />
                    <table border="1">
                        <tr>
                            <td>帳號：</td>
                            <td><%# Eval("Account") %></td>
                            <td>密碼：</td>
                            <td>＊＊＊＊＊＊＊</td>
                            <td rowspan="6">
                                    <img src='<%# "36GetMemberPhoto.ashx?account="+Eval("Account")  %>' />
                            </td>
                        </tr>
                        <tr>
                            <td>姓名：</td>
                            <td><%# Eval("Name") %></td>
                            <td>生日：</td>
                            <td><%# Eval("Birthday","{0:d}") %></td>
                        </tr>
                        <tr>
                            <td>性別：</td>
                            <td><%# Eval("GenderName") %></td>
                            <td>教育程度：</td>
                            <td><%# Eval("EduName") %></td>
                        </tr>
                        <tr>
                            <td>E-mail：</td>
                            <td colspan="3"><%# Eval("Email") %></td>
                        </tr>
                        <tr>
                            <td>備註：</td>
                            <td colspan="3"><%# Eval("Notes") %></td>
                        </tr>
                      
                    </table>
                   
                   
                   
                    <%--Photo:
                    <asp:Label ID="PhotoLabel" runat="server" Text='<%# Eval("Photo") %>' />
                    <br />
                    IsAuth:
                    <asp:CheckBox ID="IsAuthCheckBox" runat="server" Checked='<%# Eval("IsAuth") %>' Enabled="false" />
                    <br />--%>

                </ItemTemplate>
            </asp:FormView>
            </div>
            <div id="bottom">

            </div>
        </div>
        </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
