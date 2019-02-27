using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _15WebForm_Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ranForBirthday.MaximumValue = DateTime.Now.ToString("d");
        }

        #region btnAll_Click
        protected void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbInterest.Items.Count; i++)
            {
                ltbInterestFinal.Items.Add(ltbInterest.Items[i].Text);
            }
            ltbInterest.Items.Clear();
        }
        #endregion

        #region btnCancel_Click
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbInterestFinal.Items.Count; i++)
            {
                ltbInterest.Items.Add(ltbInterestFinal.Items[i].Text);
            }
            ltbInterestFinal.Items.Clear();
        }
        #endregion

        #region btnYes_Click
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
        #endregion

        #region btnNo_Click
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
        #endregion

        #region 身分證驗證
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {


            //建立字母陣列(A~Z)
            //A=10 B=11 C=12 D=13 E=14 F=15 G=16 H=17 J=18 K=19 L=20 M=21 N=22
            //P=23 Q=24 R=25 S=26 T=27 U=28 V=29 X=30 Y=31 W=32  Z=33 I=34 O=35 
            string id = txtID.Text;

            string[] eng = {"A", "B", "C", "D", "E", "F", "G", "H", "J", "K",
                "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "X", "Y", "W",
                "Z", "I", "O" };

            int intEng = 0;

            for (int i = 0; i < eng.Length; i++)
            {
                if (eng[i] == id.Substring(0, 1).ToUpper())
                {
                    intEng = i + 10;
                    break;
                }

            }

            //假設n=17
            int n1 = intEng / 10;  //n1=1
            int n2 = intEng % 10;  //n2=7



            int[] a = new int[9];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt16(id.Substring(i + 1, 1));

            }

            int sum = 0;
            for (int i = 0; i < 8; i++)
            {

                sum += a[i] * (8 - i);
            }

            int n = 0;
            n = n1 + n2 * 9 + sum + a[8];

            //n1 +n2*9+a[0]*8+a[1]*7*a[2]*6+a[3]*5


            if (n % 10 == 0)
                args.IsValid = true;
            else
                args.IsValid = false;

        }
        #endregion

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                Response.Write("表單已成功送到伺服器");
            }
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (ltbInterestFinal.Items.Count < 3)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}