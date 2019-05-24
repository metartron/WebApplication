using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPnet.App_Code
{
    //抽象類別
    public abstract class Animal
    {
        //抽象方法:只做名稱,不做內容
        public abstract string Speak();

        //一般方法:裡面有邏輯
        public string Move(int m)
        {
            return "移動了" + m + "公尺";
        }
    }
}