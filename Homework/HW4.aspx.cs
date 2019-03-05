using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework
{
    public partial class HW4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbInterest.Items.Count; i++)
            {
                ltbInterestFinal.Items.Add(ltbInterest.Items[i].Text);
            }
            ltbInterest.Items.Clear();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbInterest.Items.Count; i++)
            {
                if (ltbInterest.Items[i].Selected)
                {
                    ltbInterestFinal.Items.Add(ltbInterest.Items[i].Text);
                    ltbInterest.Items.RemoveAt(i);
                }
            }
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbInterestFinal.Items.Count; i++)
            {
                if (ltbInterestFinal.Items[i].Selected)
                {
                    ltbInterest.Items.Add(ltbInterestFinal.Items[i].Text);
                    ltbInterestFinal.Items.RemoveAt(i);
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbInterestFinal.Items.Count; i++)
            {
                ltbInterest.Items.Add(ltbInterestFinal.Items[i].Text);
            }
            ltbInterestFinal.Items.Clear();
        }
    }
}