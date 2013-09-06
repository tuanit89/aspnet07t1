using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DetailPhoto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
            
        //    long sau;
        //    long truoc;
        //    string id = Request.QueryString["ID"];
        //    string sql = "Select tblPic.ngayDang,tblTaiKhoan.idUser,tblTaiKhoan.tenHienThi,tblPic.idPic,tblPic.dangFile,tblPic.tieuDe,tblPic.url,tblPic.luotxem,tblPic.nguonPic,tblTaiKhoan.avatar,tblPic.urlVideo from tblTaiKhoan inner join tblPic on tblTaiKhoan.idUser = tblPic.idUser where tblPic.idPic=" + id;
        //    string sql5 = "Update tblPic set luotxem = luotxem+1 where idPic=" + id;
        //    DataAccess.ExeNonSQL(sql5);
        //    dtl.DataSource = DataAccess.ExeSQLToDataTable(sql);
        //    dtl.DataBind();
        //    //if (bien_ktra != 0)
        //    //{

        //    string sql1 = "select tblvote.idPic from tblvote inner join tblPic on tblvote.idPic = tblPic.idPic where vote=1 and tblvote.idPic<" + id + " and tblPic.idChuyenMuc=1 group by tblvote.idPic having count(vote)>2 order by idPic desc";
        //    string sql2 = "select tblvote.idPic from tblvote inner join tblPic on tblvote.idPic = tblPic.idPic where vote=1 and tblvote.idPic>" + id + " and tblPic.idChuyenMuc=1 group by tblvote.idPic having count(vote)>2";
        //        sau = DataAccess.ExeSQLGetlong(sql1);
        //        truoc = DataAccess.ExeSQLGetlong(sql2);
                  
        //    //}
        //    ////else
        //    ////{
        //    ////    string sql1 = "Select Top 1  tblPic.idPic from tblPic  where tblPic.idPic in (select tblvote.idPic from tblvote where vote=1 and tblvote.idPic<"+id+" group by tblvote.idPic having count(vote)<2) or idPic NOT IN (Select idPic from tblVote) and idPic<"+id+" order by idPic desc";
        //    ////    string sql2 = "Select Top 1  tblPic.idPic from tblPic  where tblPic.idPic in (select tblvote.idPic from tblvote where vote=1 and tblvote.idPic>" + id + " group by tblvote.idPic having count(vote)<2) or idPic NOT IN (Select idPic from tblVote) and idPic>"+id;

        //    ////    sau = DataAccess.ExeSQLGetlong(sql1);
        //    ////    truoc = DataAccess.ExeSQLGetlong(sql2);
                
        //    ////}
            
        //    DataSet ds = DataAccess.ExeSQLToDataSet(sql);
        //    Page.Title = ds.Tables[0].Rows[0][5].ToString();
        //    string Update_like = "Select Sum(luotLike) from tblPic where idUser =" + ds.Tables[0].Rows[0][1].ToString();
        //    string sql4 = "Update tblTaiKhoan set luotlike =" + DataAccess.ExeSQLGetlong(Update_like) + "where idUser =" + ds.Tables[0].Rows[0][1].ToString();
        //    DataAccess.ExeNonSQL(sql4);
        //    //string sql3 = "Select idPic from tblPic where idUser=" + ds.Tables[0].Rows[0][1].ToString();
        //    //DataSet ds1 = DataAccess.ExeSQLToDataSet(sql3);
        //   // int k = 0;
        //   // int l = 0;
        //    //for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
        //    //{
        //    //    DataTable dt = DataAccess.GetFacebook("http://duocday.com/Detailphoto.aspx?ID=" + ds1.Tables[0].Rows[j][0].ToString());
        //    //    k = k + int.Parse(dt.Rows[0][4].ToString());
        //    //    l = l + int.Parse(dt.Rows[0][3].ToString());
        //    //    dt.Clear();
        //    //}
        //    //string sql4 = "Update tblTaiKhoan set luotlike =" + k + ", luotcommend =" + l + " where idUser=" + ds.Tables[0].Rows[0][1].ToString();
        //    //DataAccess.ExeNonSQL(sql4);
        //    int i = 0;          
        //    foreach (DataListItem dli in dtl.Items)
        //    {
        //        Panel image = (Panel)dli.FindControl("image");
        //        Panel video = (Panel)dli.FindControl("video");
        //        if (ds.Tables[0].Rows[0][4].ToString() == "True")
        //        {
        //            image.Visible = true;
        //        }
        //        else
        //        {
        //            video.Visible = true;
        //        }
        //        DataTable dt = DataAccess.GetFacebook("http://duocday.com/Detailphoto.aspx?ID=" + id);
        //        Label commend = (Label)dli.FindControl("Label2");
        //        Label count_like = (Label)dli.FindControl("Label3");
        //        string sql_like = "Update tblPic set luotLike =" + dt.Rows[0][4].ToString() + ", luotCommend =" + dt.Rows[0][3].ToString() + " where idPic="+id;
        //        DataAccess.ExeNonSQL(sql_like);
        //        string sql_sumlike = "Select luotlike from tblTaiKhoan where idUser =" + ds.Tables[0].Rows[0][1].ToString();
        //        long sumlike = DataAccess.ExeSQLGetlong(sql_sumlike);
        //        count_like.Text = sumlike.ToString();
        //        commend.Text = dt.Rows[0][3].ToString();
        //        TimeSpan diff = DateTime.Now - DateTime.Parse(ds.Tables[0].Rows[i][0].ToString());
        //        String sMsg = "";
        //        if (diff.Days > 0) sMsg = String.Format("{0} ngày", diff.Days);
        //        else if (diff.Hours > 0) sMsg = String.Format("{0} giờ", diff.Hours);
        //        else if (diff.Minutes > 0) sMsg = String.Format("{0} phut", diff.Minutes);
        //        Label name = (Label)dli.FindControl("Label1");
        //        name.Text = sMsg;
        //        Literal truocsau = (Literal)dli.FindControl("Literal1");
        //        if (sau == 0)
        //        {
        //            truocsau.Text = "<div class=\"navButtons\">"
        //                            + "<a class=\"prev\" href=\"Detailphoto.aspx?ID=" + truoc + "\" >Ảnh trước</a></div>";
        //        }
        //        if (truoc == 0)
        //        {
        //            truocsau.Text = "<div class=\"navButtons\">"
        //                            + " <a class=\"next\" href=\"Detailphoto.aspx?ID=" + sau + "\">Ảnh sau</a></div>";
        //        }
        //        if (truoc != 0 && sau != 0)
        //        {
        //            truocsau.Text = "<div class=\"navButtons\">"
        //                            + "<a class=\"prev\" href=\"Detailphoto.aspx?ID=" + truoc + "\" >Ảnh trước</a> <a class=\"next\" href=\"Detailphoto.aspx?ID=" + sau + "\">Ảnh sau</a></div>";
        //        }
        //        Literal vote = (Literal)dli.FindControl("Literal2");
        //        Label Label4 = (Label)dli.FindControl("Label4");
        //        //if (bien_ktra == 0)
        //        //{
        //        //    vote.Text = "<div class=\"vote\">"
        //        //                + "<div class=\"voteDown\">"
        //        //                + "<a class=\"voteButton first\" href=\"#\">"
        //        //                + "<span>chán</span></a>"
        //        //                + "</div>"
        //        //                + "<div class=\"voteUp\">"
        //        //                + "<a class=\"voteButton \" href=\"#\">"
        //        //                + "<span>hay</span></a>"
        //        //                + "</div></div>";
        //        //    Label4.Text = "Giúp duocday duyệt ảnh:";
        //        //}
        //        //else {
        //        //    Label4.Text = "Thích ảnh này ?";
        //        //}
        //            i++;
        //    }
        //}
    }
}