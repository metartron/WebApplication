using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework
{
    public partial class HW3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //試寫一撲克牌發牌程式，將52張牌發給四玩家，每家共13張，並利用poker_img資料夾裡的素材來顯示撲克牌。
            //(ps.每次發牌均需為不同結果)
            int[] randomNum = new int[52];
            int iLen = randomNum.Length;
            for (int i = 0; i < iLen ; i++)
            {
                randomNum[i] = (i + 1);
                Response.Write("<img src='poker_img/" + randomNum[i] + ".gif' />");
            }
            Response.Write("<hr>");
            ///////////////////////////////////////////////////////////////////////////
            Random rd = new Random();
            int ir;
            int tmp;
            for (int i = 0; i < iLen ; i++)
            {
                ir = rd.Next(i, iLen);
                if (i == ir) continue;
                tmp = randomNum[i];
                randomNum[i] = randomNum[ir];
                randomNum[ir] = tmp;
            }
            for (int i = 0; i < iLen ; i++)
            {
                Response.Write("<img src='poker_img/" + randomNum[i] + ".gif' />");
            }
            Response.Write("<hr>");
            ///////////////////////////////////////////////////////////////////////////
            int ifixrow = 4;
            int ifoxcol = 13;
            int irow = 0;
            int icol = 0;
            int[,] sPoker = new int[ifixrow, ifoxcol];

            for (int i = 0; i < iLen ; i++)
            {
                if (irow == ifixrow)
                {
                    irow = 0;
                    icol++;
                }
                sPoker[irow, icol] = randomNum[i];
                irow++;
                if (icol == ifoxcol)
                {
                    break;
                }
            }
            for (int i = 0; i < ifixrow; i++)
            {
                Response.Write((i+1) +" : ");
                for (int j = 0; j < ifoxcol; j++)
                {
                    Response.Write("<img src='poker_img/" + sPoker[i,j] + ".gif' />");
                }
                Response.Write("<br>");
            }
        }
    }
}