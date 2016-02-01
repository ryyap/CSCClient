<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSCAssignment2Client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
  <title>Welcome to Smiling Image Sharing!</title>
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
 <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />

 </head>

  <body>
               
  <!--Navbar-->  
  <div class = "navbar navbar-inverse navbar-static-top">
  
   <!--Navbar Container-->
    <div class="container">
      <div class="navbar-header">
        <a class="navbar-brand" href="#">CSCAssignment2Client</a>
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
             <li><a href = "#">Home</a></li>
          <li><a href = "Login.aspx"><asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label></a></li>   
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
          
            <asp:Label ID="lblWelcome" runat="server" style="position:relative; 
  left: 32%;
   bottom:5px; "  Text="Welcome to Smiling Image Sharing!" Font-Names="Roboto" Font-Size="Larger"></asp:Label>
          
          <form id="form1" role="form" runat="server"  data-toggle="validator">

        <!-- Display 5 recent pics -->
        <!-- allow user to upload here too? recent pics -->
              <br /><br />
         <asp:Button ID="loginButton" CssClass="btn btn-default" style="position:absolute; 
   margin-left:-100px;
   left:50%;
   width:200px;
   bottom:5px; " runat="server" Text="Login" OnClick="loginButton_Click" />

              

         </form>
              
                                                
         </div>       
         <!-- Content End -->                
         <div class = "col-lg-2 col-md-2"></div>
        </div>
        
      </div>


     <!-- JQuery -->
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

      <!-- Bootstrap -->
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" ></script>

      
               
  </body>
</html>
