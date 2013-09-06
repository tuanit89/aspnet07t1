using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class vote : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Page.Title = "Bình chọn ảnh để mọi người cùng cười với bạn";
            string sql = "Select  tblPic.ngayDang,tblTaiKhoan.idUser,tblTaiKhoan.tenHienThi,tblPic.idPic,tblPic.dangFile,tblPic.tieuDe,tblPic.url,tblPic.luotxem from tblPic inner join tblTaiKhoan on tblTaiKhoan.idUser = tblPic.idUser   where tblPic.idPic in (select tblvote.idPic from tblvote where vote=1 group by tblvote.idPic having count(vote)<2) or idPic NOT IN (Select idPic from tblVote) order by idPic desc";
            //dtlphoto.DataSource = DataAccess.ExeSQLToDataTable(sql);
            //dtlphoto.DataBind();
            string sql1 = "Select ngayDang,idPic from tblPic where hienAnh=1";
            //DataSet ds = DataAccess.ExeSQLToDataSet(sql);
            //int i = 0;

            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    foreach (DataListItem dli in dtlphoto.Items)
            //    {
            //        DataTable dt = DataAccess.GetFacebook("http://duocday.com/Detailvote.aspx?ID=" + ds.Tables[0].Rows[i][3].ToString());
                    
            //        Label commend = (Label)dli.FindControl("Label2");
            //        commend.Text = dt.Rows[0][3].ToString();
            //        TimeSpan diff = DateTime.Now - DateTime.Parse(ds.Tables[0].Rows[i][0].ToString());
            //        String sMsg = "";
            //        if (diff.Days > 0) sMsg = String.Format("{0} ngày", diff.Days);
            //        else if (diff.Hours > 0) sMsg = String.Format("{0} giờ", diff.Hours);
            //        else if (diff.Minutes > 0) sMsg = String.Format("{0} phut", diff.Minutes);
            //        Label name = (Label)dli.FindControl("Label1");
            //        name.Text = sMsg;
            //        Literal Literal1 = (Literal)dli.FindControl("Literal1");
            //        if (ds.Tables[0].Rows[i][4].ToString() == "False")
            //        {
            //            Literal1.Text = "<img class=\"videoIndicator\" src=\"images/play_icon.png\"></img>";
            //        }
            //        i++;
            //    }
            //}
        }
    }
}