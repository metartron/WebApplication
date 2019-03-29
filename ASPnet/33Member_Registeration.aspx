<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="33Member_Registeration.aspx.cs" Inherits="ASPnet._33Member_Registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

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
    <form id="form1" runat="server" defaultbutton="Button1">
       <div>
           <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


           <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Size="10pt" ForeColor="Red" DisplayMode="BulletList" ShowMessageBox="true"/>
            <table id="tbMember">
                <caption>會員資料</caption>
                <tr>
                    <td >帳號:</td>
                    <td >
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
            <asp:TextBox ID="txtAccount" runat="server" placeholder="10碼"></asp:TextBox><asp:Button ID="btnCheckAccount" runat="server" Text="檢查帳號可用性" ValidationGroup="abc123"  />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  runat="server" Text="(必填)" ErrorMessage="帳號為必填欄位" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtAccount" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="(格式有誤)"  ForeColor="Red" Font-Size="10pt" ControlToValidate="txtAccount" ValidationExpression="[A-C][A-Za-z0-9]{4}" Display="Dynamic"></asp:RegularExpressionValidator>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="(帳號重複)" ValidationGroup="abc123"  ForeColor="Red" Font-Size="10pt" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                            </td>
                </tr>
                <tr>
                    <td  >密碼:</td>
                    <td >
            <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" placeholder="8-12碼"></asp:TextBox>
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
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="(必填)" ErrorMessage="姓名為必填欄位" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td >生日:</td>
                    <td >
                        <asp:TextBox ID="txtBirthday" runat="server" placeholder="1990-01-01"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="(必填)" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtBirthday" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="(格式錯誤)" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtBirthday" Operator="DataTypeCheck" Type="Date" Display="Dynamic"></asp:CompareValidator>
                        <asp:RangeValidator ID="ranForBirthday" runat="server" ErrorMessage="(超出範圍)" ForeColor="Red" Font-Size="10pt"  MinimumValue="1911/1/1" ControlToValidate="txtBirthday"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td >E-mail:</td>
                    <td >
                        <asp:TextBox ID="txtEmail" runat="server"  placeholder="ex:abc@abc.com"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="(格式錯誤)" ForeColor="Red" Font-Size="10pt" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td >性別:</td>
                    <td >
          
                        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="男" Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="女" Value="0"></asp:ListItem>
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
                    <td  ><asp:TextBox ID="txtNote" TextMode="MultiLine" runat="server" Width="200" Height="150"></asp:TextBox>
                       </td>
                </tr>
                <tr>
                    <td  colspan="2">
            <asp:Button ID="Button1" runat="server" Text="加入會員"   OnClick="Button1_Click"/>
                        <input id="Reset1" type="reset" value="重設" />
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
