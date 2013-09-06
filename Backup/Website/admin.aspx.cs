using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin : System.Web.UI.Page
{
    int idPic = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            HttpCookie cookie = Context.Request.Cookies["idAdmin"];
            if (null == cookie)
            {

                Response.Redirect("Default.aspx");
            }
            else
            {
            //string quyen = "Select quyen from tblTaiKhoan where idUser="+cookie.Value.ToString();
            //Boolean ktra = DataAccess.ExeSQLGetboolean(quyen);
            //if (ktra == true)
            //{
                string sql = "Select * from tblPic where hienAnh=0";
                GRV.DataSource = DataAccess.ExeSQLToDataTable(sql);
                GRV.DataBind();
            //}
            //else
            //{
            //    Response.Redirect("Default.aspx");
            //}
            }
        }
    }
    protected void GRV_load()
    {
        string sql = "Select * from tblPic where hienAnh=0";
        GRV.DataSource = DataAccess.ExeSQLToDataTable(sql);
        GRV.DataBind();
    }
    protected void btn_click(object sender, EventArgs e)
    {
        string sql = "Update tblPic set hienAnh=1 where idPic="+Session["idPic"].ToString();
        DataAccess.ExeNonSQL(sql);
    }
    protected void GRV_Click(object sender, System.Web.UI.WebControls.CommandEventArgs e)
    {
        //try
        //{

        string st = e.CommandArgument.ToString();
        char[] ch = new char[] { '|' };
        string[] s = st.Split(new char[] { '|' });
        idPic = Convert.ToInt16(s[0]);
        Session.Add("idPic", idPic);
        switch (s[1])
        {
            case "C":

                string sql = "Select * from tblPic where idPic =" + Session["idPic"].ToString();
                string sql1 = "Select dangFile from tblPic where idPic=" + Session["idPic"].ToString();
                Boolean ktra = DataAccess.ExeSQLGetboolean(sql1);
                dtl.DataSource = DataAccess.ExeSQLToDataTable(sql);
                dtl.DataBind();
                foreach (DataListItem dli in dtl.Items)
                {
                    Panel image = (Panel)dli.FindControl("image");
                    Panel video = (Panel)dli.FindControl("video");
                    if (ktra == true)
                    {
                        image.Visible = true;
                    }
                    else
                    {
                        video.Visible = true;
                    }
                }
                GRV_load();
                break;
            case "X":

                string delete = "Delete from tblPic where idPic=" + Session["idPic"].ToString();
                DataAccess.ExeNonSQL(delete);
                GRV_load();
                break;
        }
    }
    //catch
    //{
    //}
    //}
    protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='none'; this.style.backgroundColor='yellow'";
            e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';this.style.backgroundColor='white'";
        }

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GRV.PageIndex = e.NewPageIndex;
        //LoadImage();
    }

}