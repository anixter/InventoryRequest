<%@ Page Title="" Language="C#" MasterPageFile="~/pir.Master" AutoEventWireup="true" CodeBehind="PIRform.aspx.cs" Inherits="PIR.PIRform" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="topper">
      <div class="container">
        <p class="pull-left"><span class="glyphicon glyphicon-user"></span>Welcome, <asp:Label ID="lbUserName" runat="server" Text=""></asp:Label></p>
        <p class="pull-right"><a href="queue.aspx">View Your Request Queue</a></p>
      </div>
    </div><!--topper-->

    <header>
      <div class="container center-on-mobile">
        <a id="logo" href=""><img src="images/logo.png" alt="Anixter" title="Anixter" /></a>
        <span class="headline"><p><strong>PIR</strong><br />Project Inventory Request</p></span>
      </div>
    </header><!--header-->

    <div class="container white">

      <div id="intro">
        <p>All items purchased on this request are subject to location/regional exposure.  After 90 days of inactivity material may be written down against sales location. If a request requires an NCNR (not stocked or non standard) but the customer won't sign one, the next level up of sales approval will be required.IRFs for PART SETUP ONLY, only require spec sheets and reason for set up.  Additional IRF will be required to purchase items if need arises.</p>
        <p><span class="warning">*</span> Denotes Required Field</p>
      </div><!--intro-->
    </div><!--container-->

    <div class="container form-tabs">
        <ul class="nav nav-tabs" role="tablist">
          <li role="presentation" class="active"><a href="#sales-team" aria-controls="sales-team" role="tab" data-toggle="tab">Sales Team Information</a></li>
          <li role="presentation" id="pm-team-control"><a href="#pm-team" aria-controls="pm-team" role="tab" data-toggle="tab">Project Management Team</a></li>
          <li role="presentation" id="im-team-control"><a href="#im-team" aria-controls="im-team" role="tab" data-toggle="tab">Inventory Management Team</a></li>
        </ul><!--tabs-->
    </div><!--tabs container-->

    <div class="container fields-container white">
        <div class="tab-content">
          <div role="tabpanel" class="tab-pane active" id="sales-team">
            <br />
            <p class="warning">NOTE: ANY MISSING INFORMATION WILL RESULT IN DELAYS</p>

           
              <div class="col-md-6">
                <div class="form-group">
                  <label " class="col-sm-6 control-label">IRF For Part Setup Only</label>
                  <div class="col-sm-6">

                      <asp:DropDownList class="form-control" ID="ddlpartsetup" runat="server">
                          <asp:ListItem Text="- SELECT ONE - " Value=""></asp:ListItem>
                          <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                          <asp:ListItem Text="No" Value="No"></asp:ListItem>
                      </asp:DropDownList>
                     
                  </div>
                </div>

                <div class="form-group">
                  <label for="inside-sales-rep" class="col-sm-6 control-label">Inside Sales Rep Name</label>
                  <div class="col-sm-6">
                      <asp:TextBox class="form-control" ID="txtInsideSalesRep" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

                <div class="form-group">
                  <label for="project-name" class="col-sm-6 control-label">Project Name</label>
                  <div class="col-sm-6">
                      <asp:TextBox class="form-control" ID="txtProjectName" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

                <div class="form-group">
                  <label for="project-total" class="col-sm-6 control-label">Project Total ($)</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" ID="txtprojecttotal" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

                <div class="form-group">
                  <label for="inventory-request-total" class="col-sm-6 control-label">Inventory Request Total ($)</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" ID="txtinventoryrequesttotal" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

                <div class="form-group">
                  <label for="sales-location" class="col-sm-6 control-label">Sales Location</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" id="txtsaleslocation" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>
              </div><!--right side-->

              <div class="col-md-6">
                <div class="form-group">
                  <label for="customer-name" class="col-sm-6 control-label">Customer Name</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" ID="txtcustomername" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

                <div class="form-group">
                  <label for="customer-number" class="col-sm-6 control-label">Customer Number</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" ID="txtrcustomernumber" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

                <div class="form-group">
                  <label for="first-release-date" class="col-sm-6 control-label">First Release Date</label>
                  <div class="col-sm-6">
                     <div class="input-group">
                      <div class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></div>
                      <asp:TextBox class="form-control" ID="txtfirstreleasedate" placeholder="MM/DD/YYYY" required="true" runat="server"></asp:TextBox>
                    </div>
                  </div>
                </div>

                <div class="form-group">
                  <label for="date-requested" class="col-sm-6 control-label">Date Requested</label>
                  <div class="col-sm-6">
                    <div class="input-group">
                      <div class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></div>
                      <asp:TextBox class="form-control" ID="txtdaterequested" placeholder="MM/DD/YYYY" required="true" runat="server"></asp:TextBox>
                    </div>
                  </div>
                </div>

                <div class="form-group">
                  <label for="completion-date" class="col-sm-6 control-label">Completion Date</label>
                  <div class="col-sm-6">
                    <div class="input-group">
                      <div class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></div>
                      <asp:TextBox class="form-control" ID="txtcompletiondate" placeholder="MM/DD/YYYY" required="true" runat="server"></asp:TextBox>
                    </div>
                  </div>
                </div>

                <div class="form-group">
                  <label for="customer-credit-limit" class="col-sm-6 control-label">Customer Credit Limit</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" ID="txtcustomercreditlimit" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>
              </div><!--left side-->

              <div class="clearfix"></div>

              <div class="col-md-12">
                <div class="form-group">
                  <label for="scope-of-request" class="col-sm-3 control-label">Scope Of Request</label>
                  <div class="col-sm-9">
                    <asp:TextBox placeholder="Enter your Scope of Request" class="form-control" TextMode="MultiLine" ID="txtscopeofrequest" rows="5" runat="server"></asp:TextBox>
                  </div>
                </div>
              </div><!--full width text area-->

              <div class="clearfix"></div>

              <hr />

              <div class="col-md-6">

                 <div class="form-group">
                  <label class="col-sm-6 control-label">Specs Attached For New Parts</label>
                  <div class="col-sm-6">
                    <asp:DropDownList class="form-control" id="ddlspecsattached" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                  </div>
                </div>

                 <div class="form-group">
                  <label class="col-sm-6 control-label">Firm Copper At Placement</label>
                  <div class="col-sm-6">
                    <asp:DropDownList class="form-control" id="ddlfirmcopperplacement" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                  </div>
                </div>

                 <div class="form-group">
                  <label class="col-sm-6 control-label">Vendor Quote Or SPA Attached</label>
                  <div class="col-sm-6">
                    <asp:DropDownList class="form-control" id="ddlattachedvendorquote" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                  </div>
                </div>

                 <div class="form-group">
                  <label for="provide-source-of-pricing" class="col-sm-6 control-label">If Not, Provide Source Of Pricing</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" id="txtprovidesourceofpricing" placeholder="" runat="server"></asp:TextBox>
                    
                  </div>
                </div>

                 <div class="form-group">
                  <label  class="col-sm-6 control-label">Inv Carrying Provision If Delayed</label>
                  <div class="col-sm-6">
                    <asp:DropDownList class="form-control" id="ddlcarringdelay" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                     
                  </div>
                </div>

                 <div class="form-group">
                  <label  class="col-sm-6 control-label">If Not, Explain</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" id="txtexplaincarryingdelay" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

                 <div class="form-group">
                  <label  class="col-sm-6 control-label">Quoted CU Base</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" id="txtquotedcubase" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

              </div><!--left side-->

              <div class="col-md-6">

                 <div class="form-group">
                  <label  class="col-sm-6 control-label">Requested Warehouse(s)</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" ID="txtrequestedwarehouse" placeholder="" runat="server"></asp:TextBox>
                    
                  </div>
                </div>

                 <div class="form-group">
                  <label for="how-to-replenish" class="col-sm-6 control-label">How To Replenish</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" ID="txthowtoreplenish" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

                 <div class="form-group">
                  <label  class="col-sm-6 control-label">Attached Customer PO</label>
                  <div class="col-sm-6">

                    <asp:DropDownList class="form-control" id="ddlattachedcustomerpo" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                     
                  </div>
                </div>

                 <div class="form-group">
                  <label  class="col-sm-6 control-label">If Not, Explain Why</label>
                  <div class="col-sm-6">
                    
                    <asp:TextBox ID="txtexplainwhynopo" class="form-control"  placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

                 <div class="form-group">
                  <label class="col-sm-6 control-label">Signed NCNR Attached</label>
                  <div class="col-sm-6">
                     <asp:DropDownList class="form-control" id="ddlsignedncnr" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                     
                  </div>
                </div>

                 <div class="form-group">
                  <label  class="col-sm-6 control-label">If Not, Explain Why</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" ID="txtexplainnoncnr" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>

                 <div class="form-group">
                  <label  class="col-sm-6 control-label">Upload Part Numbers (XLS or CSV). <p class="help-block">Please upload any files before submitting your request.</p></label>
                  <div class="col-sm-6">

                    <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                        <Triggers>
                            <asp:PostBackTrigger  ControlID="btnlkUpload"  /> 
                        </Triggers>
                        <ContentTemplate>

                            <asp:HiddenField ID="hdFiles" runat="server" />
                           
                            
                            <div class="input-group file-upload">    
                                <asp:FileUpload ID="fu" CssClass="file-upload form-control" placeholder="Please Choose a file." runat="server" />                                         
                            </div>
                            <div >
                                <asp:LinkButton ID="btnlkUpload" CssClass="btn btn-primary form-control" runat="server" OnClick="btnlkUpload_Click"><span aria-hidden="true" class="glyphicon glyphicon-cloud-upload"></span> Upload File</asp:LinkButton>
                            </div>                                  
                            <p class="form-group">
                                <asp:Literal ID="litFiles" runat="server"></asp:Literal>
                            </p>
                        </ContentTemplate>
                    </asp:UpdatePanel>
           
                  </div>
                </div>

              </div><!--right side-->

              <div class="clearfix"></div>

              <br />
              <div class="col-md-12">
                <div class="pull-right">
                  <button type="submit" class="btn btn-primary mobile-button"><span class="glyphicon glyphicon-thumbs-up"></span> Submit</button>

                </div>
              </div><!--BUTTONS-->

            
          </div><!--sales team-->

          <div role="tabpanel" class="tab-pane" id="pm-team">
            <br />
            <p class="warning">NOTE: ANY MISSING INFORMATION WILL RESULT IN DELAYS</p>

            <div class="col-md-4 col-sm-12">
              <div class="form-group">
                  <label class="col-sm-6 control-label">Type Of Contract</label>
                  <div class="col-sm-6">
                    <asp:TextBox class="form-control" id="txttypeofcontract" placeholder="" runat="server"></asp:TextBox>
                  </div>
                </div>
            </div>

            <div class="col-md-4 col-sm-12">
              <div class="form-group">
                  <label  class="col-sm-6 control-label">Contract Setup Needed</label>
                  <div class="col-sm-6">
                    <asp:DropDownList class="form-control" id="ddlcontractsetupneeded" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                    
                  </div>
                </div>
            </div>

            <div class="col-md-4 col-sm-12">
              <div class="form-group">
                  <label  class="col-sm-6 control-label">Additional Followup Needed?</label>
                  <div class="col-sm-6">
                    <asp:DropDownList class="form-control" id="ddlfollowupneeded" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                    
                  </div>
                </div>
            </div>

            <div class="clearfix"></div>

             <div class="col-md-12">
              <div class="form-group">
                <label  class="col-sm-6 control-label">Additional Pricing/General Details</label>
                <div class="clearfix"></div>
                <div class="col-md-12">
                    <asp:TextBox TextMode="MultiLine" class="form-control" id="txtadditionalpricing" rows="5" placeholder="Enter your Additional Pricing/General Details" runat="server"></asp:TextBox>
                </div>
              </div>
            </div>

            <div class="col-md-12">
              <div class="form-group">
                <label  class="col-sm-6 control-label">Marketing Memo</label>
                <div class="clearfix"></div>
                <div class="col-md-12">
                    <asp:TextBox TextMode="MultiLine" class="form-control" rows="5" ID="txtmarketingmemo" placeholder="Enter Your Marketing Memo" runat="server"></asp:TextBox>
                </div>
              </div>
            </div>

            <div class="col-md-12">
              <div class="pull-right button-adj">
                  <button type="submit" class="btn btn-primary mobile-button"><span class="glyphicon glyphicon-thumbs-up"></span> Submit</button>
              </div>
            </div><!--BUTTONS-->
          </div><!--pm team-->

          <div role="tabpanel" class="tab-pane" id="im-team">
            <br />
            <p class="warning">NOTE: ANY MISSING INFORMATION WILL RESULT IN DELAYS</p>

            <div class="col-md-4 col-sm-12">
              <div class="form-group">
                  <label class="col-sm-6 control-label">Is Material Returnable To Vendor On The Annual Stock Rotation</label>
                  <div class="col-sm-6">
                     <asp:DropDownList class="form-control" id="ddlismaterialreturnable" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>

                    
                  </div>
                </div>
            </div>

            <div class="col-md-4 col-sm-12">
              <div class="form-group">
                  <label for="additional-followup" class="col-sm-6 control-label">Additional Followup Needed</label>
                  <div class="col-sm-6">
                    <asp:DropDownList class="form-control" id="ddladditionalfollowup" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                    
                  </div>
                </div>
            </div>

            <div class="clearfix"></div>

            <div class="col-md-4 col-sm-12">
              <div class="form-group">
                  <label  class="col-sm-6 control-label">Reels Need To Be Reversed</label>
                  <div class="col-sm-6">
                    <asp:DropDownList class="form-control" id="ddlreelsreversed" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                    
                  </div>
                </div>
            </div>

            <div class="col-md-4 col-sm-12">
              <div class="form-group">
                  <label class="col-sm-6 control-label">Location To Be Restricted</label>
                  <div class="col-sm-6">
                     <asp:DropDownList class="form-control" id="ddllocationrestricted" runat="server">
                        <asp:ListItem Text="- SELECT ONE -" Value=""></asp:ListItem>
                        <asp:ListItem Text="YES" Value="YES"></asp:ListItem>
                        <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                    </asp:DropDownList>
                  </div>
                </div>
            </div>

            <div class="col-md-4 col-sm-12">
               <div class="form-group">
                <label class="col-sm-6 control-label">PO Number</label>
                <div class="col-sm-6">
                    <asp:TextBox class="form-control" id="txtponumber" placeholder="" runat="server"></asp:TextBox>
                </div>
              </div>
            </div>

            <div class="clearfix"></div>

             <div class="col-md-12">
              <div class="form-group">
                <label class="col-sm-6 control-label">Risk Dollars And Details</label>
                <div class="clearfix"></div>
                <div class="col-md-12">
                  <asp:TextBox id="txtriskdollars" TextMode="MultiLine" class="form-control" rows="5" placeholder="Enter your Risk Dollars and Details" runat="server"></asp:TextBox>
                </div>
              </div>
            </div>

            <div class="col-md-12">
              <div class="pull-right button-adj">
                  <button type="submit" class="btn btn-primary mobile-button"><span class="glyphicon glyphicon-thumbs-up"></span> Submit</button>
              </div>
            </div><!--BUTTONS-->

          </div><!--inventory management team-->
        </div><!--tabs content-->
    </div><!--forms container-->

    

  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">

<script type="text/javascript">
  

     $(document).ready(function () {
           


             $('#<%=txtfirstreleasedate.ClientID%>').datepicker({
                format: "mm/dd/yyyy"
            });

            $('#<%=txtdaterequested.ClientID%>').datepicker({
                format: "mm/dd/yyyy"
            });

            $('#<%=txtcompletiondate.ClientID%>').datepicker({
                format: "mm/dd/yyyy"
            });

         
         //.removeClass('hidden');

     });




    function DeleteMe(obj, name) {


        var y = "";
        var x = $('#<%=hdFiles.ClientID%>').val()
        $('#' + obj).remove();
        
        y = x.replace(name, "");
        y = y.replace(",,", ",");
        y = y.replace(", ", "");
        
        if(y.substring(0,1)==",")
            y =y.substring(1,y.length);
        if (y.substring(y.length-1)==",")
            y =y.substring(0,y.length-1);
                
        $('#<%=hdFiles.ClientID%>').val(y);
    }

    </script>





</asp:Content>