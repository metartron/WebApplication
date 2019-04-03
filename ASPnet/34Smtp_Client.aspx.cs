using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace ASPnet
{
    public partial class _34Smtp_Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SmtpClient myMail = new SmtpClient("msa.hinet.net");
            SmtpClient myMail = new SmtpClient("smtp.gmail.com", 587);
            myMail.Credentials = new NetworkCredential("metartron@gmail.com", "");
            //myMail.UseDefaultCredentials = false;
            myMail.EnableSsl = true;
            myMail.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

            //純文字
            //string from = "meta.rtron@gmail.com";
            //string to = "metartron@gmail.com";
            //string subject = "邀請測試";
            //string body = "第一行\n第二行\n第三行";
            //myMail.Send(from, to, subject, body);

            MailAddress from = new MailAddress("metartron@gmail.com","天晴好多雲");
            MailAddress to = new MailAddress("meta.rtron@gmail.com");
            MailMessage Msg = new MailMessage(from,to);
            Msg.Subject = "邀請測試";
            //Msg.Body = "第一行\n第二行\n第三行 <img src=''>";
            mailBody(Msg);
            Msg.IsBodyHtml = true;

            myMail.Send(Msg);
        }

        public void mailBody(MailMessage mail)
        {
            string palinBody = "【測試】";
            AlternateView plainView = AlternateView.CreateAlternateViewFromString(
                     palinBody, null, "text/plain");

            string htmlBody = "<p> 此為系統主動發送信函，請勿直接回覆此封信件。</p> ";
            htmlBody += "<img alt=\"\" hspace=0 src=\"cid:friday\" align=baseline border=0 >";

            AlternateView htmlView =
                    AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
            imgResource(htmlView, "friday.jpg", "image/jpg");


            // add the views
            mail.AlternateViews.Add(plainView);
            mail.AlternateViews.Add(htmlView);
        }

        public void imgResource(AlternateView htmlView, string imgName, string imgType)
        {
            // create image resource from image path using LinkedResource class..   
            LinkedResource imageResource = new LinkedResource(getImgPath(imgName), imgType);
            string[] imgArr = imgName.Split('.');
            imageResource.ContentId = imgArr[0];
            imageResource.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;
            htmlView.LinkedResources.Add(imageResource);

        }

        private string getImgPath(string strImgName)
        {
            //設定(絕對)圖片路徑
            string strImgPath = @"D:\Users\c50120\Pictures\" + strImgName;
            return strImgPath;
        }
    }
}