using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

using System.Data.SqlClient;
using System.Configuration;

namespace ASPnet
{
    public partial class _29QR_Code : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String xtime = DateTime.Now.Millisecond.ToString(); //取得 ms 當亂數

            QRCodeEncoder encoder = new QRCodeEncoder();//建立 encoder
            encoder.QRCodeVersion = 3;
            encoder.QRCodeScale = 20;

            System.Drawing.Bitmap qrcode = encoder.Encode(TextBox1.Text); //將內容轉碼成 QR code
            //Request.PhysicalApplicationPath 抓取專案所在實際目錄路徑
            qrcode.Save(Request.PhysicalApplicationPath + "QR_Code\\qrcode" + xtime + ".jpg", ImageFormat.Jpeg); //QRcode 的 bitmap 另存為圖片檔
            Image1.ImageUrl = "~\\QR_Code\\qrcode" + xtime + ".jpg"; //以圖片檔方式顯示於 Image
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();//建立 encoder
            encoder.QRCodeVersion = 3;
            encoder.QRCodeScale = 10;

            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySystemConnectionString1"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select Product_ID from Products", Conn);
            SqlDataReader rd;
            Conn.Open();
            rd = cmd.ExecuteReader();

            string ProductID = "";
            while (rd.Read())
            {
                ProductID = rd["Product_ID"].ToString();
                System.Drawing.Bitmap qrcode = encoder.Encode(ProductID); //將內容轉碼成 QR code
                                                                              //Request.PhysicalApplicationPath 抓取專案所在實際目錄路徑
                qrcode.Save(Server.MapPath("/QR_Code/" + ProductID + ".jpg"), ImageFormat.Jpeg); //QRcode 的 bitmap 另存為圖片檔

                Image image = new Image();

                image.ImageUrl = "/QR_Code/" + ProductID + ".jpg"; //以圖片檔方式顯示於 Image
                form1.Controls.Add(image);
                
            }
            Conn.Close();
        }
    }
}