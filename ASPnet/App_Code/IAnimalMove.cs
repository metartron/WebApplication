using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPnet.App_Code
{
    public interface IAnimalMove
    {
        //介面不可以實作方法內容
        string Move(int m);
    }
}
