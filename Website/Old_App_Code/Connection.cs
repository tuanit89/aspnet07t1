using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;


/// <summary>
/// Summary description for Connection
/// </summary>
public class Connection
{
	public Connection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static SqlConnection GetConnection()
    {
        string str = ConfigurationManager.ConnectionStrings["strDuocDay"].ConnectionString;
        SqlConnection cn = new SqlConnection(str);
        if (cn.State == ConnectionState.Open)
        {
            cn.Close();
            cn.Dispose();
        }
        return cn;
    }
}
