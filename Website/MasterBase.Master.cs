using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class MasterBase : System.Web.UI.MasterPage
    {
        private const string _rightPanel = "~/controls/mainUI/rightPlaceHolder.ascx";
        private const string _userPanel = "~/controls/mainUI/UserPlaceHolder.ascx";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRightPanel();
        }

        void LoadRightPanel()
        {
            string path;
            if (Request.Path.ToLower().IndexOf("account/noti") != -1 || Request.Path.ToLower().IndexOf("uploader") != -1)
            {
                path = _userPanel;
            }
            else
            {
                path = _rightPanel;
            }
            var control = LoadControl(path);
            rightPlaceHolder.Controls.Add(control);
        }
    }
}