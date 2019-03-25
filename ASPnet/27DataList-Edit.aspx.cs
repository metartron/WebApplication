using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;

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
                {
                    rbl.Items[1].Selected = true;
                }

            }
            else if (e.CommandName == "Cancel")
            {
                DataList1.EditItemIndex = -1;
                DataBind();
            }
            //else if (e.CommandName == "Update")
            //{
                

            //}
        }

        protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            Label proID = (Label)e.Item.FindControl("lblProduct_ID");

            //上傳新的產品圖檔
            FileUpload img = (FileUpload)e.Item.FindControl("fulProductsImg");
            if (img.FileName != "")
            {
                img.SaveAs(Server.MapPath("/tmpImage/temp.jpg"));//因為Chrome無法直接被fileupdate存檔,需要先存在tmp file再另存

                //System.Drawing.Image g = System.Drawing.Image.FromFile(img.PostedFile.FileName);
                System.Drawing.Image g = System.Drawing.Image.FromFile(Server.MapPath("/tmpImage/temp.jpg"));

                ImageFormat imgformat = g.RawFormat;
                Bitmap newImg = new Bitmap(g,360,360); //重新設定大圖圖檔大小
                Bitmap newSImg = new Bitmap(g, 123, 120); //重新設定小圖圖檔大小


                if (img.PostedFile.ContentType == "image/jpeg")
                {
                    //img.SaveAs(Server.MapPath("/ProductsImg/" + proID.Text + ".jpg"));
                    newImg.Save(Server.MapPath("/ProductsImg/" + proID.Text + ".jpg"));
                    newSImg.Save(Server.MapPath("/ProductsImg/s" + proID.Text + ".jpg"));
                }
                else if (img.PostedFile.ContentType == "image/png")
                {
                    //img.SaveAs(Server.MapPath("/ProductsImg/" + proID.Text + ".png"));
                    newImg.Save(Server.MapPath("/ProductsImg/" + proID.Text + ".png"));
                    newSImg.Save(Server.MapPath("/ProductsImg/s" + proID.Text + ".png"));
                }
                //else
                //{
                //    //上傳圖片有誤
                //}
            }

            //資料寫回資料庫
            
            TextBox name =(TextBox)e.Item.FindControl("txtProduct_Name");
            TextBox price = (TextBox)e.Item.FindControl("txtProduct_Price");
            TextBox price2 = (TextBox)e.Item.FindControl("txtProduct_Price2");
            TextBox intro = (TextBox)e.Item.FindControl("txtProduct_Intro");
            RadioButtonList status = (RadioButtonList)e.Item.FindControl("rblProduct_Status");

            SqlDataSource1.UpdateParameters["Product_ID"].DefaultValue = proID.Text;
            SqlDataSource1.UpdateParameters["Product_Name"].DefaultValue = name.Text;
            SqlDataSource1.UpdateParameters["Product_Price"].DefaultValue = price.Text;
            SqlDataSource1.UpdateParameters["Product_Price2"].DefaultValue = price2.Text;
            SqlDataSource1.UpdateParameters["Product_Intro"].DefaultValue = intro.Text;
            SqlDataSource1.UpdateParameters["Product_Status"].DefaultValue = status.SelectedValue;

            SqlDataSource1.Update();
            DataList1.EditItemIndex = -1;
            DataBind();
        }
    }
}