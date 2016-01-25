<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CSCAssignment2Client.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />

</head>
<body>
     <!--Navbar-->  
  <div class = "navbar navbar-inverse navbar-static-top">
  
   <!--Navbar Container-->
    <div class="container">
      <div class="navbar-header">
        <a class="navbar-brand" href="index.html">CSCAssignment2Client</a>
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
          <h2>Home</h2>

    <form id="form1" runat="server">
    <div>
    <div id="resultBox"></div>
    </div>
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
