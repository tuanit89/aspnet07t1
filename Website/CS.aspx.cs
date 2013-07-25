using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPSnippets.FaceBookAPI;
using System.Web.Script.Serialization;
using System.Collections.Generic;

public partial class CS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FaceBookConnect.API_Key = "560041050701551";
        FaceBookConnect.API_Secret = "1eba64b3df3f45121c82ce96f1484749";
        if (!IsPostBack)
        {
            
        }
    }

    protected void Login(object sender, EventArgs e)
    {
        FaceBookConnect.Authorize("user_photos,email", Request.Url.AbsoluteUri.Split('?')[0]);
    }
    protected void Logout(object sender, EventArgs e)
    {
        FaceBookConnect.Logout(Request.QueryString["code"]);
    }
}
public class FaceBookUser
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string UserName { get; set; }
    public string PictureUrl { get; set; }
    public string Email { get; set; }
}


