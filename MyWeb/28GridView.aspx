<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="28GridView.aspx.cs" Inherits="MyWeb._28GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        #GridView1{
            width:90%;
            margin:auto;
            border:0;
        }
        #GridView1 td,#GridView1 th{
            
            border:0;
        }

        #GridView1 th{
            
            border-bottom:5px double;
            background-color:#808080;
            color:white;
        }
         #GridView1 td{
            height:30px;
        }
         #GridView1 tr:hover{
            background-color:aquamarine;
        }

         #btn span{
            border:1px solid;
            cursor:pointer;
        }

        #pink{
            background-color:pink;
        }
        #yellow{
            background-color:lemonchiffon;
        }
        #blue{
            background-color:lightblue;
        }

        .pink{
            background-color:pink;
        }
        .yellow{
            background-color:lemonchiffon;
        }
        .blue{
            background-color:lightblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="btn">
                <span id="pink">　</span>
                <span id="yellow">　</span>
                <span id="blue">　</span>
        </div>
         <br />
        <div id="container">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MySystemConnectionString %>" SelectCommand="SELECT * FROM [Members]"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server"  DataSourceID="SqlDataSource1">
                
            </asp:GridView>
        </div>
    </form>

    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script>
       //$('#pink').click(function () {
       //     //$('#GridView1 tr:nth-child(2n+1)').css({'background-color':'pink'});//偶發性式件,一般不在這裡寫css
       //    $('#GridView1 tr:nth-child(2n+1)').addClass('pink');//通常用指定css class的方式 tag>class>id
       // });
        //老師寫法
        $('#btn span').click(function (evt) {
            var id=evt.target.id
            $('#GridView1 tr:nth-child(2n+1)').removeClass().addClass(id);
        });
        //自己亂寫
        //$('#btn span').click(function () {
        //    var id = $(this).attr("id");          // equals：this.id
        //    $('#GridView1 tr:nth-child(2n+1)').removeClass().addClass(id);
        //});
    </script>
</body>
</html>
