<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Shopping.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   <link href= "css/style.css" rel="stylesheet" />
   <link href="DorpDownList2ComboBox.css" rel="stylesheet" />
   <script src="js/jquery.min.css"></script>
   <script src="DropDownList2ComboBox.js"></script>
   <%-- <script type="text/javascript" src="http://jsearchdropdown.sourceforge.net/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="http://jsearchdropdown.sourceforge.net//jquery.searchabledropdown.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('DorpDownList2ComboBox').searchable();
        }); 
    </script>--%>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />

         

        </div>
    </form>
</body>
</html>
