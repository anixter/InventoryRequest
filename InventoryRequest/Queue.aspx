<%@ Page Title="" Language="C#" MasterPageFile="~/pir.Master" AutoEventWireup="true" CodeBehind="Queue.aspx.cs" Inherits="PIR.Queue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="topper">
      <div class="container">
        <p class="pull-left"><span class="glyphicon glyphicon-user"></span>Welcome, <asp:Label ID="lbUserName" runat="server" Text=""></asp:Label></p>
        <p class="pull-right"><a href="PIRForm.aspx">Submit a PIR</a></p>
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
        <div class="col-md-10">
          <h1><strong>My Request Queue</strong></h1>
        </div>

        <div class="col-md-2">
          <p class="sort-options">Sort By:
            <select>
              <option>Newest to Old</option>
              <option>Oldest to New</option>
              <option>A-Z Order</option>
            </select>
          </p>
        </div>

        <div class="col-md-12 queue-item">
          <div class="col-md-12">
            <h3><span class="request-status pending">Pending</a></span> Luxury Wildlife Resort</h3>
          </div>

          <div class="col-md-4 queue-item-column">
            <p><strong>Scope of Request:</strong></p>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
            tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
            tempor incididunt ut labore et dolore magna aliqua.</p>
            <p><a href=""><span class="glyphicon glyphicon-envelope"></span> Request Follow-up</a></p>
          </div>

          <div class="col-md-4 queue-item-column">
            <p><strong>IRF For Part Setup Only?:</strong> Yes</p>
            <p><strong>Inside Sales Rep Name:</strong> Jan Vermeer</p>
            <p><strong>Project Name:</strong> Luxury Wildlife Resort</p>
            <p><strong>Project Total:</strong> $400,000</p>
            <p><strong>Inventory Request Total:</strong> $500</p>
            <p><strong>Sales Location:</strong> Isla Sorna, Costa Rica</p>
          </div>

          <div class="col-md-4">     
            <p><strong>Customer Name: </strong>John Hammond</p>
            <p><strong>Customer Number: </strong>0005810</p>
            <p><strong>First Release Date:</strong> 6/19/2017</p>
            <p><strong>Date Requested: </strong>4/5/2017</p>
            <p><strong>Completion Date: </strong>8/9/2017</p>
            <p><strong>Customer Credit Limit: </strong>$900,000,000</p>
          </div>
        </div><!--queue item-->

        <div class="col-md-12 queue-item">
          <div class="col-md-12">
            <h3><span class="request-status approved">Approved</a></span> Isla Sorna - Wildlife Enclosures</h3>
          </div>

          <div class="col-md-4 queue-item-column">
            <p><strong>Scope of Request:</strong></p>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
            tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
            tempor incididunt ut labore et dolore magna aliqua.</p>
          </div>

          <div class="col-md-4 queue-item-column">
            <p><strong>IRF For Part Setup Only?:</strong> Yes</p>
            <p><strong>Inside Sales Rep Name:</strong> John Hammond</p>
            <p><strong>Project Name:</strong> Isla Sorna - Wildlife Enclosures</p>
            <p><strong>Project Total:</strong> $400,000</p>
            <p><strong>Inventory Request Total:</strong> $500</p>
            <p><strong>Sales Location:</strong> Costa Rica</p>
          </div>

          <div class="col-md-4">     
            <p><strong>Customer Name: </strong>InGen, Inc.</p>
            <p><strong>Customer Number: </strong>0005810</p>
            <p><strong>First Release Date:</strong> 6/19/2017</p>
            <p><strong>Date Requested: </strong>4/5/2017</p>
            <p><strong>Completion Date: </strong>8/9/2017</p>
            <p><strong>Customer Credit Limit: </strong>$50,00</p>
          </div>
        </div><!--queue item-->

        <div class="col-md-12 queue-item">
          <div class="col-md-12">
            <h3><span class="request-status denied">Denied</a></span> Engineering Lab</h3>
          </div>

          <div class="col-md-4 queue-item-column">
            <p><strong>Scope of Request:</strong></p>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
            tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
            tempor incididunt ut labore et dolore magna aliqua.</p>
            <p><a href=""><span class="glyphicon glyphicon-envelope"></span> Request Follow-up</a></p>
          </div>

          <div class="col-md-4 queue-item-column">
            <p><strong>IRF For Part Setup Only?:</strong> No</p>
            <p><strong>Inside Sales Rep Name:</strong> Alan Grant </p>
            <p><strong>Project Name:</strong> Engineering Lab</p>
            <p><strong>Project Total:</strong> $400,000</p>
            <p><strong>Inventory Request Total:</strong> $500</p>
            <p><strong>Sales Location:</strong> Isla Sorna</p>
          </div>

          <div class="col-md-4">     
            <p><strong>Customer Name: </strong>Henry Wu</p>
            <p><strong>Customer Number: </strong>0005810</p>
            <p><strong>First Release Date:</strong> 6/19/2017</p>
            <p><strong>Date Requested: </strong>4/5/2017</p>
            <p><strong>Completion Date: </strong>8/9/2017</p>
            <p><strong>Customer Credit Limit: </strong>$500,000</p>
          </div>
        </div><!--queue item-->

      </div><!--intro-->
    </div><!--container-->
  

</asp:Content>
