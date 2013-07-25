using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            TimeSpan diff = DateTime.Parse("2013-06-27 23:05:52.000") - DateTime.Parse("2013-06-26 00:05:52.000");
        String sMsg = String.Format("{0} ngày {1} giờ {2} phút {3} giây",diff.Days,diff.Hours,diff.Minutes,diff.Seconds);

       // Label1.Text = sMsg;

        GetYouTubeImage("https://www.youtube.com/watch?v=lv3_7KRVMI4");
        }
    }
    public string GetYouTubeImage(string videoUrl)
    {
        
        int mInd = videoUrl.IndexOf("/v/");
        if (mInd != -1)
        {
            string strVideoCode = videoUrl.Substring(videoUrl.IndexOf("/v/") + 3);
            int ind = strVideoCode.IndexOf("?");
            strVideoCode = strVideoCode.Substring(0, ind == -1 ? strVideoCode.Length : ind);
            return "https://img.youtube.com/vi/" + strVideoCode + "/default.jpg";
        }
        else
            return "";
    }
}