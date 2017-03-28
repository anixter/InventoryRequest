using System;
using System.Text;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Net.Mail;
using System.IO;

namespace PIR
{

    public enum DataType
    {
        Email,
        NTID
    }
    

    [Serializable]
	public class dRequest
	{

        private readonly string db = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        private int _pir_id = 0;
        private String _ntid = String.Empty;
        private String _name = String.Empty;
        private String _email = String.Empty;
        private String _title = String.Empty;
        private String _userdist = String.Empty;
        private String _managerDist = String.Empty;
        private String _status = String.Empty;

        private String _ifrpartsetup = String.Empty;
        private String _salesrep = String.Empty;
        private String _projectname = String.Empty;
        private String _projecttotal = String.Empty;
        private String _inventoryrequesttotal = String.Empty;
        private String _saleslocation = String.Empty;
        private String _customername = String.Empty;
        private String _customernumber = String.Empty;
        private String _firstreleasedate = String.Empty;
        private String _daterequested = String.Empty;
        private String _completiondate = String.Empty;
        private String _customercreditlimit = String.Empty;
        private String _scopeofrequest = String.Empty;
        private String _specsattached = String.Empty;
        private String _copperplacement = String.Empty;
        private String _spaattached = String.Empty;
        private String _sourceofpricing = String.Empty;
        private String _carringdelay = String.Empty;
        private String _explaincarringdelay = String.Empty;

        private String _quotedcubase = String.Empty;
        private String _requestedwhse = String.Empty;
        private String _howtoreplenish = String.Empty;
        private String _attachedcustomerpo = String.Empty;
        private String _explainnopo = String.Empty;
        private String _signedncnr = String.Empty;
        private String _explainnoncnr = String.Empty;
        private String _files = String.Empty;
        private String _typeofcontract = String.Empty;
        private String _contractsetupneeded = String.Empty;

        private String _followupneeded = String.Empty;
        private String _additionalpricing = String.Empty;
        private String _marketingmemo = String.Empty;
        private String _returnable = String.Empty;
        private String _additionalfollowup = String.Empty;
        private String _reelsreversed = String.Empty;
        private String _locationrestriction = String.Empty;
        private String _ponumber = String.Empty;

        private String _riskdollars = String.Empty;
        private String _error = String.Empty;

        private List<dApprover> _app = null;
        private String _rollup = String.Empty;



        public List<dApprover> Approvers
        {
            get { return _app; }
            set { _app = value; }
        }
        public String RollUp
        {
            get { return _rollup; }
            set { _rollup = value; }
        }
        public String Files
        {
            get { return _files; }
            set { _files = value; }
        }
        public int PIRID
        {
            get { return _pir_id; }
            set { _pir_id = value; }
        }
        public String NTID
        {
            get { return _ntid; }
            set { _ntid = value; }
        }
        public String Name 
        { 
           get { return _name; }
            set { _name = value; }
        }
        public String Email 
        { 
            get { return _email; }
            set { _email = value; }
        }
        public String Title 
        { 
            get { return _title; }
            set { _title = value; }
        }
        public String UserDist
        {
            get { return _userdist; }
            set { _userdist = value; }
        }
        public String ManagerDist 
        {
            get { return _managerDist; }
            set { _managerDist = value; }
        }
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public String IFRPartSetup
        {
            get { return _ifrpartsetup; }
            set { _ifrpartsetup = value; }
        }
        public String SalesRep
        {
            get { return _salesrep; }
            set { _salesrep = value; }
        }
        public String ProjectName
        {
            get { return _projectname; }
            set { _projectname = value; }
        }
        public String ProjectTotal
        {
            get { return _projecttotal; }
            set { _projecttotal = value; }
        }
        public String InventoryRequestTotal
        {
            get { return _inventoryrequesttotal; }
            set { _inventoryrequesttotal = value; }
        }
        public String SalesLocation
        {
            get { return _saleslocation; }
            set { _saleslocation = value; }
        }
        public String CustomerName
        {
            get { return _customername; }
            set { _customername = value; }
        }
        public String CustomerNumber
        {
            get { return _customernumber; }
            set { _customernumber = value; }
        }
        public String FirstReleaseDate
        {
            get { return _firstreleasedate; }
            set { _firstreleasedate = value; }
        }
        public String DateRequested
        {
            get { return _daterequested; }
            set { _daterequested = value; }
        }
       
        public String CompletionDate
        {
            get { return _completiondate; }
            set { _completiondate = value; }
        }
        public String CustomerCreditLimit
        {
            get { return _customercreditlimit; }
            set { _customercreditlimit = value; }
        }

        public String ScopeOfRequest
        {
            get { return _scopeofrequest; }
            set { _scopeofrequest = value; }
        }
        public String SpecsAttached
        {
            get { return _specsattached; }
            set { _specsattached = value; }
        }
        public String CopperPlacement
        {
            get { return _copperplacement; }
            set { _copperplacement = value; }
        }

        public String SPAAttached
        {
            get { return _spaattached; }
            set { _spaattached = value; }
        }
        public String SourceOfPricing
        {
            get { return _sourceofpricing; }
            set { _sourceofpricing = value; }
        }
        public String CarringDelay
        {
            get { return _carringdelay; }
            set { _carringdelay = value; }
        }
        public String ExplainCarringDelay
        {
            get { return _explaincarringdelay; }
            set { _explaincarringdelay = value; }
        }
        public String QuotedCUBase
        {
            get { return _quotedcubase; }
            set { _quotedcubase = value; }
        }
        public String RequestedWHSE
        {
            get { return _requestedwhse; }
            set { _requestedwhse = value; }
        }
        public String HowToReplenish
        {
            get { return _howtoreplenish; }
            set { _howtoreplenish = value; }
        }
        public String AttachedCustomerPO
        {
            get { return _attachedcustomerpo; }
            set { _attachedcustomerpo = value; }
        }
        public String ExplainNoPO
        {
            get { return _explainnopo; }
            set { _explainnopo = value; }
        }
        public String SignedNCNR
        {
            get { return _signedncnr; }
            set { _signedncnr = value; }
        }
        public String ExplainNoNCNR
        {
            get { return _explainnoncnr; }
            set { _explainnoncnr = value; }
        }
        public String TypeOfContract
        {
            get { return _typeofcontract; }
            set { _typeofcontract = value; }
        }
        public String ContractSetupNeeded
        {
            get { return _contractsetupneeded; }
            set { _contractsetupneeded = value; }
        }
        public String FollowUpNeeded
        {
            get { return _followupneeded; }
            set { _followupneeded = value; }
        }
        public String AdditionalPricing
        {
            get { return _additionalpricing; }
            set { _additionalpricing = value; }
        }
        public String MarketingMemo
        {
            get { return _marketingmemo; }
            set { _marketingmemo = value; }
        }
        public String Returnable
        {
            get { return _returnable; }
            set { _returnable = value; }
        }
        public String AdditionalFollowup
        {
            get { return _additionalfollowup; }
            set { _additionalfollowup = value; }
        }

        public String ReelsReversed
        {
            get { return _reelsreversed; }
            set { _reelsreversed = value; }
        }
        public String LocationRestriction
        {
            get { return _locationrestriction; }
            set { _locationrestriction = value; }
        }

        public String PONumber
        {
            get { return _ponumber; }
            set { _ponumber = value; }
        }

        public String RiskDollars
        {
            get { return _riskdollars; }
            set { _riskdollars = value; }
        }

        public String Error
        {
            get { return _error; }
            set { _error = value; }
        }



        public void SaveMe()
        {

           

            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(db);
            System.Data.SqlClient.SqlCommand cmd;
            String hldGroup = String.Empty;


            String sGuid = String.Empty;
            String sStatus = String.Empty;

            try
            {

                cn.Open();

                cmd = new System.Data.SqlClient.SqlCommand("cmr_SaveRequest", cn);
                cmd.CommandTimeout = 0;

                cmd.CommandType = CommandType.StoredProcedure;

               

                cmd.Parameters.AddWithValue("@pir_id", this.PIRID);
                cmd.Parameters.AddWithValue("@request_email", this.Email);
                cmd.Parameters.AddWithValue("@IRF_parts_only", this.IFRPartSetup);
                cmd.Parameters.AddWithValue("@sales_rep", this.SalesRep);
                cmd.Parameters.AddWithValue("@project_name", this.ProjectName);
                cmd.Parameters.AddWithValue("@project_total", this.ProjectTotal);
                cmd.Parameters.AddWithValue("@inv_request_total", this.InventoryRequestTotal);
                cmd.Parameters.AddWithValue("@sales_location", this.SalesLocation);
                cmd.Parameters.AddWithValue("@customer_name", this.CustomerName);
                cmd.Parameters.AddWithValue("@customer_number", this.CustomerNumber);
                cmd.Parameters.AddWithValue("@first_release_date", this.FirstReleaseDate);
                cmd.Parameters.AddWithValue("@date_requested", this.DateRequested);
                cmd.Parameters.AddWithValue("@completion_date", this.CompletionDate);
                cmd.Parameters.AddWithValue("@customer_credit_limit", this._customercreditlimit);
                cmd.Parameters.AddWithValue("@scope_of_request", this.ScopeOfRequest);
                cmd.Parameters.AddWithValue("@specs_attached", this.SpecsAttached);
                cmd.Parameters.AddWithValue("@firm_copper", this.CopperPlacement);
                cmd.Parameters.AddWithValue("@vendor_quote_spa_attached", this.SpecsAttached);
                cmd.Parameters.AddWithValue("@source_of_pricing", this.SourceOfPricing);
                cmd.Parameters.AddWithValue("@delayed_inv_provision", this.CarringDelay);
                cmd.Parameters.AddWithValue("@delayed_inv_explain", this.ExplainCarringDelay);
                cmd.Parameters.AddWithValue("@quoted_CU_base", this.QuotedCUBase);
                cmd.Parameters.AddWithValue("@request_whses", this.RequestedWHSE);
                cmd.Parameters.AddWithValue("@how_to_replenish", this.HowToReplenish);
                cmd.Parameters.AddWithValue("@customer_PO_attach", this.AttachedCustomerPO);
                cmd.Parameters.AddWithValue("@PO_explain", this.ExplainNoPO);
                cmd.Parameters.AddWithValue("@signed_NCNR_attach", this.SignedNCNR);
                cmd.Parameters.AddWithValue("@NCNR_explain", this.ExplainNoNCNR);
                cmd.Parameters.AddWithValue("@type_of_contract", this.TypeOfContract);
                cmd.Parameters.AddWithValue("@contract_setup_needed", this.ContractSetupNeeded);
                cmd.Parameters.AddWithValue("@additional_followup", this.AdditionalFollowup);
               // cmd.Parameters.AddWithValue("@general_details", this.ge
                cmd.Parameters.AddWithValue("@marketing_memo", this.MarketingMemo);
                cmd.Parameters.AddWithValue("@returnable_material", this.Returnable);
                cmd.Parameters.AddWithValue("@followup_needed", this.FollowUpNeeded);
                cmd.Parameters.AddWithValue("@reels_reversed", this.ReelsReversed);
                cmd.Parameters.AddWithValue("@location_restricted", this.LocationRestriction);
                cmd.Parameters.AddWithValue("@PO_number", this.PONumber);
                cmd.Parameters.AddWithValue("@risk_dollars", this.RiskDollars);


                if (this.PIRID == 0)
                {
                    this.PIRID = Convert.ToInt32(cmd.ExecuteScalar());
                    BuildApprovers();
                }
                else
                {
                    this.PIRID = Convert.ToInt32(cmd.ExecuteScalar());
                    //SaveApprovers?
                }

                //MoveFiles();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                this.Error = ex.Message;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

        }
        private void MoveFiles()
        {


        }
        public void BuildApprovers()
        {


            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(db);
            System.Data.SqlClient.SqlCommand cmd;
            StringBuilder sb = new StringBuilder();
            dApprover da = null;
            List<dApprover> listDa = new List<dApprover>();
           
            
            try
            {

                cn.Open();

                cmd = new System.Data.SqlClient.SqlCommand("BuildApprovers", cn);
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.StoredProcedure;
                System.Data.SqlClient.SqlDataReader dr;

                cmd.Parameters.AddWithValue("@pir_id", this.PIRID);
                cmd.Parameters.AddWithValue("@reqEmail", this.Email);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    do
                    {
                        da = new dApprover();

                        da.PIRID = dr["pir_id"].ToString();
                        da.GUID = dr["GUID"].ToString();
                        da.ApproveDate = dr["approve_date"].ToString();
                        da.DenyDate = dr["deny_date"].ToString();
                        da.ProcessID = dr["step_id"].ToString();
                        da.StepName = dr["step_name"].ToString();
                        da.StepOrder = dr["step_order"].ToString();

                        sb.Append("<div class=\"row\"><div class=\"col-sm-4\"><b>" + da.StepName + "</b></div><div class=\"col-sm-4\">" + da.StepStatus + "</div><div class=\"col-sm-4\">&nbsp;</div></div>");

                        listDa.Add(da);

                    }
                    while (dr.Read());
                }

                this.Approvers = listDa;
                this.RollUp = sb.ToString(); 
                SaveRollUp();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                this.Error = ex.Message;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

        }
        public void SaveRollUp()
        {


            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(db);
            System.Data.SqlClient.SqlCommand cmd;
            
            
            try
            {

                cn.Open();

                cmd = new System.Data.SqlClient.SqlCommand("aveRollUp", cn);
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pir_id", this.PIRID);
                cmd.Parameters.AddWithValue("@ru", this.RollUp);

                cmd.ExecuteNonQuery();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                this.Error = ex.Message;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

        }

        public void LoadData(String pirID,String GUID)
        {

            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(db);
            System.Data.SqlClient.SqlCommand cmd;
            System.Data.SqlClient.SqlDataReader dr;

            try
            {

                cn.Open();

                cmd = new System.Data.SqlClient.SqlCommand("GetRequest", cn);
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pir_id", pirID);
                cmd.Parameters.AddWithValue("@GUID", GUID);

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (dr.HasRows)
                {
                    dr.Read();

                    this.PIRID = Convert.ToInt32(dr["pir_id"]);
                    this.Email = dr["request_email"].ToString();
                    this.IFRPartSetup = dr["IRF_parts_only"].ToString();
                    this.SalesRep= dr["[sales_rep"].ToString();
                    this.ProjectName= dr["project_name"].ToString();
                    this.ProjectTotal = dr["project_total"].ToString();
                    this.InventoryRequestTotal = dr["inv_request_total"].ToString();
                    this.SalesLocation = dr["sales_location"].ToString();
                    this.CustomerName = dr["customer_name"].ToString();
                    this.CustomerNumber = dr["customer_number"].ToString();
                    this.FirstReleaseDate = dr["first_release_date"].ToString();
                    this.DateRequested = dr["date_requested"].ToString();
                    this.CompletionDate = dr["completion_date"].ToString();
                    this.CustomerCreditLimit = dr["customer_credit_limit"].ToString();
                    this.ScopeOfRequest = dr["scope_of_request"].ToString();
                    this.SpecsAttached = dr["specs_attached"].ToString();
                    this.CopperPlacement = dr["firm_copper"].ToString();
                    this.SPAAttached = dr["vendor_quote_spa_attached"].ToString();
                    this.SourceOfPricing = dr["source_of_pricing"].ToString();
                    this.CarringDelay = dr["delayed_inv_provision"].ToString();
                    this.ExplainCarringDelay = dr["delayed_inv_explain"].ToString();
                    this.QuotedCUBase = dr["quoted_CU_base"].ToString();
                    this.RequestedWHSE = dr["request_whses"].ToString();
                    this.HowToReplenish = dr["how_to_replenish"].ToString();
                    this.ExplainNoPO = dr["customer_PO_attach"].ToString();
                    this.PONumber = dr["PO_explain"].ToString();
                    this.SignedNCNR = dr["signed_NCNR_attach"].ToString();
                    this.ExplainNoNCNR = dr["NCNR_explain"].ToString();
                    this.TypeOfContract = dr["type_of_contract"].ToString();
                    this.ContractSetupNeeded = dr["contract_setup_needed"].ToString();
                    this.AdditionalFollowup = dr["additional_followup"].ToString();
                    //this = dr["general_details"].ToString();
                    this.MarketingMemo = dr["marketing_memo"].ToString();
                    this.Returnable = dr["returnable_material"].ToString();
                    this.FollowUpNeeded = dr["followup_needed"].ToString();
                    this.ReelsReversed = dr["reels_reversed"].ToString();
                    this.LocationRestriction = dr["location_restricted"].ToString();
                    this.PONumber = dr["PO_number"].ToString();
                    this.RiskDollars = dr["risk_dollars"].ToString();
                    this.RollUp = dr["roll_up"].ToString();

                }

                this.Approvers = GetApprovers();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                this.Error = ex.Message;

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }
        private List<String> GetFiles(String pirID)
        {

            List<String> rtn = new List<String>();

            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(db);
            System.Data.SqlClient.SqlCommand cmd;
            System.Data.SqlClient.SqlDataReader dr;
            

            try
            {

                cn.Open();

                cmd = new System.Data.SqlClient.SqlCommand("Select * from tblFiles where pir_id="+pirID, cn);
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.Text;
               
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    do
                    {
                        rtn.Add(dr["file_name"].ToString());

                    } while (dr.Read());
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                this.Error = ex.Message;
                return null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

            return rtn;
        }
	
        private List<dApprover> GetApprovers()
        {

            List<dApprover> rtn = new List<dApprover>();

            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(db);
            System.Data.SqlClient.SqlCommand cmd;
            System.Data.SqlClient.SqlDataReader dr;
            dApprover da = null;

            try
            {

                cn.Open();

                cmd = new System.Data.SqlClient.SqlCommand("GetApprovers", cn);
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pir_id", this.PIRID);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    do
                    {
                        da = new dApprover();

                        da.PIRID = dr["pir_id"].ToString();
                        da.GUID = dr["GUID"].ToString();
                        da.ApproveDate = dr["approve_date"].ToString();
                        da.DenyDate = dr["deny_date"].ToString();
                        da.ProcessID = dr["step_id"].ToString();
                        da.StepName = dr["step_name"].ToString();
                        da.StepOrder = dr["step_order"].ToString();

                        rtn.Add(da);

                    } while (dr.Read());
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                this.Error = ex.Message;
                return null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

            return rtn;
        }
	}
    
    [Serializable]
    public class dApprover
    {


        private String _process_id = String.Empty;
        private String _pir_id = String.Empty;
        private String _guid = String.Empty;
        private String _step_id = String.Empty;
        private String _step_name = String.Empty;
        private String _approve_date = String.Empty;
        private String _deny_date = String.Empty;
        private String _user_email = String.Empty;
        private String _step_order = String.Empty;
        private String _step_status = String.Empty;


        public String GUID
        {
            get { return _guid; }
            set { _guid = value; }
        }
        public String PIRID
        {
            get { return _pir_id; }
            set { _pir_id = value; }
        }
        public String ProcessID
        {
            get { return _process_id; }
            set { _process_id = value; }
        }
        public String StepID
        {
            get { return _step_id; }
            set { _step_id = value; }
        }
        public String StepName
        {
            get { return _step_name; }
            set { _step_name = value; }
        }

        public String ApproveDate
        {
            get { return _approve_date.Replace("1900-01-01 00:00:00", "").Replace("1/1/1900 12:00:00 AM", ""); }
            set { _approve_date = value; }
        }
        public String DenyDate
        {
            get { return _deny_date.Replace("1900-01-01 00:00:00", "").Replace("1/1/1900 12:00:00 AM", ""); }
            set { _deny_date = value; }
        }
        public String UserEmail
        {
            get { return _user_email; }
            set { _user_email = value; }
        }
        public String StepOrder
        {
            get { return _step_order; }
            set { _step_order = value; }
        }
        public String StepStatus
        {
            get {

                if (this.DenyDate != "")
                    return "Denied";
                else if (this.ApproveDate != "")
                    return "Approved";
                else
                    return "Waiting";

            }
            
        }
    }
}