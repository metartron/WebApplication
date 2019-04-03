using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;

using System.Net.Mail;
using System.Net;

namespace ASPnet
{
    public partial class _33Member_Registeration : System.Web.UI.Page
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySystemConnectionString1"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //避免postback被重複執行
            {
                ranForBirthday.MaximumValue = DateTime.Now.ToString("d");

                //學歷下拉選單
                //SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySystemConnectionString1"].ConnectionString);
                SqlCommand Cmd = new SqlCommand("select * from Edu order by EduLevel_Code desc", Conn);

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
            else
            {
                //
            }
            
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            Int32 iCount = 0;

            if (this.IsValid)
            {
                try
                {
                    SqlCommand Cmd = new SqlCommand("insert into members values (@account,hashbytes('sha2_256',@pwd),@name,@birthday,@email,@gender,@edu,@note,@photo,@IsAuth)", Conn);
                    Cmd.Parameters.AddWithValue("@account", txtAccount.Text);
                    Cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);
                    Cmd.Parameters.AddWithValue("@name", txtName.Text);
                    Cmd.Parameters.AddWithValue("@birthday", txtBirthday.Text);
                    Cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    Cmd.Parameters.AddWithValue("@gender", rblGender.SelectedValue);
                    Cmd.Parameters.AddWithValue("@edu", ddlEduLevel.SelectedValue);
                    Cmd.Parameters.AddWithValue("@note", txtNote.Text);
                    Cmd.Parameters.AddWithValue("@IsAuth", false);


                    if (fulPhoto.PostedFile.ContentType == "application/octet-stream")
                    {
                        Cmd.Parameters.AddWithValue("@photo", null);
                    }
                    else
                    {
                        Cmd.Parameters.AddWithValue("@photo", fulPhoto.FileBytes);
                    }
                    Conn.Open();
                    if (fulPhoto.PostedFile.ContentType == "image/jpeg")
                    {
                        iCount = Cmd.ExecuteNonQuery();
                        SendAuthMail(txtEmail.Text, txtAccount.Text);
                    }
                    else
                    {
                        lblPhoto.Text = "照片格式錯誤!";
                    }

                    Conn.Close();

                    //if (iCount > 0)
                    //{
                        //Response.Redirect("17GridView_DataSource.aspx");
                    //}

                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }

        #region CustomValidator1_ServerValidate
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            SqlCommand Cmd = new SqlCommand("select dbo.fnCheckMemberAccount(@account)", Conn);
            Cmd.Parameters.AddWithValue("@account", txtAccount.Text);

            SqlDataReader rd;
            Conn.Open();
            rd = Cmd.ExecuteReader();

            rd.Read();
            args.IsValid = (Boolean)(rd[0]);

            //if (rd[0].ToString() == "0")
            //    args.IsValid = true;
            //else
            //    args.IsValid = false;

            Conn.Close();
        }
        #endregion

        protected void SendAuthMail(string toMail, string account)
        {
            SmtpClient myMail = new SmtpClient("msa.hinet.net");
            MailAddress from = new MailAddress("metartron@gmail.com", "天晴好多雲");
            MailAddress to = new MailAddress(toMail);
            MailMessage Msg = new MailMessage(from, to);
            Msg.Subject = "會員註冊認證信";
            Msg.Body = "請點擊下列超連結完成會員註冊認證<br /> <br /><a href='http://localhost:62424/35Auth_OK.aspx?account=" + account + "' >請點我</a>";

            Msg.IsBodyHtml = true;

            myMail.Send(Msg);

            Response.Write("<script>alert('恭喜您完成會員註冊資料填寫，請至您的信箱收取認證信進行認證，方能啟用會員！');</script>");
        }
    }
}