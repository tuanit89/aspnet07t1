using System;
using tuanva.Core;

public partial class Notification : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session[Constant.Session_Member_Account] == null)
        {
            Response.Redirect("/Account/");
        }
    }
}