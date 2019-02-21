using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ASPnet
{
    public partial class member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //送出
        protected void Button1_Click(object sender, EventArgs e)
        {

            //抓textbox
            Response.Write(txtAccount.Text);
            Response.Write(txtEmail.Text);
            Response.Write(txtName.Text);
            Response.Write(txtPwd.Text);
            Response.Write(txtPwd2.Text);
            //抓dropdownlist
            Response.Write(ddlEduLevel.SelectedItem.Text);
            //抓radiobuttonlist
            Response.Write(rblGender.SelectedItem.Text);
            //抓radiobutton
            if (rdbMale.Checked == true)
            {
                Response.Write(rdbMale.Text);
            }
            else
            {
                Response.Write(rdbFemale.Text);
            }

            //抓checkboxlist
            for (int i = 0; i < cblInterest.Items.Count; i++)
            {
                if (cblInterest.Items[i].Selected == true)
                {
                    Response.Write(cblInterest.Items[i].Text);
                }
            }

            if (ckbInterest1.Checked == true)
            {
                Response.Write(ckbInterest1.Text);
            }
            if (ckbInterest2.Checked == true)
            {
                Response.Write(ckbInterest2.Text);
            }
            if (ckbInterest3.Checked == true)
            {
                Response.Write(ckbInterest3.Text);
            }
            if (ckbInterest4.Checked == true)
            {
                Response.Write(ckbInterest4.Text);
            }
            if (ckbInterest5.Checked == true)
            {
                Response.Write(ckbInterest5.Text);
            }

        }
    }
}