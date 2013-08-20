using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net;
using System.IO;

public partial class photoupload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    //    if (!Page.IsPostBack)
    //    {
            
    //        string id = Request.QueryString["user"];
    //        string Update_like = "Select Sum(luotLike) from tblPic where idUser =" + id;
    //        string sql4 = "Update tblTaiKhoan set luotlike =" + DataAccess.ExeSQLGetlong(Update_like) + "where idUser =" + id;
    //        DataAccess.ExeNonSQL(sql4);
    //        string sql = "Select tblTaiKhoan.idUser,tblTaiKhoan.tenHienThi,tblPic.idPic,tblPic.tieuDe,tblPic.url,luotxem from tblTaiKhoan inner join tblPic on tblTaiKhoan.idUser = tblPic.idUser where tblPic.hienAnh=1 and tblTaiKhoan.idUser=" + id + "Order by tblPic.idPic desc";
    //        dtlphoto.DataSource = DataAccess.ExeSQLToDataTable(sql);
    //        dtlphoto.DataBind();
    //        string sql1 = "Select ngayDang,idPic,dangFile from tblPic where idUser =" + id;
    //        DataSet ds = DataAccess.ExeSQLToDataSet(sql1);
           
    //        int k = 0;
    //        int l = 0;
    //        for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
    //        {
    //            DataTable dt = DataAccess.GetFacebook("http://duocday.com/Detailphoto.aspx?ID=" + ds.Tables[0].Rows[j][1].ToString());
    //            k = k + int.Parse(dt.Rows[0][4].ToString());
    //            l = l + int.Parse(dt.Rows[0][3].ToString());
    //            dt.Clear();
    //        }
    //        string Update_user = "Update tblTaiKhoan set luotlike =" + k + ", luotcommend =" + l + " where idUser=" + id;
    //        DataAccess.ExeNonSQL(Update_user);
    //        int i = 0; 
            
          
    //       foreach (DataListItem dli in dtlphoto.Items)
    //        {
    //            DataTable dt = DataAccess.GetFacebook("http://duocday.com/Detailphoto.aspx?ID=" + ds.Tables[0].Rows[i][1].ToString());
    //            Label commend = (Label)dli.FindControl("Label2");
    //            commend.Text = dt.Rows[0][3].ToString();
    //            TimeSpan diff = DateTime.Now - DateTime.Parse(ds.Tables[0].Rows[i][0].ToString());
    //            String sMsg ="";
    //            if(diff.Days>0) sMsg = String.Format("{0} ngày", diff.Days);
    //            else if (diff.Hours > 0) sMsg = String.Format("{0} giờ", diff.Hours);
    //            else if(diff.Minutes > 0) sMsg = String.Format("{0} phut", diff.Minutes);
    //            Label name = (Label)dli.FindControl("Label1");
    //            name.Text = sMsg;
    //            Literal Literal1 = (Literal)dli.FindControl("Literal1");
    //            if (ds.Tables[0].Rows[i][2].ToString() == "False")
    //            {
    //                Literal1.Text = "<img class=\"videoIndicator\" src=\"images/play_icon.png\"></img>";
    //            }
    //            i++;
    //        }
    //    }
    }
    //public DataTable BindDatatable()
    //{
    //    //List<UrlDetails> details = new List<UrlDetails>();
    //    WebClient web = new WebClient();
    //    string url = string.Format("https://api.facebook.com/method/fql.query?query=SELECT name,value FROM cookies where uid='100004688792226'");
    //    //  string url = string.Format("https://api.facebook.com/restserver.php?method=links.getStats&urls=facebook.com");
    //    string response = web.DownloadString(url);
    //    DataSet ds = new DataSet();
    //    using (StringReader stringReader = new StringReader(response))
    //    {
    //        ds = new DataSet();
    //        ds.ReadXml(stringReader);
    //    }
    //    DataTable dt = ds.Tables["cookies"];
    //    //foreach (DataRow dtrow in dt.Rows)
    //    //{
    //    //    UrlDetails website = new UrlDetails();
    //    //    website.Url = dtrow["url"].ToString();
    //    //    website.LikeCount = dtrow["like_count"].ToString();
    //    //    website.SharedCount = dtrow["share_count"].ToString();
    //    //    website.CommentCount = dtrow["comment_count"].ToString();
    //    //    website.ClickCount = dtrow["click_count"].ToString();
    //    //    website.TotalCount = dtrow["total_count"].ToString();
    //    //    details.Add(website);
    //    //}
    //    return dt;
    //}
}