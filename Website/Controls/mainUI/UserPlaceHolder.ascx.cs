using System;
using Model.Entity;
using tuanva.Core;

namespace Website.Controls.mainUI
{
    public partial class UserPlaceHolder : System.Web.UI.UserControl
    {
        protected User UserLogged;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.Session_Member_Account] == null)
            {
                Response.Redirect("/Account");
                return;
            }
            UserLogged = Session[Constant.Session_Member_Account] as User;
        }
    }
}