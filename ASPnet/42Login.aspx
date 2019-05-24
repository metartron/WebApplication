<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="42Login.aspx.cs" Inherits="ASPnet._42Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
.fb > input[type=radio]{
  display:none;
}
input[type=radio] + img{
  cursor:pointer;
  border:2px solid transparent;
}
input[type=radio]:checked + img{
  border:2px solid #f00;
}
label img{
    pointer-events: none;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-group">
            <label class="col-form-label" for="txtAccount">帳號：</label>
            <asp:TextBox ID="txtAccount" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            <div class="form-group">
            <label class="col-form-label" for="txtPswd">密碼：</label>
            <asp:TextBox ID="txtPswd" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
            </div>

            <asp:Button ID="login" runat="server" Text="登入" CssClass="btn btn-primary" OnClick="login_Click"/>
        </div>


  <label class="fb" for="fb1">
    <input id="fb1" type="radio" name="fb" value="small" />
    <img src="http://placehold.it/20x20/35d/fff&text=f" />
  </label>

  <label class="fb" for="fb2">
    <input id="fb2" type="radio" name="fb" value="big"/>
    <img src="http://placehold.it/40x60/35d/fff&text=f" />
  </label>

  <label class="fb" for="fb3">
    <input id="fb3" type="radio" name="fb" value="med" />
    <img src="http://placehold.it/40x40/35d/fff&text=f" />
  </label>

  <label class="fb" for="fb4">
    <input id="fb4" type="radio" name="fb" value="long" />
    <img src="http://placehold.it/60x15/35d/fff&text=f" />
  </label>



    </form>
</body>
</html>
