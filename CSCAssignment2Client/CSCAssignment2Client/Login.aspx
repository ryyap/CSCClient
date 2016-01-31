<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CSCAssignment2Client.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head>

  <title>Login - Smiling Image Sharing</title>

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
          
          <form id="form1" runat="server">
          
          <span ng-show="message"></span>
          <div class="form-group">
           <label>Email:</label>
         <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
           <!-- <span class="help-block with-errors"></span>-->
              <ASP:RequiredFieldValidator ControlToValidate="emailText"
           Display="Static" ErrorMessage="*" runat="server" 
           ID="vUserName" />
          </div>

          <div class="form-group">
           <label>Password:</label>
         <asp:TextBox ID="passwordText"  TextMode="password" runat="server"></asp:TextBox>
            <!--<span class="help-block with-errors"></span>-->
              <ASP:RequiredFieldValidator ControlToValidate="passwordText"
          Display="Static" ErrorMessage="*" runat="server" 
          ID="vUserPass" />
          </div>
              <br />
              Remember Me? <ASP:CheckBox id="chkPersistCookie" runat="server" autopostback="false" />
         <asp:Button ID="loginButton" CssClass="btn btn-default" style="display: block; width: 100%;" runat="server" Text="Login" OnClick="loginButton_Click" />

          <asp:Button ID="registerButton"  CssClass="btn btn-default" style="display: block; width: 100%;" runat="server" Text="Don't have an account? Register Here!" OnClick="registerButton_Click"  />
              <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         </form></div>
               <!-- Content End -->                
         <div class = "col-lg-2 col-md-2">
             
          </div>
        </div>
        
      </div>

  
    <!-- JQuery -->
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

      <!-- Bootstrap -->
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" ></script>
      
               
      

      
               
  </body>
</html>
