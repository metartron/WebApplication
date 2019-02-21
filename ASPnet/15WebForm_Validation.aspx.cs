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
            args.IsValid = true;//驗證通過 errormessage不會出現

            //除了檢查碼外每個數字的存放空間 
            int[] iSeed = new int[10];

            //建立字母陣列(A~Z)
            //A=10 B=11 C=12 D=13 E=14 F=15 G=16 H=17 J=18 K=19 L=20 M=21 N=22
            //P=23 Q=24 R=25 S=26 T=27 U=28 V=29 X=30 Y=31 W=32  Z=33 I=34 O=35 
            string[] sMapping = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "X", "Y", "W", "Z", "I", "O" } ;

            string sFirst = txtID.Text.Substring(0, 1); //取第一個英文數字
            for (int index = 0; index < sMapping.Length; index++)
            {
                if (sMapping[index] == sFirst)
                {
                    index += 10;
                    //10進制的高位元放入存放空間   (權重*1)
                    iSeed[0] = index / 10;

                    //10進制的低位元*9後放入存放空間 (權重*9)
                    iSeed[1] = (index % 10) * 9;

                    break;
                }
            }


        }
        #endregion
    }
}