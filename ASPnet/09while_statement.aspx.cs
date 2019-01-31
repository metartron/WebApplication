using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _09while_statement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 1;
            while (i<7)
            {
                Response.Write("<h" + i + ">Welcome My Homepage!!</h" + i + ">");
                i++;
            }

            int j = 1;
            int iResult = 0;
            while (j < 1001)
            {
                iResult += j;
                j++;
            }
            Response.Write("1加到1000的結果為:" + iResult);
            ////////////////////////////////////////////////////////////////////////
            Response.Write("<hr>");
            //*
            //**
            //***
            //****
            //*****
            int k = 1;
            string sResult = "";
            while (k < 6)
            {
                sResult += "*";
                Response.Write(sResult + "<br>");
                k++;
            }
            /////////////////////////////////////////////////////////////////////////
            string[] arrRainbow = { "紅", "橙", "黃", "綠", "藍", "靛", "紫" };
            string[] arrRainbowColor = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Purple" };
            int d = 0;
            while (d < arrRainbow.Length)
            {
                Response.Write("<span style='color:" + arrRainbowColor[d] + "'>" + arrRainbow[d] + "</span>");
                d++;
            }
        }
    }
}