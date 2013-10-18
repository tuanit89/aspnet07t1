using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.LogicProcess;

namespace Website.API
{
    /// <summary>
    /// Summary description for Login
    /// </summary>
    public class Login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
            var t = context.Request.Form["accesstoken"];
            var fb = new FBHelper(t);
            fb.GetUser();
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