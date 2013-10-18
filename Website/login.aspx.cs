using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPSnippets.FaceBookAPI;
using System.Web.Script.Serialization;
using Model.LogicProcess;

public partial class login : System.Web.UI.Page
{
    private static string _appId = ConfigurationManager.AppSettings["appId"];
    private static string _appSecret = ConfigurationManager.AppSettings["appSecret"];

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Logout(object sender, EventArgs e)
    {
        HttpCookie myCookie = new HttpCookie("idUser");
        myCookie.Expires = DateTime.Now.AddDays(-1d);
        Context.Response.Cookies.Add(myCookie);
        FaceBookConnect.Logout(Request.QueryString["code"]);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FaceBookConnect.Authorize("user_photos,email,user_location,user_birthday", Request.Url.AbsoluteUri.Split('?')[0]);
    }
    public class FaceBookUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PictureUrl { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public FaceBookEntity Location { get; set; }
    }

    public class FaceBookEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
