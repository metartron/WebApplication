using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _02Var : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<h1>Hellow World!!</h1>");
            //字串
            string var;
            var = "Hellow World!!";
            var = "abcde";
            Response.Write(var);
            Response.Write("<br>");
            //布林值
            bool gender = true;

            //整數
            int a = 9999945; //32bit整數
            long b = 23343433; //64bit整數
            short c = 444;//16bit整數
            byte d = 5;//8bit正整數

            //浮點數
            float f = 123.123f;
            Response.Write(f);
            double g = 123.123;

            //變數命名原則
            //不可以用保留字
            //開頭必須是英文字母或底線
            //同一支程式區塊內,變數名稱不可重複,大小寫視為不同

            //變數命名原則
            //使用有意義的名稱
            //使用匈牙利命名法
            string strStudentNo = "12345679";
            int intNumber = 123;
        }
    }
}