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
using System.IO;
using System.Net;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
    private string strErrorMessage;
    private int intErrorNumber;
    private string IErrorMsg;
    private int IErrorCode;
    public string ErrorMessage
    {
        get
        {
            return strErrorMessage;
        }
    }
    /// <summary>
    /// int: Số lỗi khi truy cập SQL
    /// </summary>
    public int ErrorNumber
    {
        get
        {
            return intErrorNumber;
        }
    }
    public DataAccess()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    /// <summary>
    ///Thực thi 1 câu lệnh SQL không trả lại giá trị
    /// </summary>
    public static void ExeNonSQL(string strSQL)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandTimeout = 2000;
        SqlConnection cn = Connection.GetConnection();
        cmd.Parameters.Clear();
        cmd.CommandText = strSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            cmd.Connection = cn;
            cn.Open();
            cmd.ExecuteNonQuery();
            //IErrorCode = 0;
            //IErrorMsg = "";
            cn.Close();
        }
        catch (SqlException ex)
        {
            //intErrorNumber = ex.Number;
            //IErrorMsg = ex.Message;
            //System.Console.Write(ex.StackTrace);
        }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        // return IErrorCode.ToString() + ":" + IErrorMsg;

    }

    /// <summary>
    /// Thực thi 1 câu lệnh SQL dạng select có trả về dữ liệu là 1 bảng
    /// </summary>
    /// 
    public static DataTable GetFacebook(string urltxt)
    {

        WebClient web = new WebClient();
        string url = string.Format("https://api.facebook.com/method/fql.query?query=SELECT url, share_count, like_count, comment_count, total_count, click_count FROM link_stat where url='" + urltxt + "'");
        //  string url = string.Format("https://api.facebook.com/restserver.php?method=links.getStats&urls=facebook.com");
        string response = web.DownloadString(url);
        DataSet ds = new DataSet();
        using (StringReader stringReader = new StringReader(response))
        {
            ds = new DataSet();
            ds.ReadXml(stringReader);
        }
        DataTable dt = ds.Tables["link_stat"];
        return dt;
    }
    public static DataTable ExeSQLToDataTable(string strSQL)
    {
        SqlConnection cn = Connection.GetConnection();
        SqlDataAdapter Adapter = new SqlDataAdapter(strSQL, cn);
        DataTable dt = new DataTable();
        try
        {
            Adapter.Fill(dt);
            cn.Close();
        }
        catch (SqlException E)
        {
            string strDescriptionError = E.Message;
        }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return dt;
    }

    /// <summary>
    /// Thực thi 1 câu lệnh SQL dạng select có trả về dữ liệu là DataSet
    /// </summary>
    /// <return>
    /// DataSet
    /// </return>
    public static DataSet ExeSQLToDataSet(string strSQL)
    {
        SqlConnection cn = Connection.GetConnection();
        SqlDataAdapter Adapter = new SqlDataAdapter(strSQL, cn);
        DataSet ds = new DataSet();
        try
        {
            Adapter.Fill(ds);
            cn.Close();
        }
        catch (SqlException E)
        {
            string strDescriptionError = E.Message;
        }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return ds;
    }
    /// <summary>
    /// Thực thi câu lênh sql trả về giá trị lớn nhất
    /// </summary>
    /// 
    public static int ExeSQLGetMax(string strSQL)
    {
        int max = 0;
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        try
        {
            cn.Open();
            cmd.Connection = cn;
            max = Convert.ToInt16(cmd.ExecuteScalar());
            cn.Close();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return max;
    }
    /// <summary>
    /// Thực thi câu lênh sql trả về 1 chuỗi (String)
    /// </summary>
     public static DateTime ExeSQLGetDateTime(string strSQL)
    {
        DateTime data = DateTime.Now;
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand(strSQL, cn);
        SqlDataReader dr;
        try
        {
        cn.Open();
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            data = Convert.ToDateTime(dr.GetSqlDateTime(0));
        }
        cn.Close();
        cmd.Dispose();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
                cn.Dispose();
        }
        return data;
    }
    public static string ExeSQLGetData(string strSQL)
    {
        string data = "";
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand(strSQL, cn);
        SqlDataReader dr;
        try
        {
        cn.Open();
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            data = Convert.ToString(dr.GetSqlString(0));
        }
        cn.Close();
        cmd.Dispose();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
                cn.Dispose();
        }
        return data;
    }
    /// <summary>
    /// Thực thi câu lênh sql trả về giá trị nguyên
    /// </summary>
    public static int ExeSQLGetInt(string strSQL)
    {
        int value= 0;
        SqlConnection cn = Connection.GetConnection();
        try
        {
        cn.Open();
        SqlCommand cmd = new SqlCommand(strSQL, cn);
        value = (int)cmd.ExecuteScalar();
        cn.Close();
        cmd.Dispose();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
                cn.Dispose();
        }
        return value;
    }
    public static long ExeSQLGetlong(string strSQL)
    {
        long value = 0;
        SqlConnection cn = Connection.GetConnection();
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            value = (long)cmd.ExecuteScalar();
            cn.Close();
            cmd.Dispose();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return value;
    }
    public static Boolean ExeSQLGetboolean(string sql)
    {
            bool value = false;
            SqlConnection cn = Connection.GetConnection();
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            value =Convert.ToBoolean(cmd.ExecuteScalar());
            cn.Close();
            cn.Dispose();
            cmd.Dispose();
        
        return value;
    }
    /// <summary>
    /// Thực thi câu lênh sql trả về giá trị kiểu double
    /// </summary>
    public static double ExeSQLGetDouble(string strSQL)
    {
        double value = 0;
        SqlConnection cn = Connection.GetConnection();
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            value = (double)cmd.ExecuteScalar();
            cn.Close();
            cmd.Dispose();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return value;
    }
    /// <summary>
    /// Thực thi câu lênh sql trả về 1 DataReader
    /// </summary>
    public static SqlDataReader ExeSQLGetReader(string strSQL)
    {
        SqlConnection cn = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand(strSQL, cn);
        SqlDataReader dr;

        //try
        //{
            cn.Open();
            dr = cmd.ExecuteReader();
            cn.Close();
            cmd.Dispose();
        //}
        //catch { }
        //finally
        //{
            //if (cn.State == ConnectionState.Open)
                //cn.Close();
                //cn.Dispose();
        //}
        return dr;
    }
    /// <summary>
    /// Thực thi 1 câu lệnh SQL đổ dữ liệu vào DropDownList
    ///</summary>
    public static void ExeSQLToDrop(string strSQL, DropDownList drl)
    {
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand(strSQL,cn);
        SqlDataReader dr;
        try
        {
            cmd.Connection = cn;
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                drl.Items.Add(Convert.ToString(dr.GetString(0)));
            }
            dr.Close();
            cn.Close();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
                cn.Dispose();
        }
    }
    /// <summary>
    ///Các hàm thực thi Stored Procedure
    /// </summary>
    /// <summary>
    /// Thực thi 1 StoreProcedure không trả lại giá trị
    /// </summary>
    public static void ExeNonStored(string StoredName, params object[] pars)
    {
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.CommandText = StoredName;
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < pars.Length; i += 2)
            {
                SqlParameter pa = new SqlParameter(pars[i].ToString(), pars[i + 1]);
                cmd.Parameters.Add(pa);
            }
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
   }
  
    /// <summary>
    /// Thực thi 1 StoreProcedure trả vể dữ liệu dạng bảng
    ///</summary>
    public static DataTable ExeStoredToDataTable(string StoredName, params object[] para)
    {
        DataTable dt = new DataTable();
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        try
        {
        cmd.Connection = cn;
        cn.Open();
        cmd.CommandText = StoredName;
        cmd.CommandType = CommandType.StoredProcedure;
        for (int i = 0; i < para.Length; i += 2)
        {
            SqlParameter pa = new SqlParameter(para[i].ToString(), para[i + 1]);
            cmd.Parameters.Add(pa);
        }
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        da.Fill(dt);
        cn.Close();
        cmd.Dispose();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return dt;
    }
    /// <summary>
    /// Thực thi 1 StoreProcedure trả về 1 DataSet
    ///</summary>
    public static DataSet ExeStoredToDataSet(string StoredName, params object[] para)
    {
        //DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = StoredName;
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < para.Length; i += 2)
            {
                SqlParameter pa = new SqlParameter(para[i].ToString(), para[i + 1]);
                cmd.Parameters.Add(pa);
            }
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            //dt = ds.Tables[0];
            cn.Close();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return ds;
    }
    /// <summary>
    /// Thực thi 1 StoreProcedure trả về dữ liệu là 1 chuỗi (String)
    ///</summary>
    public static string ExeStoredGetData(string StoredName, params object[] para)
    {
        string data = "";
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        try
        {
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = StoredName;
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < para.Length; i += 2)
            {
                SqlParameter pa = new SqlParameter(para[i].ToString(), para[i + 1]);
                cmd.Parameters.Add(pa);
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                data = Convert.ToString(dr.GetString(0));
            }
            dr.Close();
            cn.Close();
        }
         catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return data;
    }
    /// <summary>
    /// Thực thi 1 StoreProcedure trả về dữ liệu là 1 số nguyên
    ///</summary>
    public static int ExeStoredGetInt(string StoredName, params object[] para)
    {
        int data = 0;
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        try
        {
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = StoredName;
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < para.Length; i += 2)
            {
                SqlParameter pa = new SqlParameter(para[i].ToString(), para[i + 1]);
                cmd.Parameters.Add(pa);
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                data = Convert.ToInt16(dr[0]);
            }
            dr.Close();
            cn.Close();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return data;
    }
    /// <summary>
    /// Thực thi 1 StoreProcedure trả về dữ liệu là 1 số nguyên
    ///</summary>
    public static double ExeStoredGetDouble(string StoredName, params object[] para)
    {
        double data = 0;
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        try
        {
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = StoredName;
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < para.Length; i += 2)
            {
                SqlParameter pa = new SqlParameter(para[i].ToString(), para[i + 1]);
                cmd.Parameters.Add(pa);
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                data = Convert.ToDouble(dr[0]);
            }
            dr.Close();
            cn.Close();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return data;
    }
    /// <summary>
    /// Thực thi 1 StoreProcedure đổ dữ liệu vào DropDownList
    ///</summary>
    public static void ExeTtoredToDrop(string StoredName, DropDownList drl, params object[] para)
    {
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        try
        {
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = StoredName;
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < para.Length; i += 2)
            {
                SqlParameter pa = new SqlParameter(para[i].ToString(), para[i + 1]);
                cmd.Parameters.Add(pa);
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                drl.Items.Add(Convert.ToString(dr.GetString(0)));
            }
            dr.Close();
            cn.Close();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
    }
    /// <summary>
    /// Thực thi 1 StoreProcedure trả về số lượng bản ghi
    ///</summary>
    public static int ExeStoredCount(string StoredName, params object[] para)
    {
        int count = 0;
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = StoredName;
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < para.Length; i += 2)
            {
                SqlParameter pa = new SqlParameter(para[i].ToString(), para[i + 1]);
                cmd.Parameters.Add(pa);
            }
            count = (int)cmd.ExecuteScalar();
            cn.Close();
            cmd.Dispose();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Dispose();
        }
        return count;

    }
    /// <summary>
    /// Thực thi 1 StoreProcedure trả về Giá trị lớn nhất
    ///</summary>
    public static int ExeStoredGetMax(string StoredName)
    {
        int max = 0;
        SqlConnection cn = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.CommandText = StoredName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cn.Open();
            max = Convert.ToInt16(cmd.ExecuteScalar());
            cn.Close();
            cmd.Dispose();
        }
        catch { }
        finally
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
                cn.Dispose();
        }
        return max;
    }
    }


