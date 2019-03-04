using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _17GridView_DataSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex > -1) //排除標題列
            {
                //if (e.Row.Cells[3].Text == "False")
                //{
                //    e.Row.Cells[3].Text = "女";
                //}
                //else
                //{
                //    e.Row.Cells[3].Text = "男";
                //}
                e.Row.Cells[3].Text = e.Row.Cells[3].Text == "False" ? "女" : "男";
                //============================================
                string stEduLevel = "";
                switch (e.Row.Cells[4].Text)
                {
                    case "1":
                        stEduLevel = "國小";
                        break;
                    case "2":
                        stEduLevel = "國中";
                        break;
                    case "3":
                        stEduLevel = "高中";
                        break;
                    case "4":
                        stEduLevel = "大學";
                        break;
                    case "5":
                        stEduLevel = "研究所以上";
                        break;
                    default:
                        stEduLevel = "未知";
                        break;
                }
                e.Row.Cells[4].Text = stEduLevel;
            }
        }
    }
}