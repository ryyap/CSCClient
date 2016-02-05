<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayImages.aspx.cs" Inherits="CSCAssignment2Client.DisplayImages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
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

    <form id="form1" runat="server">
    <div id="display" runat="server"></div>


    <asp:GridView ID="imgData" runat="server"
     DataKeyNames="ID" AutoGenerateColumns="false"  
      OnRowCommand="imgData_RowCommand"  OnRowDataBound="imgData_RowDataBound">
    <Columns>
    <asp:BoundField DataField="ID" HeaderText="ID" />
    <asp:TemplateField HeaderText="Image">
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server" Width="200px" Height="200px" 
                   ImageUrl='<%# "ImageHandler.ashx?imageID=" + Eval("ID")%>'/>
        </ItemTemplate>
    </asp:TemplateField>
    <asp:ButtonField Text="Delete" CommandName="deleteCommand"  ButtonType="Button"  />
    </Columns>
    </asp:GridView>
       
   
            <h2>Wanna upload more images?</h2><br />
            <asp:Button ID="uploadButton" CssClass="btn btn-default" runat="server" Text="Upload Images here!" OnClick="uploadButton_Click"/>
         </form>
             <!-- Content End -->                
         <div class = "col-lg-2 col-md-2">
             
          </div>
        </div>
        
      </div>
    </div>
     <!-- JQuery -->
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

      <!-- Bootstrap -->
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" ></script>
</body>
</html>
