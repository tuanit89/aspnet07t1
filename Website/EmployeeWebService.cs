using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for EmployeeWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
[System.Web.Script.Services.ScriptService]
public class MultipleUpdateWebService : System.Web.Services.WebService
{
    // getting connection string
    //string conStr = ConfigurationManager.ConnectionStrings["SampleTestDBConnectionString1"].ConnectionString;
    int rowsInserted = 0;  
    HttpCookie user = new HttpCookie("idFacebook");
    [WebMethod]
      public string ReceiveUpdatesWebservice(string idFacebook, string tenTaiKhoan, string tenHienThi, string avatar, string email)
    {

        string sql1 = "Select * from tblTaiKhoan where idFacebook =N'" + idFacebook + "'";
        string ktra = DataAccess.ExeSQLGetData(sql1);
        if (ktra == "")
        {
            string sql = string.Format(@"INSERT INTO  tblTaiKhoan(idFacebook,tenTaiKhoan,tenHienThi,avatar,email) VALUES('{0}','{1}',N'{2}',N'{3}','{4}')", idFacebook, tenTaiKhoan, tenHienThi, avatar, email);
            DataAccess.ExeNonSQL(sql);
            
        }

        //user.Value = ktra.ToString();
        ////StudentCookies.Expires = DateTime.Now.AddHours(1);
        //Context.Response.Cookies.Add(user);
       

        return string.Format("Thank you, {0} number of rows inserted!", rowsInserted);
    }
    [WebMethod]
    public string updatechan(string id)
    {
        string color = null;
         HttpCookie cookie = Context.Request.Cookies["idUser"];

            string cookieVaue;
            if (null == cookie)
            {
                Context.Response.Redirect("Default.aspx");
            }
            else
            {
                cookieVaue = cookie.Value.ToString();
                string sql = "Select idPic from tblvote where idUser =" + cookieVaue + " and idPic =" + id;
                long Insert = DataAccess.ExeSQLGetlong(sql);
                if (Insert == 0)
                {
                    string sql_insert = "Insert tblvote values(" + cookieVaue + "," + id + ",0)";
                    DataAccess.ExeNonSQL(sql_insert);
                    color = "red";
                }
                else
                {
                    string sql1 = "Select idPic from tblvote where idUser =" + cookieVaue + " and idPic =" + id+" and vote=1";
                    long update = DataAccess.ExeSQLGetlong(sql1);
                    if (update !=0)
                    {
                        string sql_update = "Update tblvote set vote=0 where idUser =" + cookieVaue + " and idPic =" + id;
                        DataAccess.ExeNonSQL(sql_update);
                        color = "red";
                    }
                    else
                    { 
                        string sql_delete = "Delete tblvote  where idUser =" + cookieVaue + " and idPic =" + id;
                        DataAccess.ExeNonSQL(sql_delete);
                        color = "#F4F4F4";
                    }
                }
            }

            return string.Format("{0}", color);
    }
    [WebMethod]
    public string updatehay(string id)
    {
        string color = null;
        HttpCookie cookie = Context.Request.Cookies["idUser"];

        string cookieVaue;
        if (null == cookie)
        {
            Context.Response.Redirect("Default.aspx");
        }
        else
        {
            cookieVaue = cookie.Value.ToString();
            string sql = "Select idPic from tblvote where idUser =" + cookieVaue + " and idPic =" + id;
            long Insert = DataAccess.ExeSQLGetlong(sql);
            if (Insert == 0)
            {
                string sql_insert = "Insert tblvote values(" + cookieVaue + "," + id + ",1)";
                DataAccess.ExeNonSQL(sql_insert);
                color = "blue";
            }
            else
            {
                string sql1 = "Select idPic from tblvote where idUser =" + cookieVaue + " and idPic =" + id + " and vote=0";
                long update = DataAccess.ExeSQLGetlong(sql1);
                if (update != 0)
                {
                    string sql_update = "Update tblvote set vote=1 where idUser =" + cookieVaue + " and idPic =" + id;
                    DataAccess.ExeNonSQL(sql_update);
                    color = "blue";
                }
                else
                {
                    string sql_delete = "Delete tblvote  where idUser =" + cookieVaue + " and idPic =" + id;
                    DataAccess.ExeNonSQL(sql_delete);
                    color = "#F4F4F4";
                }
            }
        }

        return string.Format("{0}", color);
    }


}


