using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIR
{
    public partial class Queue : System.Web.UI.Page
    {

        private string directory = ConfigurationManager.AppSettings["Directory"].ToString();
        private string uEmail = String.Empty;
        private readonly string db = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        private String strName = String.Empty;
        private activedirectory user = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Security.Principal.WindowsPrincipal p = System.Threading.Thread.CurrentPrincipal as System.Security.Principal.WindowsPrincipal;

            if (p.Identity.Name == String.Empty)
                strName = System.Security.Principal.WindowsIdentity.GetCurrent().Name; // p.Identity.Name;
            else
                strName = p.Identity.Name;

            if (strName != "")
            {
                String x = String.Empty;
                user = new activedirectory(directory, strName, true, DataType.NTID);
                lbUserName.Text = user.dRequest.Name + " (" + user.dRequest.NTID + ")";
            }
            if (!Page.IsPostBack)
            {
                //LoadDLL();

            }
            Page.MaintainScrollPositionOnPostBack = true;
        }
    }
}