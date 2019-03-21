using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _27DataList_Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                DataList1.EditItemIndex = e.Item.ItemIndex;
                DataBind();
                ///////////////////////////////////////////////////////////////////////////////////////////
                int index = e.Item.ItemIndex;
                string status = ((Label)DataList1.Items[index].FindControl("lblProduct_Status")).Text;
                RadioButtonList rbl = (RadioButtonList)DataList1.Items[index].FindControl("rblProduct_Status");
                //string status = ((TextBox)e.Item.FindControl("txtProduct_Status")).Text;
                //TextBox status2 = (TextBox)e.Item.FindControl("txtProduct_Status");
                if (status == "True")
                {
                    rbl.Items[0].Selected = true;
                }
                else
                    rbl.Items[1].Selected = true;


            }

            //if (e.Item.ItemType == ListItemType.EditItem)
            //{
            //    Label lbl = (Label)e.Item.FindControl("lblProduct_Status");
            //    RadioButtonList rbl = (RadioButtonList)e.Item.FindControl("rblProduct_Status");

            //    string status = lbl.Text.ToString();

            //    if (status == "1")
            //    {
            //        rbl.Items[0].Selected = true;
            //    }
            //    else
            //    {
            //        rbl.Items[1].Selected = true;
            //    }
            //}
        }

       
    }
}