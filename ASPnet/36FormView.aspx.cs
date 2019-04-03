using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _36FormView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ranForBirthday.MaximumValue = DateTime.Now.ToString("d");
        }
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySystemConnectionString1"].ConnectionString);
        #region FormView1_ModeChanged
        protected void FormView1_ModeChanged(object sender, EventArgs e)
        {
            //if (FormView1.CurrentMode == FormViewMode.Insert)
            //{
            //    //學歷下拉選單
            //    //SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySystemConnectionString1"].ConnectionString);
            //    SqlCommand Cmd = new SqlCommand("select * from Edu order by EduLevel_Code desc", Conn);

            //    DropDownList ddlEduLevel = (DropDownList)FormView1.FindControl("ddlEduLevel");

            //    SqlDataReader rd;
            //    Conn.Open();
            //    rd = Cmd.ExecuteReader();
            //    ListItem item;
            //    while (rd.Read())
            //    {
            //        item = new ListItem(rd["EduLevel"].ToString(), rd["EduLevel_Code"].ToString());
            //        ddlEduLevel.Items.Add(item);
            //    }

            //    Conn.Close();
            //}
        }
        #endregion

        protected void FormView1_Load(object sender, EventArgs e)
        {
            if (FormView1.CurrentMode == FormViewMode.Insert)
            {
                //學歷下拉選單
                //SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySystemConnectionString1"].ConnectionString);
                SqlCommand Cmd = new SqlCommand("select * from Edu order by EduLevel_Code desc", Conn);

                DropDownList ddlEduLevel = (DropDownList)FormView1.FindControl("ddlEduLevel");

                SqlDataReader rd;
                Conn.Open();
                rd = Cmd.ExecuteReader();
                ListItem item;
                while (rd.Read())
                {
                    item = new ListItem(rd["EduLevel"].ToString(), rd["EduLevel_Code"].ToString());
                    ddlEduLevel.Items.Add(item);
                }

                Conn.Close();
            }
        }
    }
}