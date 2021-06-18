<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Shopping.WebForm2" %>

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

            <asp:DropDownList ID="DorpDownList2ComboBox" runat="server" data-Combo="Y"  DataSourceID="SqlDataSourceQAQ" DataTextField="city" DataValueField="city" ></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSourceQAQ" runat="server" ConnectionString="<%$ ConnectionStrings:CityConnectionString %>" SelectCommand="SELECT DISTINCT city FROM City"></asp:SqlDataSource>
            <br>
            <br>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSourc" OnRowDeleting="GridView1_RowDeleting" >
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" InsertVisible="False" ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="serial" HeaderText="serial" SortExpression="serial" />
                    <asp:BoundField DataField="customerAccount" HeaderText="customerAccount" SortExpression="customerAccount" />
                    <asp:BoundField DataField="productPicture" HeaderText="productPicture" SortExpression="productPicture" />
                    <asp:TemplateField HeaderText="image">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("productPicture") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="120px" ImageUrl='<%# Eval("productPicture") %>' Width="100px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="productName" HeaderText="productName" SortExpression="productName" />
                    <asp:BoundField DataField="productColor" HeaderText="productColor" SortExpression="productColor" />
                    <asp:BoundField DataField="productPrice" HeaderText="productPrice" SortExpression="productPrice" />
                    <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
                    <asp:BoundField DataField="cart" HeaderText="cart" SortExpression="cart" />
                    <asp:TemplateField HeaderText="刪除" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSourc" runat="server" ConnectionString="<%$ ConnectionStrings:OrderDetailConnectionString %>" SelectCommand="SELECT * FROM [OrderDetail]"></asp:SqlDataSource>
           
        </div>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
