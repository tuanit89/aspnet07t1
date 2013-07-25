using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class profile : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            HttpCookie cookie = Context.Request.Cookies["idUser"];
            if (null == cookie)
            {

                Response.Redirect("Default.aspx");
            }
            else
            {
                string id = Request.QueryString["user"];
                //string cookieVaue = cookie.Value.ToString();
                string Sql = "Select * from tblTaiKhoan where idUser =N'" + id + "'";
                datalist.DataSource = DataAccess.ExeSQLToDataTable(Sql);
                datalist.DataBind();
                string Sql1 = "Select hienFace from tblTaiKhoan where idUser =N'" + id + "'";
                Boolean i = DataAccess.ExeSQLGetboolean(Sql1);
                foreach (DataListItem dli in datalist.Items)
                {
                    HtmlInputCheckBox chk = dli.FindControl("chkhienface") as HtmlInputCheckBox;
                    if (i == true)
                    {
                        chk.Checked = true;
                    }
                }
            }

        }
    }
    protected void btn_click(object sender, EventArgs e)
    {
        string id = Request.QueryString["user"];
        //Boolean i = DataAccess.ExeSQLGetboolean(Sql1);
        foreach (DataListItem dli in datalist.Items)
        {
            int i = 0;
            HtmlInputCheckBox chk = dli.FindControl("chkhienface") as HtmlInputCheckBox;
            if (chk.Checked)
            {
                i = 1;
            }
            TextBox name = (TextBox)dli.FindControl("Name");
            //string nam = name.Text;h
            //string thu = name.Value.ToString();
           // HtmlInputText name = (HtmlInputText)dli.FindControl("Name").ToString(); 
            TextBox Websites = (TextBox)dli.FindControl("Websites");
            TextBox gt = (TextBox)dli.FindControl("gt");
            //string test = Websites.InnerHtml;
            //string nam = name.Value.ToString();
            FileUpload FileUpload1 = (FileUpload)dli.FindControl("avatar");
            string sql ="";
            if (FileUpload1.PostedFile.FileName.ToString() != "") sql = "Update tblTaiKhoan set tenHienThi =N'" + name.Text.ToString() + "',avatar =N'http://duocday.com/avatar/" + getFilePic() + "', website =N'" + Websites.Text.ToString() + "', ghichu =N'" + gt.Text.ToString() + "', hienFace =" + i + " where idUser ="+id;
            else sql = "Update tblTaiKhoan set tenHienThi =N'" + name.Text.ToString() + "', website =N'" + Websites.Text.ToString() + "', ghichu =N'" + gt.Text.ToString() + "', hienFace =" + i + " where idUser =" + id;
            DataAccess.ExeNonSQL(sql);

        }
    }
    public string getFilePic()
    {
       
        string sfile = "";

          foreach (DataListItem dli in datalist.Items)
        {
             
            FileUpload FileUpload1 = (FileUpload)dli.FindControl("avatar");
        if (FileUpload1.HasFile)
        {
            sfile = Guid.NewGuid().ToString().Substring(0, 10) + FileUpload1.PostedFile.FileName.Remove(0, FileUpload1.PostedFile.FileName.LastIndexOf("."));
            FileUpload1.PostedFile.SaveAs(Server.MapPath("avatar/") + sfile);

        }
          }
        return sfile;
    }
}