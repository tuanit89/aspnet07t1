using System;
using tuanva.Core;

public partial class LogOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            var refer = Request.QueryString["UrlRef"];
            if (Session[Constant.Session_Member_Account] != null)
            {
                Session.Remove(Constant.Session_Member_Account);
                Session[Constant.Session_Member_Account]=null;
            }

            if (string.IsNullOrEmpty(refer))
            {
                Response.Redirect("/index.aspx");
            }
            else
            {
                Response.Redirect(refer);
            }
        }
    }
}