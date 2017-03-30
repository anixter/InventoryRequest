using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace PIR
{
    public partial class pir : System.Web.UI.MasterPage
    {

        public string directory = ConfigurationManager.AppSettings["Directory"].ToString();
        public string uEmail = String.Empty;
        public readonly string db = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        public String strName = String.Empty;
        public activedirectory user = null;

        protected void Page_Init(object sender, EventArgs e)
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

            }

        }


        protected void Page_Load(object sender, EventArgs e)
        {



        }
    }
}