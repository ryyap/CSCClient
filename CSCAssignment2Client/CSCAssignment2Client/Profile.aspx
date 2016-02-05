﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="CSCAssignment2Client.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
 <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1"  data-toggle="validator" runat="server">
  <!--Navbar-->  
  <div class = "navbar navbar-inverse navbar-static-top">
  
   <!--Navbar Container-->
    <div class="container">
      <div class="navbar-header">
            <a class="navbar-brand" href="Default.aspx"> Smiling Image Sharing</a>
        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
         <span class="sr-only">Toggle navigation</span>
         <span class="icon-bar"></span>
         <span class="icon-bar"></span>
         <span class="icon-bar"></span>
        </button>
      </div>

      <!-- Collect the nav links, forms, and other content for toggling -->
      <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1" ng-controller="navController">
        <ul class = "nav navbar-nav navbar-right">
             <li><a href = "Default.aspx">Home</a></li>
    <li><a href = "Login.aspx"><asp:Label ID="lblLogin" runat="server" Text="Login" Visible="true"></asp:Label></a></li>
            <li><a href = "Profile.aspx"><asp:Label ID="lblUser" runat="server" Text="" Visible="false"></asp:Label></a></li>   
             <li><a href = "DisplayImages.aspx"><asp:Label ID="lblGallery" runat="server" Text="Your Images" Visible="false"></asp:Label></a></li>      
          <li><a href = "Logout.aspx"><asp:Label ID="lblLogout" runat="server" Text="Logout" Visible="false"></asp:Label></a></li>   
        </ul>
        <!--Top Right Navbar End-->
      </div>
    </div>
    <!-- Navbar Container End -->
   </div>
   <!--Nav Bar End-->
  
   <div class = "container">
      <div class = "row">
        <div class = "col-lg-2 col-md-2"> </div>
        <!-- Content -->
        <div class = "col-lg-8 col-md-8" >
          <h2>Profile</h2>

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
          <span ></span>

          <div class="form-group">
           <label>Username:</label>
         <asp:TextBox ID="usernameText" runat="server" required></asp:TextBox>
            <span class="help-block with-errors"></span>
          </div>

          <div class="form-group">
           <label>Date Of Birth:</label>
         <asp:TextBox ID="dobText" runat="server" required></asp:TextBox>
            <span class="help-block with-errors"></span>
          </div>

          <div class="form-group">
           <label>Email:</label>
         <asp:TextBox ID="emailText" runat="server" required></asp:TextBox>
            <span class="help-block with-errors"></span>
          </div>

          <div class="form-group">
           <label>Password:</label>
         <asp:TextBox ID="passwordText" runat="server" required></asp:TextBox>
            <span class="help-block with-errors"></span>
          </div>
              <br />

            <asp:Button ID="Button1" runat="server" Text="Confirm Changes" OnClick="Button1_Click" />
             
            
         </div>
               <!-- Content End -->                
         <div class = "col-lg-2 col-md-2">
             
          </div>
        </div>
        
      </div>
    </form>
     <!-- JQuery -->
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

      <!-- Bootstrap -->
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" ></script>

    <!-- validation -->
    <script src= "https://cdnjs.cloudflare.com/ajax/libs/1000hz-bootstrap-validator/0.9.0/validator.min.js"></script>
</body>
</html>
