﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSCAssignment2Client.Default" %>

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
        <a class="navbar-brand" href="Default.aspx"> Smiling Image Sharing</a>
        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
         <span class="sr-only">Toggle navigation</span>
         <span class="icon-bar"></span>
         <span class="icon-bar"></span>
         <span class="icon-bar"></span>
        </button>
      </div>

   <!-- Collect the nav links, forms, and other content for toggling -->
      <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1" >
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

            
          
            <asp:Label ID="lblWelcome" runat="server" style="position:relative; 
  left: 32%;
   bottom:5px; "  Text="Welcome to Smiling Image Sharing!" Font-Names="Roboto" Font-Size="Larger"></asp:Label>
          
          <form id="form1" role="form" runat="server"  data-toggle="validator">

        <!-- Display 5 recent pics -->
        <!-- allow user to upload here too? recent pics -->
              <br /><br />
         <asp:Button ID="loginButton" CssClass="btn btn-default" style="position:relative; 
   margin-left:-100px;
   left:50%;
   width:200px;
   bottom:5px; " runat="server" Text="Login" OnClick="loginButton_Click" />

              <asp:Button ID="uploadButton" CssClass="btn btn-default" style="position:relative; 
   margin-left:-100px;
   left:50%;
   width:200px;
   bottom:5px; " runat="server" Text="Upload Images here!" Visible="false" OnClick="uploadButton_Click"/>

                          <br /> <br />
                    <div id="resultBox"></div>
        
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

       <script>
        window.$resultBoxElement = $('#resultBox');
        $(document).ready(function () {
            handler = $.ajax({
                async: true,
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: "POST",
                url: "http://localhost:12801/BlobManager.asmx/GetBlobList"
            });
            handler.done(function (data) {
                var imageList = data.d;
                for (index = 0; index < imageList.length; index++) {
                    var $imageElement = $('<img></img>', { src: imageList[index].ImageURI });
                    $imageElement.attr('width', '250px');
                    $imageElement.attr('height', '150px');
                    window.$resultBoxElement.append($imageElement);
                }

            })
        });
    </script>
               
  </body>
</html>
