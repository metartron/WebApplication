using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework
{
    public partial class HW1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("1.宣告變數a為整數，值為42，宣告變數b為浮點數，值2.5，將兩值分別做加、減、乘、除及取餘數之運算，並輸出其結果。<br>");
            int a = 42;
            float b = 2.5f;
            Response.Write("a+b=" + (a + b) + "<br>");
            Response.Write("a-b=" + (a - b) + "<br>");
            Response.Write("a*b=" + (a * b) + "<br>");
            Response.Write("a/b=" + (a / b) + "<br>");
            Response.Write("a%b=" + (a % b) + "<br>");

            //////////////////////////////////////////
            Response.Write("<hr />");
            Response.Write("2.	撰寫一個將攝氏溫度轉換為華氏溫度的程式，攝氏溫度的值直接在程式中給定即可。(華氏＝攝氏*9/5+32)<br>");
            float c = 33.5f;
            Response.Write("攝氏" + c + "度等於華氏" + (c * 9 / 5 + 32) + "度");
            //////////////////////////////////////////
            Response.Write("<hr />");
            Response.Write("3.	設有兩個變數X與Y，其值為任何整數，試寫在不另宣告其他變數的情況下，交換X與Y的值的程式。(例X = 3, Y = 5, 執行完您的程式後X = 5, Y = 3<br>");
            int X = 3, Y = 5;
            X = X ^ Y;
            Y = X ^ Y;
            X = X ^ Y;

            Response.Write("X=" + X + ", Y=" + Y);
            //////////////////////////////////////////
            Response.Write("<hr />");
            Response.Write("4.	請利用switch敘述句，分別試寫判斷成績等第之程式。90分以上為優等，80~89為甲等，70~79為乙等，60~69為丙等，其餘為丁等(不可另外搭配if 敘述句)。<br>");
            int score2 = 85;
            Response.Write(score2 + "是");
            switch (score2 / 10)
            {
                case 10:
                case 9:
                    Response.Write("優等");
                    break;
                case 8:
                    Response.Write("甲等");
                    break;
                case 7:
                    Response.Write("乙等");
                    break;
                case 6:
                    Response.Write("丙等");
                    break;
                default:
                    Response.Write("丁等");
                    break;
            }
            //////////////////////////////////////////
            Response.Write("<hr />");
            Response.Write("5.	寫一顯示1~100整數中，不是5的倍數的程式。<br>");
            int iNum5 = 1;
            string sResult5 = "";
            while (iNum5 < 101)
            {
                if (iNum5 % 5 != 0)
                {
                    sResult5 += iNum5+",";
                }
                iNum5++;
            }
            Response.Write(sResult5.Remove(sResult5.Length-1));
            //////////////////////////////////////////
            Response.Write("<hr />");
            Response.Write("6.	計算1~1000中除了3倍數外所有數的總合。<br>");
            int iResult6 = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 != 0)
                {
                    iResult6 += i;
                }
            }
            Response.Write("1~1000中除了3倍數外所有數的總合:" + iResult6);
            //////////////////////////////////////////
            Response.Write("<hr />");
            Response.Write("7.	請利用回圈顯示出下方圖形。(不可以使用巢狀回圈)<br>*<br>**<br>***<br>****<br>*****<br>");
            Response.Write("Answer:<br>");
            string sResult7 = "";
            for (int i = 1; i <= 5; i++)
            {
                sResult7 += "*";
                Response.Write(sResult7 + "<br>");
            }
            //////////////////////////////////////////
            Response.Write("<hr />");
            Response.Write("8.	請利用回圈寫一九九乘法表。<br>");
           
            Response.Write("<table border='1'> <tbody>");
            for (int i = 2; i < 10; i++)
            {
                if (i==2 || i==6)
                {
                    Response.Write("<tr>");
                }
                Response.Write("<td>");
                for (int j = 1; j < 10; j++)
                {
                    Response.Write(i+"*"+j+"="+(i*j)+"<br>");
                }
                Response.Write("</td>");
                if (i == 5 || i == 9)
                {
                    Response.Write("</tr>");
                }
            }
            Response.Write("</tbody></table> ");
        }
    }
}