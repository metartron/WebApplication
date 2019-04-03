<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="16Homework4.aspx.cs" Inherits="ASPnet._16Homework4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>677</title>
    <style type="text/css">

        #tbMember {
            width: 450px;
            height: 500px;
            margin: auto;
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
            <table id="tbMember" >
                <caption>會員資料</caption>
                <tr>
                    <td >帳號:</td>
                    <td >
            <asp:TextBox ID="txtAccount" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td  >密碼:</td>
                    <td >
            <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" placeholder="8-12碼"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td  >密碼確認:</td>
                    <td >
            <asp:TextBox ID="txtPwd2" runat="server" TextMode="Password" placeholder="請再輸入一次密碼"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td  >身分證字號:</td>
                    <td >
                        <asp:TextBox ID="txtID" runat="server" placeholder="A123456789"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >姓名:</td>
                    <td >
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >生日:</td>
                    <td >
                        <asp:TextBox ID="txtBirthday" runat="server" placeholder="1990-01-01"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >E-mail:</td>
                    <td >
                        <asp:TextBox ID="txtEmail" runat="server"  placeholder="ex:abc@abc.com"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >性別:</td>
                    <td >
          
                        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="男" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="女"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td >學歷:</td>
                    <td  >
            <asp:DropDownList ID="ddlEduLevel" runat="server">
                            <asp:ListItem Text="請選擇"></asp:ListItem>
                            <asp:ListItem Text="國小"></asp:ListItem>
                            <asp:ListItem Text="國中"></asp:ListItem>
                            <asp:ListItem Text="高中"></asp:ListItem>
                            <asp:ListItem Text="大學"></asp:ListItem>
                            <asp:ListItem Text="研究所以上"></asp:ListItem>
                        </asp:DropDownList>


                    </td>
                </tr>
                <tr>
                    <td >興趣:</td>
                    <td  >
                        <table>
                            <tr>
                                <td rowspan="4"> 
                        <asp:ListBox ID="ltbInterest" runat="server" Width="100" Height="150">
                            <asp:ListItem Text="爬山"></asp:ListItem>
                                        <asp:ListItem Text="踏青"></asp:ListItem>
                                        <asp:ListItem Text="看雲"></asp:ListItem>
                                        <asp:ListItem Text="健行"></asp:ListItem>
                                        <asp:ListItem Text="聽音樂"></asp:ListItem>
                                        <asp:ListItem Text="上網"></asp:ListItem>
                                        <asp:ListItem Text="遊泳"></asp:ListItem>
                                        <asp:ListItem Text="賺錢"></asp:ListItem>
                                        <asp:ListItem Text="唱歌"></asp:ListItem>
                        </asp:ListBox>

                                </td>
                                <td> 

                        <asp:Button ID="btnAll" runat="server" Text=">>"  CausesValidation="False" />
                                </td>
                                <td rowspan="4"> 
                        <asp:ListBox ID="ltbInterestFinal" runat="server" Width="100" Height="150">
                            
                        </asp:ListBox>


                                </td>
                            </tr>
                            <tr>
                                <td> 
                        <asp:Button ID="btnYes" runat="server" Text=">"  CausesValidation="False" />
                            </td>
                                </tr>
                            <tr>
                                <td> 
                        <asp:Button ID="btnNo" runat="server" Text="<"   CausesValidation="False" />
                                </td>
                            </tr>
                            <tr>
                                <td > 
                        <asp:Button ID="btnCancel" runat="server" Text="<<"   CausesValidation="False" />
                                </td>
                            </tr>
                          
                        </table>

                    </td>
                   
                </tr>
                <tr>
                    <td  colspan="2">
            <asp:Button ID="Button1" runat="server" Text="確認送出"   />
                        <input id="Reset1" type="reset" value="重設" />
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
