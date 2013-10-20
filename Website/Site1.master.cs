using System;
using System.Web;
using System.Text;
using System.Data;

public partial class Site1 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            
            HttpCookie cookie = Context.Request.Cookies["idUser"];

            string cookieVaue;
            string html="";
            if (null == cookie)
            {

                cookieVaue = "";
                html = "<a class=\"loginButton\" href=\"login.aspx\" >Đăng nhập</a>";
                //html = "<asp:LinkButton class=\"loginButton\" ID=\"LinkButton1\" runat=\"server\" onclick=\"Button1_Click\">Đăng nhập</asp:LinkButton>";
            }
                
            else
            {

                cookieVaue = cookie.Value.ToString();
                string sql = "Select iduser,tenHienThi from tblTaiKhoan where idUser =N'" + cookieVaue + "'";
                //dtprofile.DataSource = DataAccess.ExeSQLToDataTable(sql);
                //dtprofile.DataBind();
                DataSet ds = DataAccess.ExeSQLToDataSet(sql);
                html = "<a class=\"profileButton\" href=\"photoupload.aspx?user=" + ds.Tables[0].Rows[0][0].ToString() + "\">" + ds.Tables[0].Rows[0][1].ToString() + " </a>"
                       +"<ul>"
                       + "<li><a href=\"photoupload.aspx?user=" + ds.Tables[0].Rows[0][0].ToString() + "\">Ảnh của bạn</a></li>"
                       + "<li><a href=\"messenger.aspx?user=" + ds.Tables[0].Rows[0][0].ToString() + "\">Thông báo </a></li>"
                       + "<li><a href=\"profile.aspx?user=" + ds.Tables[0].Rows[0][0].ToString() + "\">Thông tin cá nhân</a></li>"
                       + "<li> <a href=\"Thoat.aspx\">Thoát</a></li>"
                       + "</ul>";
            }
            Literal1.Text = html;
            var query = Request.Url.PathAndQuery;
            var str1 = new StringBuilder();
            if (query.StartsWith("/default"))
            {
                str1.Append(" <li class=\"selected\"><a href=\"default.aspx\">Hot</a></li> ");
                Literal3.Text = "<div class=\"tips\"><b>Nơi chia sẻ những tấm ảnh, video, chế hài hước, vui cười nhất Việt Nam và trên cả Thế giới. Khi bạn xem bạn không thể không cười. Bạn hãy cùng chia sẻ với cộng đồng những bức ảnh, video độc nhất, lạ nhất nhé.</b></div>";
            }
            else str1.Append(" <li><a href=\"default.aspx\">Hot</a></li> ");
            if (query.StartsWith("/dep"))
            {
                Literal3.Text = "<div class=\"tips\"><b>Đây là nơi đăng tải tất cả những gì là Đẹp nhất trên thế gian. Từ con người, hành động, cảnh vật, quê hương đất nước hay đến những đồ vật, con vật... Hãy chia sẻ nó miễn sao nó Đẹp bạn nhé.</b></div>";
                str1.Append(" <li class=\"selected\"><a href=\"dep.aspx\">Đẹp ++</a></li> ");
            }
            else str1.Append(" <li><a href=\"dep.aspx\">Đẹp ++</a></li> ");
            if (query.StartsWith("/xastress")) str1.Append(" <li class=\"selected\"><a  href=\"xastress.aspx\">Xả Stress</a></li> ");
            else str1.Append(" <li><a  href=\"xastress.aspx\">Xả Stress</a></li> ");
            if (query.StartsWith("/camxuc")) str1.Append(" <li class=\"selected\"><a href=\"camxuc.aspx\">Cảm xúc</a></li> ");
            else str1.Append(" <li><a href=\"camxuc.aspx\">Cảm xúc</a></li> ");
            if (query.StartsWith("/old")) str1.Append(" <li class=\"selected\"><a href=\"old.aspx\">Cũ</a></li> ");
            if (query.StartsWith("/vote")) str1.Append(" <li class=\"selected\"><a href=\"vote.aspx\">Bình chọn</a></li> ");
            else str1.Append(" <li ><a href=\"vote.aspx\">Bình chọn</a></li> ");
            str1.Append("<li><a href=\"timkiemnc.aspx\" target=\"_blank\">Tìm kiếm nâng cao</a></li> ");
            Literal2.Text = str1.ToString();
            string chuchay = "Select Top 1 noiDung from tblChuChay order by idChu desc";
            Literal4.Text = DataAccess.ExeSQLGetData(chuchay);
        }
    }

    protected void btn_click(object sender, EventArgs e)
    {
        HttpCookie myCookie = new HttpCookie("idFacebook");
        myCookie.Expires = DateTime.Now.AddDays(-1d);
        Context.Response.Cookies.Add(myCookie);
    }
}
