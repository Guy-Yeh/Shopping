﻿<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="manageraccount.aspx.cs" Inherits="Shopping.manageraccount" %>

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
</head>
<body>
    <form runat="server" method="post">
        <!--header-->
        <div class="header">
            <div class="header-top">
                <div class="container">
                    <div class="col-md-4 number">

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
                            <li class=" grid"><a href="managerhome">首頁</a></li>
                            <li><a href="manageraccount">帳戶</a>
                                <div class="mepanel">
                                    <div class="row">
                                        <div class="col1">
                                            <div class="h_nav">
                                                <h4>All Clothing</h4>
                                                <ul>
                                                    <li><a href="products.html">Shirts</a></li>
                                                    <li><a href="products.html">Sports Wear</a></li>
                                                    <li><a href="products.html">Shorts</a></li>
                                                    <li><a href="products.html">Suits & Blazers</a></li>
                                                    <li><a href="products.html">Formal Shirts</a></li>
                                                    <li><a href="products.html">Sweatpants</a></li>
                                                    <li><a href="products.html">Swimwear</a></li>
                                                    <li><a href="products.html">Trousers & Chinos</a></li>
                                                    <li><a href="products.html">T-Shirts</a></li>
                                                    <li><a href="products.html">Underwear & Socks</a></li>

                                                </ul>
                                            </div>
                                        </div>
                                        <div class="col1">
                                            <div class="h_nav">
                                                <h4>Footwear</h4>
                                                <ul>
                                                    <li><a href="products.html">Formal Shoes</a></li>
                                                    <li><a href="products.html">Boots</a></li>
                                                    <li><a href="products.html">Sports Shoes</a></li>
                                                    <li><a href="products.html">Casual Shoes</a></li>
                                                    <li><a href="products.html">Running Shoes</a></li>
                                                    <li><a href="products.html">Sneakers</a></li>
                                                    <li><a href="products.html">Loafers</a></li>
                                                    <li><a href="products.html">Slippers</a></li>
                                                    <li><a href="products.html">Sandals</a></li>
                                                    <li><a href="products.html">Flip-flops</a></li>

                                                </ul>
                                            </div>
                                        </div>
                                        <div class="col1">
                                            <div class="h_nav">
                                                <h4>Popular Brands</h4>
                                                <ul>
                                                    <li><a href="products.html">Levis</a></li>
                                                    <li><a href="products.html">Persol</a></li>
                                                    <li><a href="products.html">Nike</a></li>
                                                    <li><a href="products.html">Edwin</a></li>
                                                    <li><a href="products.html">New Balance</a></li>
                                                    <li><a href="products.html">Jack & Jones</a></li>
                                                    <li><a href="products.html">Paul Smith</a></li>
                                                    <li><a href="products.html">Ray-Ban</a></li>
                                                    <li><a href="products.html">Wood Wood</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class="grid"><a href="managerproduct">產品</a>
                                <div class="mepanel">
                                    <div class="row">
                                        <div class="col1">
                                            <div class="h_nav">
                                                <h4>All Clothing</h4>
                                                <ul>
                                                    <li><a href="products.html">Shirts & Tops</a></li>
                                                    <li><a href="products.html">Sports Wear</a></li>
                                                    <li><a href="products.html">Kurtas & Kurties</a></li>
                                                    <li><a href="products.html">Suits & Blazers</a></li>
                                                    <li><a href="products.html">Sarees</a></li>
                                                    <li><a href="products.html">Sweatpants</a></li>
                                                    <li><a href="products.html">Swimwear</a></li>
                                                    <li><a href="products.html">Night-Suits</a></li>
                                                    <li><a href="products.html">T-Shirts</a></li>
                                                    <li><a href="products.html">Jeans</a></li>

                                                </ul>
                                            </div>
                                        </div>
                                        <div class="col1">
                                            <div class="h_nav">
                                                <h4>Footwear</h4>
                                                <ul>
                                                    <li><a href="products.html">Heels</a></li>
                                                    <li><a href="products.html">Flats</a></li>
                                                    <li><a href="products.html">Sports Shoes</a></li>
                                                    <li><a href="products.html">Casual Shoes</a></li>
                                                    <li><a href="products.html">Running Shoes</a></li>
                                                    <li><a href="products.html">Wedges</a></li>
                                                    <li><a href="products.html">Boots</a></li>
                                                    <li><a href="products.html">Pumps</a></li>
                                                    <li><a href="products.html">Slippers</a></li>
                                                    <li><a href="products.html">Flip-flops</a></li>

                                                </ul>
                                            </div>
                                        </div>
                                        <div class="col1">
                                            <div class="h_nav">
                                                <h4>Popular Brands</h4>
                                                <ul>
                                                    <li><a href="products.html">Levis</a></li>
                                                    <li><a href="products.html">Persol</a></li>
                                                    <li><a href="products.html">Nike</a></li>
                                                    <li><a href="products.html">Edwin</a></li>
                                                    <li><a href="products.html">New Balance</a></li>
                                                    <li><a href="products.html">Jack & Jones</a></li>
                                                    <li><a href="products.html">Paul Smith</a></li>
                                                    <li><a href="products.html">Ray-Ban</a></li>
                                                    <li><a href="products.html">Wood Wood</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li><a href="managerorder">訂單</a></li>
                            <li><a class="color6" href="managercontact">回覆訊息</a></li>
                        </ul>
                    </div>
                    <div class="col-md-2 search">
                        <a class="play-icon popup-with-zoom-anim" href="#small-dialog"><i class="glyphicon glyphicon-search"></i></a>
                    </div>

                    <br>
                    <br>
                    <%--<asp:Label ID="Label1" runat="server" Text="Revise Account Table" Font-Bold="True" style="float:right"></asp:Label>--%>
                    <br>

                    <div class="container">
                        <div style="text-align: center">
                            <h1>Revise Account Table&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
                        </div>
                        <br>
                        
                        <div class="mepanel">
                            <div class="row">
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>Add User Account</h4>
                                        <ul>
                                            <li>
                                                <asp:Label ID="account" runat="server" Text="account"></asp:Label></li>
                                            <li>
                                                <asp:TextBox ID="TextBox1" runat="server" placeholder="需包含6-15個英文加數字"></asp:TextBox></li>
                                            <li>
                                                <asp:Label ID="hintAccount" runat="server" ForeColor="Black"></asp:Label></li>
                                            <br>
                                            <li>
                                                <asp:Label ID="password" runat="server" Text="password"></asp:Label></li>
                                            <li>
                                                <asp:TextBox ID="TextBox2" runat="server" placeholder="需包含7-20個英文加數字"></asp:TextBox></li>
                                            <li>
                                                <asp:Label ID="hintPassword" runat="server" ForeColor="Black"></asp:Label></li>
                                            <br>
                                            <li>
                                                <asp:Label ID="name" runat="server" Text="name"></asp:Label></li>
                                            <li>
                                                <asp:TextBox ID="TextBox3" runat="server" placeholder="輸入10個位元內的中英文"></asp:TextBox></li>
                                            <li>
                                                <asp:Label ID="hintName" runat="server" ForeColor="Black"></asp:Label></li>
                                            <br>
                                            <li>
                                                <asp:Label ID="phone" runat="server" Text="phone"></asp:Label></li>
                                            <li>
                                                <asp:TextBox ID="TextBox4" runat="server" placeholder="請輸入09+8個數字"></asp:TextBox></li>
                                            <li>
                                                <asp:Label ID="hintPhone" runat="server" ForeColor="Black"></asp:Label></li>
                                            <br>
                                            <li>
                                                <asp:Label ID="email" runat="server" Text="email"></asp:Label></li>
                                            <li>
                                                <asp:TextBox ID="TextBox5" runat="server" placeholder="請輸入正確email"></asp:TextBox></li>
                                            <li>
                                                <asp:Label ID="hintEmail" runat="server" ForeColor="Black"></asp:Label></li>
                                            <br>
                                            <li>
                                                <asp:Label ID="address" runat="server" Text="address"></asp:Label></li>
                                            <li>
                                                <asp:DropDownList ID="DDLCity" runat="server" AutoPostBack="True" AppendDataBoundItems="True" Width="195px" Height="30px" OnSelectedIndexChanged="DDLCity_SelectedIndexChanged">
                                                    <asp:ListItem Value="0">請選擇縣市</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSourceCity" runat="server" ConnectionString="<%$ ConnectionStrings:CityConnectionString %>" SelectCommand="SELECT [city] FROM [City]"></asp:SqlDataSource>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintCity" runat="server" ForeColor="Black"></asp:Label></li>

                                            <li>
                                                <asp:DropDownList ID="DDLRegion" runat="server" AppendDataBoundItems="True" Width="195px" Height="30px">
                                                    <asp:ListItem Value="0" Selected="True">請選擇區域</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSourceRegion" runat="server" ConnectionString="<%$ ConnectionStrings:RegionConnectionString %>" SelectCommand="SELECT [region] FROM [Region] WHERE ([city] = @city)">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="DDLCity" DefaultValue="DDLCity.Selected.Item" Name="city" PropertyName="SelectedValue" Type="String" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintRegion" runat="server" ForeColor="Black"></asp:Label></li>

                                            <li>
                                                <asp:TextBox ID="TextBox11" runat="server" placeholder="請輸入縣市區域除外地址"></asp:TextBox></li>
                                            <li>
                                                <li>
                                                    <asp:Label ID="hintRoad" runat="server" ForeColor="Black"></asp:Label></li>
                                            </li>
                                            <br>
                                            <li>
                                                <asp:Label ID="discount" runat="server" Text="discount"></asp:Label></li>
                                            <li>
                                                <asp:TextBox ID="TextBox10" runat="server" placeholder="請輸入數字(非必填)"></asp:TextBox></li>
                                            <li>
                                                <asp:Label ID="hintDiscount" runat="server" ForeColor="Black"></asp:Label></li>
                                            <br>
                                            <li>
                                                <asp:Label ID="access" runat="server" Text="access"></asp:Label></li>
                                            <li>
                                                <asp:DropDownList ID="DDLAccess" runat="server" AppendDataBoundItems="True" Width="195px" Height="30px">
                                                    <asp:ListItem Value="0" Selected="True">請選擇</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSourceAccess" runat="server" ConnectionString="<%$ ConnectionStrings:AccessConnectionString %>" SelectCommand="SELECT [Cols] FROM [AccessCols]"></asp:SqlDataSource>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintAccess" runat="server" ForeColor="Black" Text="請選擇權限"></asp:Label></li>
                                            <br>
                                            <li>
                                                <asp:Label ID="picture" runat="server" Text="picture"></asp:Label></li>
                                            <li>
                                                <asp:FileUpload ID="FileUpload1" runat="server" /></li>
                                            <li>
                                                <asp:Label ID="hintPicture" runat="server" ForeColor="Black"></asp:Label></li>
                                            <br>
                                            <li>
                                                <asp:Button ID="Add" runat="server" OnClick="Button1_Click" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClientClick="javascript:if(!window.confirm('確定要新增嗎?')) window.event.returnValue=false;" /></li>
                                            <br>
                                            <br>
                                            <asp:GridView ID="useraccount" runat="server">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="image">
                                                        <ItemTemplate>
                                                            <asp:Image ID="img1" ImageUrl='<%#Eval("picture") %>' runat="server" Width="100" Height="120" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>Delete User Account</h4>
                                        <ul>
                                            <li>
                                                <asp:Label ID="accountID" runat="server" Text="accountID"></asp:Label></li>
                                            <li>
                                                <asp:DropDownList ID="DDLDeleteAccount" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSourceAccountID" runat="server" ConnectionString="<%$ ConnectionStrings:CustomersConnectionString %>" SelectCommand="SELECT [ID] FROM [Customers]"></asp:SqlDataSource>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintID" runat="server" Text="選擇即將刪除的accountID"></asp:Label></li>
                                            <br>
                                            <li>
                                                <asp:Button ID="Delete" runat="server" OnClick="Button2_Click" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClientClick="javascript:if(!window.confirm('確定要刪除嗎?')) window.event.returnValue=false;" /></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>Update User Account</h4>
                                        <ul>
                                            <li>
                                                <asp:Label ID="accountID2" runat="server" Text="accountID"></asp:Label></li>
                                            <li>
                                                <asp:DropDownList ID="DDLUpdateAccount" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList></asp:DropDownList></li>
                                            <li>
                                                <asp:Label ID="hintID2" runat="server" Text="選擇即將更新的accountID"></asp:Label><li>
                                                    <br>
                                                    <li></li>
                                            <li>
                                                <asp:Label ID="column" runat="server" Text="column"></asp:Label></li>
                                            <li>
                                                <asp:DropDownList ID="DDLUpdateCol" runat="server" AppendDataBoundItems="True" Width="195px" Height="30px">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSourceUpdateCol" runat="server" ConnectionString="<%$ ConnectionStrings:CustomersConnectionString %>" SelectCommand="SELECT [Cols] FROM [CustomersCols]"></asp:SqlDataSource>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintColumn" runat="server" Text="選擇即將更新的欄位"></asp:Label></li>
                                            <br>
                                            <li></li>
                                            <li>
                                                <asp:Label ID="value" runat="server" Text="update value"></asp:Label></li>
                                            <li>
                                                <asp:TextBox ID="TextBox9" runat="server" placeholder="請輸入更新的值"></asp:TextBox></li>
                                            <li>
                                                <asp:Label ID="hintAll" runat="server" Text=""></asp:Label></li>
                                            <br>
                                            <li>
                                                <asp:Button ID="Update" runat="server" Text="submit" OnClick="Button3_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClientClick="javascript:if(!window.confirm('確定要修改嗎?')) window.event.returnValue=false;" />
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix">
                            <br>
                        </div>
                        <div id="small-dialog" class="mfp-hide">
                            <div class="search-top">
                                <div class="login">
                                    <input type="submit" value="">
                                    <input type="text" value="Type something..." onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}">
                                </div>
                                <p>Shopping</p>
                            </div>
                        </div>
                        <!---->
                    </div>
            </div>
        </div>
        <!---->
        <div class="single">
        </div>
        <!--footer-->
        <div class="footer">
            <div class="container">
                <div class="footer-top">
                    <div class="col-md-8 top-footer">
                        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7659.912326510472!2d121.56070378360901!3d25.03417107027919!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442abb6da80a7ad%3A0xacc4d11dc963103c!2z5Y-w5YyXMTAx!5e0!3m2!1szh-TW!2stw!4v1623592494222!5m2!1szh-TW!2stw" width="600" height="450" style="border: 0;" allowfullscreen="" loading="lazy"></iframe>
                    </div>
                    <div class="col-md-4 top-footer1">
                        <h2>Newsletter</h2>
                        <form>
                            <input type="text" value="" onfocus="this.value='';" onblur="if (this.value == '') {this.value ='';}">
                            <input type="submit" value="SUBSCRIBE">
                        </form>
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
            <div class="footer-bottom">
                <div class="container">
                    <div class="col-md-3 footer-bottom-cate">
                        <h6>Categories</h6>
                        <ul>
                            <li><a href="#">Curabitur sapien</a></li>
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
