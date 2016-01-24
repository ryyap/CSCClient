<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayImages.aspx.cs" Inherits="CSCAssignment2Client.DisplayImages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
  <link href = "/bootstrap-3.3.5-dist/css/bootstrap.min.css" rel = "stylesheet"/>
  <link href = "/bootstrap-3.3.5-dist/css/styles.css" rel = "stylesheet"/>
</head>
<body>
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
       
    </form>

    
      <!-- JQuery -->
      <script src = "/Javascript/jquery-1.11.3.min.js"></script>
      <script src = "/Javascript/jquery-1.11.3.js"></script>

      <!-- Bootstrap -->
      <script src = "/bootstrap-3.3.5-dist/js/bootstrap.js"></script>
</body>
</html>
