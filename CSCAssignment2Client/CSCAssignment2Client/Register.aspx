<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CSCAssignment2Client.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
  <title>Register - Smiling Image Sharing</title>
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

 <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
     
  </head>

  <body>
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
          <li><a href = "Login.aspx">Login</a></li>
          
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
          <h2>Register User</h2>
          <form id="form1" data-toggle="validator" runat="server">
           <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
          <span ></span>
          <div class="form-group">
           <label>Username:</label>
              <asp:TextBox ID="usernameText" runat="server" required></asp:TextBox>
            <span class="help-block with-errors"></span>
          </div>

          <div class="form-group">
           <label>Password:</label>
           <asp:TextBox ID="passwordText"  runat="server" required></asp:TextBox>
            <span class="help-block with-errors"></span>
          </div>
              <div class="form-group">
           <label>Email:</label>
           <asp:TextBox ID="emailText" runat="server" required></asp:TextBox>
            <span class="help-block with-errors"></span>
          </div>

          <div class="form-group">
           <label>Date Of Birth:</label>
              <asp:TextBox ID="dateofBirth"  class="datefield" data-val="true" data-val-required="Date is required" 
       type="date" runat="server" required></asp:TextBox>
            
            <span class="help-block with-errors"></span>
          </div>
             <div class="g-recaptcha" id="recaptcha" style="margin-left: 90px;"  data-sitekey="6LcAphUTAAAAAOmIaKwqgL5nlKr28c-GUlSascWz"></div>
              <span id="captcha" style="margin-left:100px;color:red" />
         <asp:Button ID="RegisterButton" CssClass="btn btn-default" style="display: block; width: 100%;" runat="server" Text="Register" OnClick="RegisterButton_Click" />
              <br />
             
                
          <asp:Button ID="homeButton"  CssClass="btn btn-default" style="display: block; width: 100%;" runat="server" Text="Return to Home!" OnClick="homeButton_Click"  />
       </form>

        </div>
            <!-- Content End -->                
         <div class = "col-lg-2 col-md-2">
             
          </div>
        </div>
        
      </div>

  
     <!-- JQuery -->
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

      <!-- Bootstrap -->
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" ></script>
               
      
      <!-- validation -->
    <script src= "https://cdnjs.cloudflare.com/ajax/libs/1000hz-bootstrap-validator/0.9.0/validator.min.js"></script>
     <script src='https://www.google.com/recaptcha/api.js' async defer></script>
       <script>
          $(document).ready(function(){
              var v = g-recaptcha.getResponse();
              if (v.length == 0) {
                  document.getElementById('recaptcha').innerHTML = "You can't leave Captcha Code empty";
                  return false;
              }
              if (v.length != 0) {
                  document.getElementById('recaptcha').innerHTML = "Captcha completed";
                  return true;
              }
          });
          

      </script>
               
  </body>
</html>
