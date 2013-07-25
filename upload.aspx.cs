using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

public partial class uploadanh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            HttpCookie cookie = Context.Request.Cookies["idUser"];

            string cookieVaue;
            if (null == cookie)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                load_drp(DropDownList1);
                load_drp(DropDownList2);
            }
        }
    }
    protected void btnanh_click(object sender, EventArgs e)
    {
        HttpCookie cookie = Context.Request.Cookies["idUser"];
        string cookieVaue=cookie.Value.ToString();
        bool ktra=false;
        bool ktra1 = false;
        bool ktra2 = false;
        bool ktra3 = false;
        int i = 0;
        string nguon = "";
        string link = "";

        if (txtddanh.Text.Trim() == "")
        {
            if (getFilePic() != "")
            {
                link = "http://duocday.com/anh/" + getFilePic();
            }
        }
        else link = txtddanh.Text.Trim();

        if (chknguonanh.Checked) nguon = "Tự làm";
        else nguon = nguonanh.Value.ToString();
        if (nguon != "" && nguon.Count() < 100)
        {
            ktra = true;
            
        }
        else thbaonguonanh.Text = "Nguồn của ảnh không được để trống và dài quá 100 kí tự";
        if (link != "")
        {
            
            ktra1 = true;
        }
        else thbaofile.Text = "Không được để trống file ảnh";
        if (txttieudeanh.Text.Trim().Count() > 0 && txttieudeanh.Text.Trim().Count() < 100)
        { 
            ktra2 = true;

        }
        else thbaotdeanh.Text = "Tiêu đề ảnh không được để trống và dài quá 100 kí tự";
        if (DropDownList1.SelectedItem.Text != "---Chọn danh mục---")
        {
            ktra3 = true;
        }
        else thbaomuc.Text = "Phải chọn chuyên mục ảnh";
        
        if (ktra == true && ktra1 == true && ktra2== true && ktra3 == true  )
        {
            string sql = "Insert tblPic values(" + cookieVaue + ",N'NULL',N'" + link + "',N'" + txttieudeanh.Text.Trim() + "',N'" + nguon + "',N'" + DropDownList1.SelectedItem.Value + "',1,0,N'" + DateTime.Now + "'," + i + ",0,0,0)";
            DataAccess.ExeNonSQL(sql);
            thongbao.Text = "Bạn đã cập nhât thành công 1 bức ảnh, bạn hãy chờ bức ảnh được admin kiểm duyệt nhé. Cảm ơn bạn đã xây dựng nội dunng!!!";
            thongbao.ForeColor = Color.Blue;
        }
        else
        {
            thongbao.Text = "Có lỗi xảy ra hãy xem lại những lỗi ở bên dưới và cập nhật lại bạn nhé";
            thongbao.ForeColor = Color.Red;
        }

       
    }
    protected void btvideo_click(object sender, EventArgs e)
    {
        HttpCookie cookie = Context.Request.Cookies["idUser"];
        string cookieVaue = cookie.Value.ToString();
        string imgLink = "http://img.youtube.com/vi/";
        string videolink = "";
        string[] temp = ddvideo.Value.ToString().Split(new char[] { '=' });
        if (ddvideo.Value.ToString().Trim() != "")
        {
            imgLink = imgLink + temp[1] + "/0.jpg";
            videolink = "http://www.youtube.com/embed/" + temp[1];
        }
        
        bool ktra = false;
        bool ktra1 = false;
        bool ktra2 = false;
        if (videolink != "")
        {

            ktra = true;
        }
        else thbaolink.Text = "Không được để trống đường dẫn video";
        if (tdevideo.Value.Trim().Count() > 0 && tdevideo.Value.Trim().Count() < 100)
        {
            ktra2 = true;

        }
        else thbaotdevdeo.Text = "Tiêu đề video không được để trống và dài quá 100 kí tự";
        if (DropDownList2.SelectedItem.Text != "---Chọn danh mục---")
        {
            ktra1 = true;
        }
        else thbaomucvdeo.Text = "Phải chọn chuyên mục video";
        if (ktra == true && ktra1 == true && ktra2 == true)
        {
            string sql = "Insert tblPic(idUser,urlVideo,url,tieuDe,nguonPic,idChuyenMuc,dangFile,hienAnh,ngayDang,luotXem,hien18,luotLike,luotCommend) values(" + cookieVaue + ",N'" + videolink + "',N'" + imgLink + "',N'" + tdevideo.Value.ToString() + "',N'youtube.com',N'" + DropDownList2.SelectedItem.Value + "',0,0,N'" + DateTime.Now + "',0,0,0,0)";
            DataAccess.ExeNonSQL(sql);
            thongbao.Text = "Bạn đã cập nhât thành công 1 video, bạn hãy chờ video được admin kiểm duyệt nhé. Cảm ơn bạn đã xây dựng nội dunng!!!";
            thongbao.ForeColor = Color.Blue;
        }
        else
        {
            thongbao.Text = "Có lỗi xảy ra hãy xem lại những lỗi ở bên dưới và cập nhật lại bạn nhé";
            thongbao.ForeColor = Color.Red;
        }

    }
    public void load_drp(DropDownList drp)
    {
        //try
        //{
        int i = 0;
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        cn.Open();

        drp.Items.Clear();
        drp.Items.Add("---Chọn danh mục---");
        string str_combo = "SELECT * from tblChuyenMuc";
        DataSet DS = DataAccess.ExeSQLToDataSet(str_combo);
        DropDownList1.DataSource = DS.Tables[0];
        for (i = 0; i < DS.Tables[0].Rows.Count; i++)
        {
            ListItem lst = new ListItem();
            lst.Text = DS.Tables[0].Rows[i][1].ToString();
            lst.Value = DS.Tables[0].Rows[i][0].ToString();
            drp.Items.Add(lst);
            
        }
        cn.Close();
        //}
        //catch { }
        //finally
        //{

        //}
    }
    public string getFilePic()
    {

        string sfile = "";

           
            if (FileUpload1.HasFile)
            {
                sfile = Guid.NewGuid().ToString().Substring(0, 10) + FileUpload1.PostedFile.FileName.Remove(0, FileUpload1.PostedFile.FileName.LastIndexOf("."));
                FileUpload1.PostedFile.SaveAs(Server.MapPath("anh/") + sfile);

            }
        return sfile;
    }
}