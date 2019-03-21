using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _24CommandField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
            if (e.Row.RowIndex > -1)
            {
                Button btn = (Button)e.Row.Cells[8].Controls[2];
                //Delete Edit Update New Insert Select Cancel
                if (btn.CommandName == "Delete")
                {
                    btn.Attributes["onclick"] = "if(!confirm('您確定要刪除【"+e.Row.Cells[2].Text+"】此筆資料嗎????????')) return;";
                }
            }
        }
    }
}