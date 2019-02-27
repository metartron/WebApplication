using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//如何於泛型處理常式 .ashx 中存取工作階段變數(Session Variable) 
using System.Web.SessionState;
//參考：http://www.limingchstudio.com/2009/05/ashx-session-variable.html

namespace ASPnet
{
    /// <summary>
    /// readSessionValidateNumber 的摘要描述
    /// </summary>
    public class readSessionValidateNumber : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string ValidateNumber = (string)context.Session["ValidateNumber"];
            context.Response.Write(ValidateNumber);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}