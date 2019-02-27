<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="圖形驗證碼2.aspx.cs" Inherits="ASPnet.圖形驗證碼2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style type="text/css">
            #span_result{
                color:Red;
                font-size:12px;      
             }
        </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <!--src連結到ValidateNumber.ashx即可-->
            <img src="ValidateNumber.ashx" alt="驗證碼" name="imgCode"/>
            <%--重新整理圖片按鈕--%>
            <input type="button" onclick="form1.imgCode.src='ValidateNumber.ashx?' + Math.random();" value="重新整理" />

            <%--網頁重新整理，不是最好的方法--%>
<%--            <input type="button" onclick="javascript:window.location.reload()" value="重新整理" />--%>
            <hr />

        </div>
        <div>
            <asp:TextBox ID="txt_input" runat="server" placeholder="請輸入驗證碼" MaxLength="5"></asp:TextBox>
            <span id="span_result"></span>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txt_input" Display="Dynamic" runat="server" ErrorMessage="(必填)" ForeColor="Red" Font-Size="10pt"></asp:RequiredFieldValidator>
            <%--<asp:CompareValidator ID="CompareValidator1" runat="server"  Operator="Equal" ControlToCompare="txt_input"  ControlToValidate="JS.isPassValidateCode()?" ErrorMessage="(驗證碼錯誤)" ForeColor="Red" Font-Size="10pt"></asp:CompareValidator>--%>

        </div>

        <br />

        <div>
            <%--尚未執行及驗證完成--%>
            <asp:Button ID="btn_submit" runat="server" Text="確定送出" OnClientClick="return isPassValidateCode();" onClick="btn_submit_Click" />
            <input id="Reset1" type="reset" value="重設" />                 

        </div>
        

    </form>

    <%--<script></script>從網站直接複製下來使用--%>
    <%--https://dotblogs.com.tw/shadow/archive/2011/10/05/38823.aspx--%>
    <script src="js/jquery-1.4.1.js" type="text/javascript"></script>
    <script type="text/javascript" >
        //jQuery(document).ready(init);
        function init() {

           /*每次Dom載入完，確保圖片都不一樣*/
           jQuery("img[name='imgCode']").attr("src", "ValidateNumber.ashx?" + Math.random());
        
        }

        function isPassValidateCode() {
          var  nowValidateNumber =  jQuery.ajax({
                url: "readSessionValidateNumber.ashx",
                type: "post",
                async: false,
                data:{},
                success: function (htmlVal) {  }
            }).responseText;

            console.log("圖形驗證碼：" + nowValidateNumber);      //for check

            if (nowValidateNumber == "" || nowValidateNumber == null) {
                alert("驗證碼逾時，請重新整理");
                return false;
            }
            var userInput = jQuery("#<%= txt_input.ClientID%>").val();

            var validateResult = ((nowValidateNumber == userInput) ? true : false);


            if (validateResult == false) {
                jQuery("#span_result").html("驗證碼輸入不正確");
            }
            

            //回傳true Or false
            return validateResult;
        }
    </script>

</body>
</html>
