using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPnet.App_Code;

namespace ASPnet
{
    public partial class _37OO_Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Random r = new Random();

            //TextBox tb1 = new TextBox();
            //TextBox tb2 = new TextBox();
            //TextBox tb3 = new TextBox();
            //TextBox tb4 = new TextBox();
            //TextBox tb5 = new TextBox();

            Person Mary = new Person();
            Response.Write(Mary.Jump());
            Response.Write("<br/>");
            Person Jason = new Person();
            Jason.Name = "Jason Lee";
            Jason.Age = -18;
            Response.Write(Jason.Name);
            Response.Write("<br/>");
            string speak = Jason.Speak("我是一個大帥哥!!");
            Response.Write(speak);
            Response.Write("<br/>");
            Response.Write(Jason.Jump(5));
            Response.Write("<br/>");
            Response.Write(Jason.Jump("四"));

            Person Josh = new Person("Josh Lai", 26);

            Person May = new Person("May Chen", 20, false, 180, 70);

            May.Age = 25;
            Response.Write(May.Age);
        }
    }
}