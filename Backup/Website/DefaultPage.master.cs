using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    string sql2 = "Select Top 10 * from tblTaiKhoan order by luotlike desc";
        //    topDH.DataSource = DataAccess.ExeSQLToDataTable(sql2);
        //    topDH.DataBind();
        //}
    }
}
