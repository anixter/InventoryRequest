using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Text;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PIR
{
    public partial class PIRform : System.Web.UI.Page
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
                lbUserName.Text = user.dRequest.Name + " ("+ user.dRequest.NTID + ")";
            }
            if (!Page.IsPostBack)
            {
                //LoadDLL();

            }

            CleanFiles();

            Page.MaintainScrollPositionOnPostBack = true;


        }
        private void CleanFiles()
        {

            String sDir = Server.MapPath("storage");


            foreach (String d in Directory.GetDirectories(sDir))
            {
                foreach (String fName in Directory.GetFiles(sDir))
                {

                    TimeSpan ts = File.GetCreationTime(fName) - DateTime.Now;
                    //If files are less then 2.4 hours then remove them
                    if (ts.TotalDays < .7)
                    {
                        File.Delete(fName);
                    }
                }
            }
        }

        private void UploadFiles(dRequest nu)
        {

            Boolean rtn = false;

            SqlConnection cn = new System.Data.SqlClient.SqlConnection(db);
            SqlCommand cmd;
            String filename = String.Empty;
            String sDir = String.Empty;
            try
            {
                cn.Open();

                sDir = Server.MapPath("Storage") + @"\" + nu.PIRID + @"\";


                if (Directory.Exists(sDir) == false)
                {
                    Directory.CreateDirectory(sDir);
                }
                else
                {
                    foreach (String f in Directory.GetFiles(sDir))
                    {
                        File.Delete(f);
                    }
                }

                String[] ar = hdFiles.Value.ToString().Split(',');

                foreach (String x in ar)
                {

                    File.Move(Path.Combine(Server.MapPath("Storage"), x), Path.Combine(sDir, x));

                }



                rtn = true;
            }
            catch (SqlException ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Error", "$('#ErrorBody').html(\"" + HttpUtility.HtmlEncode(ex.Message).Replace("\r\n", "") + "\");$('#bsModalError').modal('show');", true);
            }
            catch (IOException ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Error", "$('#ErrorBody').html(\"" + HttpUtility.HtmlEncode(ex.Message).Replace("\r\n", "") + "\");$('#bsModalError').modal('show');", true);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

            //return rtn;

        }
        protected void btnlkUpload_Click(object sender, EventArgs e)
        {

            String sFN = String.Empty;
            String sExt = String.Empty;
            String FileLocation = String.Empty;
            String CurrentFile = String.Empty;
            String sFile = String.Empty;
            String[] goodExt = ConfigurationManager.AppSettings["DocTypes"].ToString().Split(',');

            StringBuilder sb = new StringBuilder();

            if (fu.HasFile)
            {

                if (fu.PostedFile.ContentLength < 220000)
                {
                    String tStr = fu.FileName;

                    sFN = tStr.Substring(0, tStr.LastIndexOf("."));
                    sExt = tStr.Substring(tStr.LastIndexOf("."));


                    if (goodExt.Contains(sExt.ToLower()))
                    {

                        tStr = sFN; //+ "_" + System.DateTime.Now.ToString("MMddyyyyHHmmss") + "T" + System.DateTime.Now.Millisecond.ToString() + sExt;

                        sFile = sFN + sExt;

                        CurrentFile = Server.MapPath("storage") + @"\" + sFile;

                        fu.SaveAs(CurrentFile);


                        if (hdFiles.Value == "")
                            hdFiles.Value = sFile;
                        else
                        {
                            if (hdFiles.Value.ToString().IndexOf(sFile) < 0)
                                hdFiles.Value = hdFiles.Value + "," + sFile;
                        }

                        String[] ar = hdFiles.Value.ToString().Split(',');
                        int c = 0;
                        foreach (String x in ar)
                        {
                            sb.Append("<div class=\"file-name\" id=\"f" + c.ToString() + "\" >" + x + "&nbsp;<a href=\"#\" class=\"delete-file\" onclick=\"DeleteMe('f" + c.ToString() + "','" + x + "');return false;\">X</a></div>");
                            c++;
                        }
                        litFiles.Text = sb.ToString();

                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "FileError", "$('#ErrorBody').html(\"The document type you are trying to upload is not allowed.\");$('#bsModalError').modal('show');", true);
                    }

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "FileError", "$('#ErrorBody').html(\"The file you are trying to upload is too big.  Please make sure it's size is below 200KB\");$('#bsModalError').modal('show');", true);
                }
            }
        }


    }
}