<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="CSCAssignment2Client.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
 <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" data-toggle="validator" runat="server">
    <!--Navbar-->  
  <div class = "navbar navbar-inverse navbar-static-top">
  
   <!--Navbar Container-->
    <div class="container">
      <div class="navbar-header">
        <a class="navbar-brand" href="Default.aspx">CSCAssignment2Client</a>
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
            <li class="dropdown">
        <a class="dropdown-toggle" data-toggle="dropdown" href="#"><asp:Label ID="lblUser" runat="server" Text="" Visible="false"></asp:Label>
        <span class="caret"></span></a>
        <ul class="dropdown-menu">
            <li><a href="Profile.aspx"><asp:Label ID="lblProfile" runat="server" Text="Profile" Visible="false"></asp:Label></a></li>
          <li><a href="ChangePassword.aspx"><asp:Label ID="lblChangePassword" runat="server" Text="Change Password" Visible="false"></asp:Label></a></li>
        </ul>
      </li>
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
          <h2>Change Password</h2>

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
          <span ></span>



          <div class="form-group">
           <label>Old Password:</label>
         <asp:TextBox ID="oldPasswordText" runat="server" required></asp:TextBox>
            <span class="help-block with-errors"></span>
          </div>

         <div class="form-group">
           <label>New Password:</label>
         <asp:TextBox ID="newPasswordText" runat="server" required></asp:TextBox>
            <span class="help-block with-errors"></span>
          </div>

         <div class="form-group">
           <label>Re-Type Password:</label>
         <asp:TextBox ID="TextBox2" runat="server" required data-match="#newPasswordText"></asp:TextBox>
            <span class="help-block with-errors"></span>
          </div>

              <br />

            <asp:Button ID="Button1" runat="server" Text="Change Password" OnClick="Button1_Click"  />
             
            
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
