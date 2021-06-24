<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="managershowpicture.aspx.cs" Inherits="Shopping.managershowpicture" %>

<!--A Design by W3layouts 
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html>
<head>
<title>丹丹服飾 : : 主頁顯示</title>
<link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
<!-- Custom Theme files -->
<!--theme-style-->
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<!--//theme-style-->
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Fashion Mania Responsive web template, Bootstrap Web Templates, Flat Web Templates, Andriod Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyErricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!---->
</head>
<body>
    <form runat="server" method="post">
        <!--header-->
        <div class="header">
            <div class="header-top">
                <div class="container">
                    <div class="col-md-4 number">
                       
                            <asp:Label ID="helpSQL" runat="server" Text="" Visible="False"></asp:Label>
                    </div>
                    <div class="col-md-4 logo">
                        <a href="">
                            <img src="images/CAT4.png" alt=""></a>
                    </div>
                    <div class="col-md-4 header-left">
                        <p class="log">
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">登出</asp:LinkButton>
                        </p>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
        <div class="container">
            <div class="head-top">
                <div class="col-md-2 number">
                </div>
                <div class="col-md-8 h_menu4">
                    <ul class="memenu skyblue">
                        <li><a href="manageraccount">帳戶</a></li>
                        <li><a href="managerproduct">商品</a></li>
                        <li><a href="managerorder">訂單</a></li>
                        <li><a href="managershoppingcar">購物車</a></li>
                        <li><a href="managercontact">回覆訊息</a></li>
                        <li><a href="managershowpicture">主頁顯示</a></li>
                    </ul>
                </div>
                <div class="col-md-2 search">
                    <a class="play-icon popup-with-zoom-anim" href="#small-dialog"><i class="glyphicon glyphicon-search"></i></a>
                </div>
                <br>
                <br>
                <br>
                <div class="container">

                    <div style="text-align: center">

                        <h1>商品主頁顯示管理 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h1>

                    </div>
                    <br>

                    <div class="container">
                        <div class="row">

                            <div class="col-sm-2">
                            </div>
                            <div class="col-sm-4">
                                <div class="h_nav">
                                    <h4>查詢方式:商品名稱</h4>
                                    <ul>
                                        <li>
                                            <asp:Label ID="productNS" runat="server" Text="商品名稱"></asp:Label></li>
                                        <li>
                                            <asp:DropDownList ID="DDLSearchProductName" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px">
                                                <asp:ListItem Value="0">請選擇</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceProductName" runat="server" ConnectionString="<%$ ConnectionStrings:ShowPictureConnectionString %>" SelectCommand="SELECT [productName] FROM [ShowPicture]"></asp:SqlDataSource>
                                        </li>
                                        <li>
                                            <asp:Label ID="hintPS" runat="server" Text="選擇即將搜尋的產品名稱"></asp:Label></li>
                                        <li>
                                            <asp:Button ID="Search" runat="server" OnClick="Button4_Click" Text="送出" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" /></li>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MonthsYearsDaysConnectionString %>" SelectCommand="SELECT show FROM YearsMonthsDays WHERE (show IS NOT NULL)"></asp:SqlDataSource>
                                        <br>
                                        <br>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-sm-4">
                                <div class="h_nav">
                                    <h4>查詢方式:當前顯示主頁圖片</h4>
                                    <ul>
                                        <li>
                                            <asp:Button ID="Button123" runat="server" OnClick="Button123_Click" Text="送出" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" /></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-sm-2">
                            </div>
                        </div>
                    </div>
                    <br>
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-2">
                            </div>
                            <div class="col-sm-8">
                                <div class="h_nav">
                                    <h4>快速設定:設定當前顯示主頁圖片</h4>
                                    <ul>
                                        <asp:Table ID="Tablefast" runat="server" GridLines="Both" CellPadding="10" align="center" Width="700px" >
                                            <asp:TableRow>
                                                <asp:TableCell ForeColor="#52d0c4" Font-Size="Larger" Width="130">
                                                設定編號
                                                </asp:TableCell >
                                                <asp:TableCell ForeColor="#52d0c4" Font-Size="Larger" Width="150">
                                                   1
                                                </asp:TableCell >
                                                <asp:TableCell ForeColor="#52d0c4" Font-Size="Larger" Width="150" >
                                                   2
                                                </asp:TableCell>
                                                <asp:TableCell ForeColor="#52d0c4" Font-Size="Larger" Width="150" >
                                                   3
                                                </asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell Width="130">
                                                 當前主頁圖片
                                                </asp:TableCell>
                                                <asp:TableCell Width="150">                                                    
                                                    <asp:Label ID="show1" runat="server" Text=""></asp:Label>
                                                </asp:TableCell >
                                                <asp:TableCell  Width="150">                                                    
                                                    <asp:Label ID="show2" runat="server" Text=""></asp:Label>
                                                </asp:TableCell >
                                                <asp:TableCell Width="150">                                                    
                                                    <asp:Label ID="show3" runat="server" Text=""></asp:Label>
                                                </asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell Width="130">
                                                 更改主頁圖片
                                                </asp:TableCell>
                                                <asp:TableCell Width="150">
                                                    <asp:DropDownList ID="DDLtt1" runat="server" AppendDataBoundItems="True" Height="30px" Width="150px"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                                                    <%--<asp:TextBox ID="TextBox5" runat="server" placeholder="請輸入產品名稱" Width="150"></asp:TextBox>--%>
                                                    <br>
                                                    <asp:Label ID="hintt1" runat="server" Text="" ></asp:Label>
                                                </asp:TableCell>
                                                <asp:TableCell Width="150">
                                                    <asp:DropDownList ID="DDLtt2" runat="server" AppendDataBoundItems="True" Height="30px" Width="150px"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                                                    <%--<asp:TextBox ID="TextBox7" runat="server" placeholder="請輸入產品名稱" Width="150"></asp:TextBox>--%>
                                                    <br>
                                                    <asp:Label ID="hintt2" runat="server" Text=""></asp:Label>
                                                </asp:TableCell>
                                                <asp:TableCell Width="150">
                                                    <asp:DropDownList ID="DDLtt3" runat="server" AppendDataBoundItems="True" Height="30px" Width="150px"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                                                    <%--<asp:TextBox ID="TextBox8" runat="server" placeholder="請輸入產品名稱" Width="150"></asp:TextBox>--%>
                                                    <br>
                                                    <asp:Label ID="hintt3" runat="server" Text=""></asp:Label>
                                                </asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                </div>
                                <div class="col-sm-2">
                               </div>
                            </div>
                        </div>
                        </div>
                        <div class="container">
                        <div class="row">
                            <div class="col-sm-2">
                            </div>
                            <div class="col-sm-8">
                                <div class="h_nav">
                                    <asp:Button ID="set" runat="server" Text="設定" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="set_Click" OnClientClick='return confirm("確定修改?")'/>
                                    <asp:Label ID="hintset" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                        </div>
                        <br>
                        <br>
                        <br>
                        <br>
                        <div class="container">
                            <div class="row">
                                <div class="col-sm-5">
                                </div>
                                <div class="col-sm-4">
                                    <h3>
                                        <asp:Label ID="Label9" runat="server" Text="商品上架" ForeColor="#52d0c4" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp; </h3>
                                    <br>
                                </div>
                            </div>
                        </div>
                        <div class="container">
                            <div class="row">
                                <div class="col-sm-1">
                                </div>
                                <div class="col-sm-10">
                                    <asp:Table ID="Tableadd" runat="server" GridLines="Both" CellPadding="10" align="center" Width="920px">
                                        <asp:TableRow>
                                            <asp:TableCell ForeColor="#52d0c4" Font-Size="Larger">
                                商品名稱
                                            </asp:TableCell>
                                            <asp:TableCell ForeColor="#52d0c4" Font-Size="Larger">
                                商品圖片
                                            </asp:TableCell>
                                            <asp:TableCell ForeColor="#52d0c4" Font-Size="Larger">
                                顯示設定
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                <asp:TextBox ID="TextBox10" runat="server" Width="200"></asp:TextBox>
                                                <br>
                                                <asp:Label ID="hintp1" runat="server" Text=""></asp:Label>
                                            </asp:TableCell>
                                            <asp:TableCell HorizontalAlign="Center">
                                                <asp:FileUpload ID="FileUpload2" runat="server" Width="200" />
                                                <br>
                                                <asp:Label ID="hintp2" runat="server" Text="" ForeColor="#52d0c4"></asp:Label>
                                            </asp:TableCell>
                                            <asp:TableCell>
                                                <asp:DropDownList ID="DDLShow" runat="server" Height="30px" Width="195px" AppendDataBoundItems="True">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList>
                                                <%--<asp:TextBox ID="TextBox12" runat="server" Width="200"></asp:TextBox>   --%>
                                                <br>
                                                <asp:Label ID="hintp3" runat="server" Text=""></asp:Label>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </div>
                                <div class="col-sm-1">
                                    <br>
                                    <asp:Button ID="sub" runat="server" Text="上架" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Width="80px" Height="80" OnClick="sub_Click" OnClientClick='return confirm("確定上架?")' />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-8">
                            </div>
                            <div class="col-sm-2">

                                <br>
                                <asp:Button ID="all" runat="server" Text="查看所有" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="all_Click" Width="105px" Height="40" />
                                <br>
                            </div>
                        </div>
                    </div>
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-2">
                            </div>

                            <div class="col-sm-10">
                                <asp:GridView ID="product" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" OnRowDeleting="product_RowDeleting" OnRowCancelingEdit="product_RowCancelingEdit" OnRowEditing="product_RowEditing" OnRowUpdating="product_RowUpdating" AllowPaging="True" OnPageIndexChanging="product_PageIndexChanging">
                                    <PagerStyle CssClass="fvPagerStyle" HorizontalAlign="Center" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="商品圖片">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("picture") %>' ReadOnly="True" Visible="False"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Image ID="Image1" runat="server" Height="120px" ImageUrl='<%# Eval("picture") %>' Width="100px" ValidateRequestMode="Inherit" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="ID">
                                            <EditItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="圖片檔名" SortExpression="picture" Visible="False" ValidateRequestMode="Enabled">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("picture") %>' Width="90"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("picture") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="商品名稱" SortExpression="productName">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("productName") %>' Width="150"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("productName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle Width="150px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="圖片檔名" SortExpression="picture">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("showpicture") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("showpicture") %>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle Width="150px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="顯示設定">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("show") %>' Width="100"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("show") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="編輯" ShowHeader="False">
                                            <EditItemTemplate>
                                                <asp:LinkButton ID="Update" runat="server" CausesValidation="False" CommandName="Update" Text="更新" OnClientClick='return confirm("確定更新?")' Width="50"></asp:LinkButton>
                                                <asp:LinkButton ID="Cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="Edit" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯"></asp:LinkButton>
                                            </ItemTemplate>
                                            <HeaderStyle Width="60px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="刪除" ShowHeader="False">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="Delete" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除" OnClientClick='return confirm("確定刪除?")' Width="50"></asp:LinkButton>
                                            </ItemTemplate>
                                            <HeaderStyle Width="60px" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerStyle ForeColor="Black" HorizontalAlign="Center" />
                                </asp:GridView>
                                <asp:SqlDataSource ID="SqlDataSourceProduct" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
                            </div>
                        </div>
                    </div>
                </div>
           </div>
        </div>
       
        <!---->



        
       
        <!---->

        <!--footer-->
        <div class="footer">
            <div class="container">
                <div class="footer-top">
                    <div class="col-sm-7 number col-md8">
                        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7659.912326510472!2d121.56070378360901!3d25.03417107027919!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442abb6da80a7ad%3A0xacc4d11dc963103c!2z5Y-w5YyXMTAx!5e0!3m2!1szh-TW!2stw!4v1623592494222!5m2!1szh-TW!2stw" width="600" height="450" style="border: 0;"></iframe>
                    </div>
                    <div class="col-sm-4 number col-md4">
                        <asp:Label ID="Label18" runat="server" Text="丹丹服飾股份有限公司" Font-Size="XX-Large" Font-Bold="True"></asp:Label><br>
                        <br>
                        <asp:Label ID="Label19" runat="server" Text="地址：(110)台北市信義區信義路五段7號"></asp:Label><br>
                        <asp:Label ID="Label20" runat="server" Text="No. 7, Sec. 5, Xinyi Rd., Xinyi Dist., Taipei City 110615 , Taiwan (R.O.C.)"></asp:Label><br>
                        <br>
                    </div>

                </div>
            </div>
        </div>
        <!-- slide -->
        <script src="js/jquery.min.js"></script>
        <script src="js/imagezoom.js"></script>
        <!-- start menu -->
        <link href="css/memenu.css" rel="stylesheet" type="text/css" media="all" />
        <script type="text/javascript" src="js/memenu.js"></script>
        <script>$(document).ready(function () { $(".memenu").memenu(); });</script>
        <script src="js/simpleCart.min.js"> </script>
        <!--initiate accordion-->
        <script type="text/javascript">
            $(function () {
                var menu_ul = $('.menu-drop > li > ul'),
                    menu_a = $('.menu-drop > li > a');
                menu_ul.hide();
                menu_a.click(function (e) {
                    e.preventDefault();
                    if (!$(this).hasClass('active')) {
                        menu_a.removeClass('active');
                        menu_ul.filter(':visible').slideUp('normal');
                        $(this).addClass('active').next().stop(true, true).slideDown('normal');
                    } else {
                        $(this).removeClass('active');
                        $(this).next().stop(true, true).slideUp('normal');
                    }
                });

            });
        </script>
        <!-- FlexSlider -->
        <script defer src="js/jquery.flexslider.js"></script>
        <link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" />

        <script>
            // Can also be used with $(document).ready()
            $(window).load(function () {
                $('.flexslider').flexslider({
                    animation: "slide",
                    controlNav: "thumbnails"
                });
            });
        </script>
        <!---pop-up-box---->
        <link href="css/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
        <script src="js/jquery.magnific-popup.js" type="text/javascript"></script>
        <!---//pop-up-box---->
        <script>
            $(document).ready(function () {
                $('.popup-with-zoom-anim').magnificPopup({
                    type: 'inline',
                    fixedContentPos: false,
                    fixedBgPos: true,
                    overflowY: 'auto',
                    closeBtnInside: true,
                    preloader: false,
                    midClick: true,
                    removalDelay: 300,
                    mainClass: 'my-mfp-zoom-in'
                });

            });
        </script>
    </form>
</body>
</html>
