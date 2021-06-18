<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="managershoppingcar.aspx.cs" Inherits="Shopping.managershoppingcar" %>

<!--A Design by W3layouts 
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html>
<head>
    <title>Fashion Mania A Ecommerce Category Flat Bootstarp Resposive Website Template | Single :: w3layouts</title>
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
    <script type="text/javascript"> 
        function ConfirmMe() {
            if (Page_ClientValidate()) {
                return confirm('確定送出嗎?');
            }
            else {
                return false;
            }
        }
    </script>
</head>
<body>
    <form runat="server" method="post">
        <!--header-->
        <div class="header">
            <div class="header-top">
                <div class="container">
                    <div class="col-md-4 world">
                        <span><i class="glyphicon glyphicon-phone"></i>0</span>2-2424-0000
                    </div>
                    <div class="col-md-4 logo">
                        <a href="index.html">
                            <img src="images/CAT4.png" alt=""></a>
                    </div>

                    <div class="col-md-4 header-left">
                        <p class="log">
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
                        </p>
                        <div class="cart box_1">
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
                            <li><a href="managerproduct">產品</a></li>
                            <li><a href="managerorder">訂單</a></li>
                            <li><a href="managershoppingcar">購物車</a></li>
                            <li><a class="color6" href="managercontact">回覆訊息</a></li>
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

                            <h1>Search Shoppingcar Table&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>

                        </div>
                        <br>
                        <div class="mepanel">
                            <div class="row">
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>Search by CustomerAccount</h4>
                                        <ul>
                                            <li>
                                                <asp:Label ID="customerAccount" runat="server" Text="customerAccount"></asp:Label></li>
                                            <li>
                                                <asp:DropDownList ID="DDLSearchCustomerAccount" runat="server" AppendDataBoundItems="True" Width="195px" Height="30px">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSourceCustomerAccount" runat="server" ConnectionString="<%$ ConnectionStrings:CustomersConnectionString %>" SelectCommand="SELECT [account] FROM [Customers]"></asp:SqlDataSource>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintCustomerAccount" runat="server" Text=""></asp:Label></li>
                                            <li>
                                                <asp:Button ID="customerAccountsearch" runat="server" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="customerAccountsearch_Click" /></li>
                                            <br>                                            
                                            <br>                                            
                                        </ul>                                                                                
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>Search by ProductName</h4>
                                        <ul>
                                            <li>
                                                <asp:Label ID="productName" runat="server" Text="productName"></asp:Label></li>
                                            <li>
                                                <asp:DropDownList ID="DDLSearchProductName" runat="server" AppendDataBoundItems="True" Height="30px" Width="195px">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSourceProductName" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT DISTINCT productName FROM Products"></asp:SqlDataSource>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintProductName" runat="server" Text=""></asp:Label></li>
                                            <li>
                                                <asp:Button ID="productNamesearch" runat="server" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="productNamesearch_Click" /></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>Search by ProductColor</h4>
                 
                                        <ul>
                                            <li>
                                                <asp:Label ID="productColor" runat="server" Text="productColor"></asp:Label></li>
                                            <li>
                                                <asp:DropDownList ID="DDLSearchproductColor" runat="server" AppendDataBoundItems="True" Height="30px" Width="195px" >
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList>
   
                                                <asp:SqlDataSource ID="SqlDataSourceProductColor" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT DISTINCT category FROM Products"></asp:SqlDataSource>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintproductColor" runat="server" Text=""></asp:Label></li>
                                            <li>
                                                <asp:Button ID="colorsearch" runat="server" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="colorsearch_Click" /></li>
                                            <br>
                                            
                                        </ul>
                                    </div>
                                </div>
                            </div>
                           </div>
                        </div>
                        
                        <div class="clearfix" style="text-align: left" >
                            <asp:GridView ID="usershoppingcar" runat="server" AutoGenerateColumns="False" DataKeyNames="ID">
                                                <Columns>
                                                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" InsertVisible="False" ReadOnly="True" />
                                                    <asp:BoundField DataField="customerAccount" HeaderText="customerAccount" SortExpression="customerAccount" />
                                                    <asp:BoundField DataField="productPicture" HeaderText="productPicture" SortExpression="productPicture" Visible="False" />
                                                    <asp:BoundField DataField="productName" HeaderText="productName" SortExpression="productName" />
                                                    <asp:BoundField DataField="productColor" HeaderText="productColor" SortExpression="productColor" />
                                                    <asp:TemplateField HeaderText="image">
                                                        <EditItemTemplate>
                                                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("productPicture") %>'></asp:TextBox>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Image ID="Image1" runat="server" Height="120px" ImageUrl='<%# Eval("productPicture") %>' Width="100px" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="productPrice" HeaderText="productPrice" SortExpression="productPrice" />
                                                    <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
                                                    <asp:BoundField DataField="cart" HeaderText="cart" SortExpression="cart" Visible="False" />
                                                </Columns>
                                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSourceShoppingcar" runat="server" ConnectionString="<%$ ConnectionStrings:OrderDetailConnectionString %>" SelectCommand="SELECT * FROM [OrderDetail]"></asp:SqlDataSource>                                                     
                        </div>
                        <div id="small-dialog" class="mfp-hide">
                            <div class="search-top">
                                <div class="login">
                                    <input type="submit" value="">
                                    <input type="text" value="Type something..." onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}">
                                </div>
                                <p>Shoppingurabitur sapien</a></li>
                                <li><a href="#">Dignissim purus</a></li>
                                <li><a href="#">Tempus pretium</a></li>
                                <li><a href="#">Dignissim neque</a></li>
                                <li><a href="#">Ornared id aliquet</a></li>

                            </ul>
                        </div>
                        <div class="col-md-3 footer-bottom-cate">
                            <h6>Feature Projects</h6>
                            <ul>
                                <li><a href="#">Curabitur sapien</a></li>
                                <li><a href="#">Dignissim purus</a></li>
                                <li><a href="#">Tempus pretium</a></li>
                                <li><a href="#">Dignissim neque</a></li>
                                <li><a href="#">Ornared id aliquet</a></li>

                            </ul>
                        </div>
                        <div class="col-md-3 footer-bottom-cate">
                            <h6>Top Brands</h6>
                            <ul>
                                <li><a href="#">Curabitur sapien</a></li>
                                <li><a href="#">Dignissim purus</a></li>
                                <li><a href="#">Tempus pretium</a></li>
                                <li><a href="#">Dignissim neque</a></li>
                                <li><a href="#">Ornared id aliquet</a></li>
                                <li><a href="#">Ultrices id du</a></li>
                                <li><a href="#">Commodo sit</a></li>

                            </ul>
                        </div>
                        <div class="col-md-3 footer-bottom-cate cate-bottom">
                            <h6>Our Address</h6>
                            <ul>
                                <li>Aliquam metus  dui. </li>
                                <li>orci, ornareidquet</li>
                                <li>ut,DUI.</li>
                                <li>nisi, dignissim</li>
                                <li>gravida at.</li>
                                <li class="phone">PH : 6985792466</li>
                            </ul>
                        </div>
                        <div class="clearfix"></div>
                        <p class="footer-class">© 2015 Fashion Mania. All Rights Reserved | Design by <a href="http://w3layouts.com/" target="_blank">W3layouts</a> </p>
                    </div>
                </div>
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
