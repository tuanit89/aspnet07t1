using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class MasterUser : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    string Id = Request.QueryString["user"];
        //    string sql = "Select * from tblTaiKhoan where idUser ="+Id;
        //    string sql1 = "select Sum(tblPic.luotXem) ,Count(tblPic.idPic) as tonganh from tblTaiKhoan inner join tblPic on tblTaiKhoan.idUser = tblPic.idUser where tblTaiKhoan.idUser = "+Id;
        //    string sql2 = "Select website from tblTaiKhoan where idUser =" + Id;
        //    string sql3 = "Select hienFace from tblTaiKhoan where idUser =" + Id;
        //    string sql4 = "select row_number() over(order by luotlike desc ) as 'STT',idUser from tblTaiKhoan";
        //    DataSet ds1 = DataAccess.ExeSQLToDataSet(sql4);
        //    string ktra = DataAccess.ExeSQLGetData(sql2);
        //    Boolean face = DataAccess.ExeSQLGetboolean(sql3);
        //    DataSet ds = DataAccess.ExeSQLToDataSet(sql1);
        //    dtluser.DataSource = DataAccess.ExeSQLToDataTable(sql);
        //    dtluser.DataBind();
        //    foreach (DataListItem dli in dtluser.Items)
        //    {
        //        Label Countanh = (Label)dli.FindControl("Label1");
        //        Countanh.Text = ds.Tables[0].Rows[0][1].ToString();
        //        Label sumxem = (Label)dli.FindControl("Label2");
        //        sumxem.Text = ds.Tables[0].Rows[0][0].ToString();
        //        Label stt = (Label)dli.FindControl("Label3");
        //        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
        //        {
        //            if (ds1.Tables[0].Rows[i][1].ToString() == Id)
        //            {
        //                stt.Text = ds1.Tables[0].Rows[i][0].ToString();
        //            }
        //        }
        //            if (ktra.Trim() != "Null")
        //            {
        //                Panel Panel1 = (Panel)dli.FindControl("Panel1");
        //                Panel1.Visible = true;
        //            }
        //        if (face == true)
        //        {
        //            Panel Panel2 = (Panel)dli.FindControl("Panel2");
        //            Panel2.Visible = true;
        //        }
        //    }
        //}
    }
}
