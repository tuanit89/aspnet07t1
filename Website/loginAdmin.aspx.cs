using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class loginAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        string sql = "Select Count(*) from tbluserAdmin where userName =N'" + UserName.Text.Trim() + "' and RTRIM(passWorld) =N'" + md5(Password.Text.Trim()) + "'";
        string sql1 = "Select id_Admin from tbluserAdmin where userName =N'" + UserName.Text.Trim() + "'";
        int idAdmin = DataAccess.ExeSQLGetInt(sql1);
        int data = DataAccess.ExeSQLGetInt(sql);
        if (DataAccess.ExeSQLGetInt(sql) == 1)
        {
            //Session.Add("idAdmin", idAdmin);
            HttpCookie user = new HttpCookie("idAdmin");
            user.Value = idAdmin.ToString();
            Context.Response.Cookies.Add(user);
            Response.Redirect("admin.aspx");
        }
    }
    public static byte[] encryptData(string data)
    {
        System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashedBytes;
        System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
        return hashedBytes;
    }
    public static string md5(string data)
    {
        return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
    }
}