<%@ Page Title="產品" Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="Shopping.product" %>

<!--A Design by W3layouts 
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>

<html>
<head>
    <title>Fashion Mania A Ecommerce Category Flat Bootstarp Resposive Website Template | Home :: w3layouts</title>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="js/jquery.min.js"></script>
    <!-- Custom Theme files -->
    <!--theme-style-->
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!--//theme-style-->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Fashion Mania Responsive web template, Bootstrap Web Templates, Flat Web Templates, Andriod Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyErricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- start menu -->
    <link href="css/memenu.css" rel="stylesheet" type="text/css" media="all" />
    <script type="text/javascript" src="js/memenu.js"></script>
    <script>$(document).ready(function () { $(".memenu").memenu(); });</script>
    <script src="js/simpleCart.min.js"> </script>
    <!-- slide -->
    <script src="js/responsiveslides.min.js"></script>
    <script>
        $(function () {
            $("#slider").responsiveSlides({
                auto: true,
                speed: 500,
                namespace: "callbacks",
                pager: true,
            });
        });
    </script>
</head>
<body>
    <form runat="server" method="post">
        <!--header-->
        <div class="header">
            <div class="header-top">
                <div class="container">
                    <div class="col-sm-4 number">
                        <span><i class="glyphicon glyphicon-phone"></i>0</span>2-2424-0000
                    </div>
                    <div class="col-sm-4 logo">
                        <a href="index">
                            <img src="images/CAT4.png" alt=""></a>
                    </div>

                    <div class="col-sm-4 header-left">
                        <asp:Button ID="Button3" runat="server" Text="註冊" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="45px" Style="float: right" OnClick="Button3_Click" />
                        <asp:Button ID="Button4" runat="server" Text="登錄" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="80px" Style="float: right" OnClick="Button4_Click" /><br>
                        <br>
                        <asp:Label ID="Label1" runat="server" Text="消費金額：" Style="float: right"></asp:Label><br>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/cart.png" Style="float: right" OnClick="ImageButton1_Click" Height="20" Width="20" />
                        <asp:Button ID="Button1" runat="server" Text="清空購物車" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="100" Style="float: right" OnClick="Button1_Click" Font-Size="Larger" />
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
            <div class="container">
                <div class="head-top">
                    <div class="col-sm-2 number">
                    </div>
                    <div class="col-md-8 h_menu4">
                        <ul class="memenu skyblue">
                            <li class=" grid"><a href="index">首頁</a></li>
                            <li><a class="color6" href="Customer\Chat.aspx">聯絡我們</a></li>
                        </ul>
                    </div>
                    <div class="col-sm-2 search">
                        <a class="play-icon popup-with-zoom-anim" href="#small-dialog"><i class="glyphicon glyphicon-search"></i></a>
                    </div>
                    <div class="clearfix"></div>
                    <!---pop-up-box---->
                    <script type="text/javascript" src="js/modernizr.custom.min.js"></script>
                    <link href="css/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
                    <script src="js/jquery.magnific-popup.js" type="text/javascript"></script>
                    <!---//pop-up-box---->
                    <div id="small-dialog" class="mfp-hide">
                        <div class="search-top">
                            <div class="login">
                                <input type="submit" value="">
                                <input type="text" value="Type something..." onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}">
                            </div>
                            <p>Shopping</p>
                        </div>
                    </div>
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
                    <!---->
                </div>
            </div>
        </div>
        <!---->
        <div class="single">

            <div class="container">
                <div class="col-md-9">
                    <div class="col-md-5 grid">
                        <asp:Image ID="Image1" runat="server" data-imagezoom="true" Height="100%" Width="100%" />
                    </div>
                    <div class="col-md-7 single-top-in">
                        <div class="single-para simpleCart_shelfItem">
                            <asp:Label ID="Label4" runat="server" Text="" Font-Size="X-Large"></asp:Label>
                        </div>
                        <asp:Label ID="Label3" runat="server" Text="產品金額：" Font-Size="X-Large"></asp:Label>
                        <asp:Label ID="Label2" runat="server" Text="" Font-Size="X-Large"></asp:Label>                 
                        <div class="available">
                            <ul>
                                <li>尺寸：Free Size</li>
                                <li>顏色：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="category" DataValueField="category"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT [category] FROM [Products] WHERE ([productName] = @productName)">
                                        <SelectParameters>
                                            <asp:SessionParameter Name="productName" SessionField="product" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>                                    
                                </li><br>
                                <li><asp:Label ID="Label5" runat="server" Text="尚餘庫存：" Font-Size="Larger"></asp:Label></li>
                            </ul>
                        </div>
                        <asp:Button ID="Button2" runat="server" Text="放入購物車" OnClick="Button2_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Style="float: right" Font-Size="X-Large" />
                    </div>
                </div>
            </div>
        </div>
        <div class="footer">
        <div class="container">
            <div class="footer-top">
                <div class="col-sm-7 number col-md8">
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7659.912326510472!2d121.56070378360901!3d25.03417107027919!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442abb6da80a7ad%3A0xacc4d11dc963103c!2z5Y-w5YyXMTAx!5e0!3m2!1szh-TW!2stw!4v1623592494222!5m2!1szh-TW!2stw" width="600" height="450" style="border: 0;"></iframe>
                </div>
                <div class="col-sm-4 number col-md4">
                    <asp:Label ID="Label18" runat="server" Text="丹丹服飾股份有限公司" Font-Size="XX-Large" Font-Bold="True"></asp:Label><br><br>
                    <asp:Label ID="Label19" runat="server" Text="地址：(110)台北市信義區信義路五段7號"></asp:Label><br>
                    <asp:Label ID="Label20" runat="server" Text="No. 7, Sec. 5, Xinyi Rd., Xinyi Dist., Taipei City 110615 , Taiwan (R.O.C.)"></asp:Label><br><br>
                </div>
                <div class="col-sm-4 number col-md4">
                    <asp:Label ID="Label21" runat="server" Text="聯絡我們" Font-Size="X-Large"></asp:Label><br><br>
                    <asp:Label ID="Label22" runat="server" Text="客服信箱 / vs.for.test2021@gmail.com"></asp:Label><br>
                    <asp:Label ID="Label23" runat="server" Text="服務時間 / 09:00 - 18:00 國定假日及例假日休息"></asp:Label><br>
                    <asp:Label ID="Label24" runat="server" Text="聯絡電話 / 02-2424-0000"></asp:Label><br>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
