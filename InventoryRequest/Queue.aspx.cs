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

        public String strName = String.Empty;
        public String db = String.Empty;
        activedirectory u = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            //activedirectory u = (MasterPage)this.Master.FindControl(us);
            activedirectory u = ((pir)this.Master).user;

            db = ((pir)this.Master).db;
            lbUserName.Text = u.dRequest.Name + " (" + u.dRequest.NTID + ")";


            if (ViewState["SortDir"] == null)
                ViewState["SortDir"] = "DESC";
            if (ViewState["SortField"] == null)
                ViewState["SortField"] = "create_date";


            Page.MaintainScrollPositionOnPostBack = true;
        }
    }
}