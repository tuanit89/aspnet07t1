using System;
using System.Web;
using Model.Entity;
using tuanva.Core;

namespace Website.Controls.mainUI
{
    public partial class header : System.Web.UI.UserControl
    {
        protected User UserLogged;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            UserLogged = HttpContext.Current.Session[Constant.Session_Member_Account] as User;;
        }
    }
}