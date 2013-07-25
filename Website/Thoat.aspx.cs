using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPSnippets.FaceBookAPI;
using System.Web.Script.Serialization;
using FacebookAPI;

public partial class Thoat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            HttpCookie myCookie = new HttpCookie("idUser");
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            Context.Response.Cookies.Add(myCookie);
            FaceBookConnect.Logout(Request.QueryString["code"]);
            Response.Redirect("Default.aspx");
        }
    }
}