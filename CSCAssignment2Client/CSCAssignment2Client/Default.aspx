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
          <li id="Kappa"><a href = "Login.aspx">Login</a></li>   
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
          
         <h2>Welcome to Smiling Image Sharing!</h2>
          
          <form id="form1" role="form"   data-toggle="validator">

        <!-- Display 5 recent pics -->
        <!-- allow user to upload here too? recent pics -->
              
         

          <button type="submit" class="btn btn-default"
          style="display: block; width: 100%;">Login</button>

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
