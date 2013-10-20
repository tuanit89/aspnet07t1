using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Model.LogicProcess;
using tuanva.Core;

namespace Website.API
{
    /// <summary>
    /// Summary description for Login
    /// </summary>
    public class Login : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            
            if (context.Session[Constant.Session_Member_Account]!=null)
            {
                context.Response.Redirect("/");
                return;
            }
            var t = context.Request.Form["accesstoken"];
            var fb = new FBHelper(t);
            var user = fb.GetUser();
            context.Session.Add(Constant.Session_Member_Account, user);
            context.Response.Redirect("/index.aspx");
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