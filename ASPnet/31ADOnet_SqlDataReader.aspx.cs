using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data.SqlClient;
using System.Configuration;


namespace ASPnet
{
    public partial class _31ADOnet_SqlDataReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySystemConnectionString1"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Products2", Conn);

            SqlDataReader rd;
            Conn.Open();
            rd=cmd.ExecuteReader();
            while (rd.Read())
            {
                Response.Write(rd["Product_ID"] +"-"+rd["Product_Name"]+"<br />");
            }
            Conn.Close();
        }
    }
}