using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPSnippets.FaceBookAPI;
using System.Web.Script.Serialization;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FaceBookConnect.API_Key = "420013488112907";
        FaceBookConnect.API_Secret = "ca65a6090d5f7edbdae95d2dd5ae551e";
        if (!IsPostBack)
        {
            
            if (Request.QueryString["logout"] == "true")
            {
                Response.Redirect("Default.aspx");
            }
            
            if (Request.QueryString["error"] == "access_denied")
            {
                
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('User has denied access.')", true);
                return;
            }

            string code = Request.QueryString["code"];
            if (!string.IsNullOrEmpty(code))
            {
                long ktra;
                string data = FaceBookConnect.Fetch(code, "me");
                FaceBookUser faceBookUser = new JavaScriptSerializer().Deserialize<FaceBookUser>(data);
                faceBookUser.PictureUrl = string.Format("https://graph.facebook.com/{0}/picture", faceBookUser.Id);
                string sql1 = "Select idUser from tblTaiKhoan where idFacebook =N'" + faceBookUser.Id + "'";
                ktra = DataAccess.ExeSQLGetlong(sql1);
                if (ktra == 0)
                {
                    string sql = string.Format(@"INSERT INTO  tblTaiKhoan(idFacebook,tenTaiKhoan,tenHienThi,avatar,email,luotlike,luotcommend,ngayDK,hienFace) VALUES('{0}','{1}',N'{2}',N'{3}','{4}','{5}','{6}',CONVERT(date,'{7}', 103),'{8}')", faceBookUser.Id, faceBookUser.UserName, faceBookUser.Name, faceBookUser.PictureUrl, faceBookUser.Email, 0, 0, DateTime.Now.ToString("dd/MM/yyyy"), 0);
                    DataAccess.ExeNonSQL(sql);
                    ktra = DataAccess.ExeSQLGetlong(sql1);

                }
                HttpCookie user = new HttpCookie("idUser");
                user.Value = ktra.ToString();
                Context.Response.Cookies.Add(user);


            }
            HttpCookie cookie = Context.Request.Cookies["idUser"];
            if (null != cookie)
            {
                Response.Redirect("Default.aspx");

            }
            
        }
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
