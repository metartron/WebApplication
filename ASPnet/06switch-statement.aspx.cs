using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _06switch_statement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 3;
            switch (a)
            {
                case 1:
                    Response.Write("a的值為1");
                    break;
                case 2:
                    Response.Write("a的值為2");
                    break;
                case 3:
                    Response.Write("a的值為3");
                    break;
                case 4:
                    Response.Write("a的值為4");
                    break;
                case 5:
                    Response.Write("a的值為5");
                    break;
            }

            ///////////////////////////////////
            Response.Write("<hr>");

            string Color = "黃";

            switch (Color)
            {
                case "黃":
                    Response.Write("黃色");
                    break;
                case "綠":
                    Response.Write("綠色");
                    break;
                case "紅":
                    Response.Write("紅色");
                    break;
                default:
                    Response.Write("這不是黃綠紅");
                    break;

            }

            Response.Write("<hr>");


            //判斷分數等第(只能用switch不可以加任何if)
            //90以上為優等
            //80-89以上為甲等
            //70-79以上為乙等
            //60-69以上為丙等
            //60以下為丁等

            int score2 = 85;
            switch (score2 / 10)
            {
                case 10:
                case 9:
                    Response.Write("優等");
                    break;
                case 8:
                    Response.Write("甲等");
                    break;
                case 7:
                    Response.Write("乙等");
                    break;
                case 6:
                    Response.Write("丙等");
                    break;
                default:
                    Response.Write("丁等");
                    break;
            }
            //int score2 = 65;
            //switch (score2)
            //{
            //    case 100:
            //    case 99:
            //    case 98:
            //    case 97:
            //    case 96:
            //    case 95:
            //    case 94:
            //    case 93:
            //    case 92:
            //    case 91:
            //    case 90:
            //        Response.Write("優等");
            //        break;
            //    case 89:
            //    case 88:
            //    case 87:
            //    case 86:
            //    case 85:
            //    case 84:
            //    case 83:
            //    case 82:
            //    case 81:
            //    case 80:
            //        Response.Write("甲等");
            //        break;
            //    case 79:
            //    case 78:
            //    case 77:
            //    case 76:
            //    case 75:
            //    case 74:
            //    case 73:
            //    case 72:
            //    case 71:
            //    case 70:
            //        Response.Write("乙等");
            //        break;
            //    case 69:
            //    case 68:
            //    case 67:
            //    case 66:
            //    case 65:
            //    case 64:
            //    case 63:
            //    case 62:
            //    case 61:
            //    case 60:
            //        Response.Write("丙等");
            //        break;
            //    default:
            //        Response.Write("丁等");
            //        break;

            //}

        }
    }
}