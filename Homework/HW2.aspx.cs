using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework
{
    public partial class HW2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        //1.質數判斷(必須用回圈)
        //請給定一個整數變數值，判斷其是否為質數，若是，請在螢幕顯示「○○是質數」，
        //若不是，請在螢幕顯示「○○不是質數」。
        //如例變數值為13，即顯示「13是質數」。(ps.質數的定義為除了1與本身之外，沒有其他的因數存在)
        #region 質數判斷(必須用回圈)
        protected void btn1_Click(object sender, EventArgs e)
        {
            int itemp = Convert.ToInt32(txtBox1.Text);
            bool isPrimeNumber = true;
            //預先排除1,2相關倍數,3相關倍數,5相關倍數,7相關倍數

            if (itemp % 2 == 0 && (itemp / 2) > 1)
            {
                isPrimeNumber = false;
            }
            else if (itemp % 3 == 0 && (itemp / 3) > 1)
            {
                isPrimeNumber = false;
            }
            else if (itemp % 5 == 0 && (itemp / 5) > 1)
            {
                isPrimeNumber = false;
            }
            else if (itemp % 7 == 0 && (itemp / 7) > 1)
            {
                isPrimeNumber = false;
            }

            if (isPrimeNumber)
            {
                for (int i = 2; i < itemp; i++)
                {
                    if (itemp % i == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
            }

            switch (isPrimeNumber)
            {
                case true:
                    lblResult1.Text = "結果:" + itemp + "是質數";
                    break;
                case false:
                    lblResult1.Text = "結果:" + itemp + "不是質數";
                    break;
            }
          
        }
        #endregion
        //2.	求最大公因數(必須用回圈)
        //請給定兩個整數變數值，求其兩數之最大公因數，並在螢幕顯示「○○與○○之最大公因數為○○」。
        //如例變數值為12及18，即顯示「 12及18 之最大公因數為6」（ps.最大公因數的定義為某幾個整數所共同擁有的最大因數）
        #region
        protected void btn2_Click(object sender, EventArgs e)
        {
            int iA = Convert.ToInt32(txtBox2.Text);
            int iB = Convert.ToInt32(txtBox3.Text);

            int iResult = 0;
            int iDividend = iA; //被除數
            int iDivisor = iB;  //除數
            int iremainder = 0; //餘數

            while (iDividend % iDivisor != 0)
            {
                iremainder = iDividend % iDivisor;
                iDividend = iDivisor;
                iDivisor = iremainder;
            }
            lblResult2.Text = "結果:"+ iA +"和"+ iB + "最大公因數是"+ iDivisor;
        }


        #endregion

        //3.	迴文判斷(必須用回圈)
        //請給定一個九位數以內的整數變數值，判斷其是否為迴文，若是，請在螢幕顯示「○○○○是迴文」，
        //若不是，請在螢幕顯示「○○不是迴文」。如例變數值為12321，即顯示「12321是迴文」。
        //(ps.迴文的定義為一個數字，由左唸至右及由右唸至左時，皆一模一樣)
        //提示:到過來排再比較 n%10-取個位數  n/10%10-取十位數
        #region
        protected void btn3_Click(object sender, EventArgs e)
        {
            int iInput = Convert.ToInt32(txtBox4.Text);

            int iA = 0, iB = 0, iPalindromes = iInput;
            string sResult = "";
            for (int i = 1; i < 9; i++)
            {
                iA = iPalindromes % 10;
                iB = iPalindromes / 10;
                sResult += iA;

                if (iB == 0)
                    break;
                else iPalindromes = iB;
            }

            if(iInput.ToString()== sResult)
                lblResult3.Text = "結果:"+ iInput+"是迴文";
            else
                lblResult3.Text = "結果:" + iInput + "不是迴文";
        }
        #endregion
    }
}