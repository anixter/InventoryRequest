using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Web;

namespace PIR
{
	public class activedirectory
	{

        private String _addomain;
        private string _aderror = String.Empty;
        
        private readonly string db = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
        

        
        public dRequest dRequest = null;
        public List<dApprover> dApp = null;


        public String ADDomain
        {
            get { return _addomain; }
            set { _addomain = value; }
        }
        public String ADError
        {
            get { return _aderror; }
            set { _aderror = value; }
        }
        
        
        
        public activedirectory()
        {


        }
        public activedirectory(String ad,String val,Boolean LogUser,DataType dt)
        {
            //private string _addomain = @"LDAP://HSI";            
            dRequest = new dRequest();
            dApp = new List<dApprover>();
            this.ADDomain = ad;

            switch (dt)
            {
                case DataType.Email:
                    GetADData("(&(objectCategory=User)(mail=" + val + "))", LogUser, val);
                break;
                case DataType.NTID:
                    GetADData("(&(objectCategory=User)(mail=" + GetEmailFromAD(val) + "))", LogUser, val);
                break;
            }


            //if (dt == DataType.Email)
                
            //else
                
        

        }
       
        public String GetEmailFromAD(String NTID)
        {

            String rtn = String.Empty;
            String directory = String.Empty;
            String x = String.Empty;

            if (NTID.IndexOf("HSI") > -1)
            {
                directory = @"LDAP://HSI";
            }
            else
            {
                directory = @"LDAP://AXE";
            }

            x = NTID.Substring(NTID.LastIndexOf(@"\") + 1);

            DirectorySearcher ds = null;
            DirectoryEntry de = new DirectoryEntry(directory);
            ds = BuildUserSearcher(de);

            ds.Filter = "(&(objectCategory=User)(samaccountname=" + x + "))";
            SearchResult sr;


            sr = ds.FindOne();

            if (sr != null)
            {
                if (sr.Properties["targetaddress"].Count > 0)
                {
                    if (sr.Properties["targetaddress"][0] != null)
                        rtn = rtnData(sr.Properties["targetaddress"][0]);
                    else if (sr.Properties["mail"].Count > 0)
                        if (sr.Properties["mail"][0] != null)
                            rtn = rtnData(sr.Properties["mail"][0]);
                        else
                            rtn = "";
                    else
                        rtn = "";
                }
                else
                    rtn = "";
            }
            return rtn;


        }
        private DirectorySearcher BuildUserSearcher(DirectoryEntry de)
        {
            DirectorySearcher ds = null;

            ds = new DirectorySearcher(de);

            ds.PropertiesToLoad.Add("name");
            ds.PropertiesToLoad.Add("targetaddress");
            ds.PropertiesToLoad.Add("mail");
            ds.PropertiesToLoad.Add("title");
            ds.PropertiesToLoad.Add("manager");
            ds.PropertiesToLoad.Add("samaccountname");
            ds.PropertiesToLoad.Add("distinguishedname");
            
            return ds;
        }
        public void GetADData(String filter,bool app,String v)
        {
            
         
            DirectorySearcher ds = null;
            DirectoryEntry de = new DirectoryEntry(this.ADDomain);
            
            SearchResult sr;


            try
            {
                ds = BuildUserSearcher(de);
                // Set the filter to look for a specific user
                ds.Filter = filter;
                int DataLevel = 0;

                sr = ds.FindOne();

                if (sr != null)
                {
                    String val = String.Empty;

                    try
                    {
                        if (sr.Properties["samaccountname"][0] != null)
                        {
                            //0
                            dRequest.NTID = rtnData(sr.Properties["samaccountname"][0]);
                            DataLevel++;
                        }
                        else
                            throw new Exception();

                        if (sr.Properties["name"][0] != null)
                        {
                            //1
                            dRequest.Name = rtnData(sr.Properties["name"][0]);
                            DataLevel++;
                        }
                        else
                            throw new Exception();

                        if (sr.Properties["targetaddress"][0] != null)
                        {
                            //2
                            dRequest.Email = rtnData(sr.Properties["targetaddress"][0]);
                            DataLevel++;
                        }
                        else if (sr.Properties["mail"][0] != null)
                        {
                            //2
                            dRequest.Email = rtnData(sr.Properties["mail"][0]);
                            DataLevel++;
                        }
                        else
                            throw new Exception();

                        if (sr.Properties["title"].Count > 0)
                        {
                            //3
                            dRequest.Title = rtnData(sr.Properties["title"][0]);
                            DataLevel++;
                        }
                        else
                            dRequest.Title = "Not provided"; //throw new Exception();

                        if (sr.Properties["manager"][0] != null)
                        {
                            //4
                            dRequest.ManagerDist = rtnData(sr.Properties["manager"][0]);
                            DataLevel++;
                        }
                        else
                            throw new Exception();

                        if (sr.Properties["distinguishedname"][0] != null)
                        {
                            //5
                            dRequest.UserDist = rtnData(sr.Properties["distinguishedname"][0]);
                            DataLevel++;
                        }
                        else
                            throw new Exception();


                    }
                    catch(Exception ex)
                    {
                        //if (ex.Message == "")
                        // {
                            switch (DataLevel)
                            {
                                case 0:
                                    this.ADError = "User is missing <b>samaccountname</b> in Active Directory";
                                    break;
                                case 1:
                                    this.ADError = "User " + dRequest.NTID + " is missing <b>Name</b> in Active Directory";
                                    break;
                                case 2:
                                    this.ADError = "User " + dRequest.NTID + " is missing <b>TargetAddress or mail</b> in Active Directory";
                                    break;
                                case 3:
                                    this.ADError = "User " + dRequest.NTID + " is missing <b>title</b> in Active Directory";
                                    break;
                                case 4:
                                    this.ADError = "User " + dRequest.NTID + " is missing <b>manager</b> in Active Directory";
                                    break;
                                case 5:
                                    this.ADError = "User " + dRequest.NTID + " is missing <b>distinguishedname</b> in Active Directory";
                                    break;

                            }
                        //}
                        //else
                        //    this.ADError = ex.Message;
                    }
                }
                else
                {
                    this.ADError = "<b>" + v + "</b> was not found. This user and their manager needs to exist in the HSI AD";
                }

            }
            catch (DirectoryServicesCOMException ex)
            {
                this.ADError = ex.Message;                
            }
            catch (Exception ex)
            {
                this.ADError = ex.Message;
            }
        }
        /*
        public void BuildApproverStage(String DN)
        {

            DN = rtnData(DN);

            List<String> sup = new List<string>();
            dApprover adp = null;
            String LocalDN = DN;


            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(db);
            System.Data.SqlClient.SqlCommand cmd;
            System.Data.SqlClient.SqlDataReader dr;

            System.Data.DataSet gData = new System.Data.DataSet();

            try
            {

                cn.Open();

                cmd = new System.Data.SqlClient.SqlCommand("Select * from cmr_sup", cn);
                cmd.CommandTimeout = 0;
                cmd.CommandType = System.Data.CommandType.Text;
                   
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    do
                    {
                        sup.Add(dr["sup_email"].ToString());
                    }
                    while(dr.Read());

                    int breakpoint = 5;
                    int i = 0;

                    do
                    {

                        adp = BuildApprovers(LocalDN, i);
                        if (sup.Find(delegate(String a) { return a.ToLower() == adp.Email.ToString().ToLower(); }) == null)
                        {
                            if (DN != LocalDN) // This is to make sure that requester isn't an approver
                            {
                                dApp.Add(adp); 
                            }
                            i++;
                            
                            LocalDN = adp.ManagerDist;
                            if (this.ADError != "")
                            {
                                break;

                            }
                        }
                        else
                            break;
                        

                    }while(i<breakpoint|| LocalDN=="");

                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                this.ADError = ex.Message;
            }
            catch(Exception ex)
            {
                this.ADError = ex.Message;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                cn.Close();
            }

        }

    */

            /*
        private dApprover BuildApprovers(String DN,int step)
        {

            dApprover d = new dApprover();

            System.Collections.DictionaryEntry x;
            DirectorySearcher ds = null;

            

            DirectoryEntry de = new DirectoryEntry(this.ADDomain);
            int DataLevel = 0;
            ds = BuildUserSearcher(de);
                    
            ds.Filter = "(&(objectCategory=User)(distinguishedname=" + DN + "))";
            SearchResult sr;

                   
            sr = ds.FindOne();

            if (sr != null)
            {

                try
                {
                    if (sr.Properties["samaccountname"].Count > 0)
                    {
                        d.NTID = rtnData(sr.Properties["samaccountname"][0]);
                        DataLevel++;
                        }
                        else
                            throw new Exception();

                    if (sr.Properties["name"].Count > 0)
                    {
                        d.Name = rtnData(sr.Properties["name"][0]);
                        DataLevel++;
                    }
                    else
                        throw new Exception();


                    //if (Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["debug"].ToString()))
                    //{
                    //    d.Email = System.Configuration.ConfigurationManager.AppSettings["DistEmail"].ToString();
                    //    DataLevel++;
                    //}
                    //else
                    //{
                        if (sr.Properties["targetaddress"].Count > 0)
                        {
                            d.Email = rtnData(sr.Properties["targetaddress"][0]);
                            DataLevel++;
                        }
                        else if (sr.Properties["mail"].Count > 0)
                        {
                            d.Email = rtnData(sr.Properties["mail"][0]);
                            DataLevel++;
                        }
                        else
                            throw new Exception();

                    //}



                    if (sr.Properties["title"].Count > 0)
                    {
                        d.Title = rtnData(sr.Properties["title"][0]);
                        DataLevel++;
                    }
                    else
                        d.Title = "Not provided"; // throw new Exception();


                    if (sr.Properties["manager"].Count > 0)
                    {
                        d.ManagerDist = rtnData(sr.Properties["manager"][0]);
                        DataLevel++;
                    }
                    else
                    {
                        if (d.Email.ToLower() == System.Configuration.ConfigurationManager.AppSettings["SEOEMail"].ToString()|| Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["debug"].ToString()))
                        {
                            d.ManagerDist = "";
                        }
                        else
                            throw new Exception();
                    }


                    d.Step = step.ToString();

                }
                catch (Exception ex)
                {
                    switch (DataLevel)
                    {
                        case 0:
                            this.ADError = "Manager (" + DN + "}  is missing <b>samaccountname</b> in Active Directory";
                            break;
                        case 1:
                            this.ADError = "Manager (" + d.NTID + "}  is missing <b>Name</b> in Active Directory";
                            break;
                        case 2:
                            this.ADError = "Manager (" + d.NTID + "}  is missing <b>TargetAddress or Email</b> in Active Directory";
                            break;
                        case 3:
                            this.ADError = "Manager (" + d.NTID + "}   is missing <b>title</b> in Active Directory";
                            break;
                        case 4:
                            this.ADError = "Manager (" + d.NTID + "}   is missing <b>manager</b> in Active Directory";
                            break;
                       
                    }

                }
            }
            else
            {
                this.ADError = "Approver (" + DN + ") is missing from Active Directory";
                
            }


            return d;
        }
    */
        private String rtnData(object value)
        {
            String rtn = String.Empty;
            System.Text.Encoding enc = System.Text.Encoding.ASCII;

            //object value = ((ResultPropertyValueCollection)p.Value)[0];
            if (value is System.Byte[])
                rtn = enc.GetString((byte[])value);
            else
                rtn = value.ToString();

            rtn = rtn.Replace("SMTP:", "");

            return rtn;

        }

	}
}