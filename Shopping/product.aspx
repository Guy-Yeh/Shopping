﻿<%@ Page Title="產品" Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="Shopping.product" %>

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
					<a href="index"><img src="images/logo.png" alt=""></a>	
				</div>
		
			<div class="col-sm-4 header-left">		
				<asp:Button ID="Button3" runat="server" Text="註冊" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="45px" style="float:right" />
                <asp:Button ID="Button4" runat="server" Text="登錄" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="80px" style="float:right" OnClick="Button4_Click" /><br><br>
				<asp:Label ID="Label1" runat="server" Text="消費金額：" style="float:right"></asp:Label><br>
				<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/cart.png" style="float:right" OnClick="ImageButton1_Click" Height="20" Width="20" />
                <asp:Button ID="Button1" runat="server" Text="清空購物車" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="100" style="float:right" OnClick="Button1_Click" Font-Size="Larger" />
			</div>
				<div class="clearfix"> </div>
		</div>
		</div>
		<div class="container">
			<div class="head-top">
				<div class="col-sm-2 number">

				</div>
		<div class="col-md-8 h_menu4">
				<ul class="memenu skyblue">
                        <li class=" grid"><a href="index">首頁</a></li>
                        <li><a href="#">男裝</a>
                            <div class="mepanel">
                                <div class="row">
                                    <div class="col1">
                                        <div class="h_nav">
                                            <h4>All Clothing</h4>
                                            <ul>
                                                <li><a href="product">Shirts</a></li>
                                                <li><a href="product">Sports Wear</a></li>
                                                <li><a href="product">Shorts</a></li>
                                                <li><a href="product">Suits & Blazers</a></li>
                                                <li><a href="product">Formal Shirts</a></li>
                                                <li><a href="product">Sweatpants</a></li>
                                                <li><a href="product">Swimwear</a></li>
                                                <li><a href="product">Trousers & Chinos</a></li>
                                                <li><a href="product">T-Shirts</a></li>
                                                <li><a href="product">Underwear & Socks</a></li>

                                            </ul>
                                        </div>
                                    </div>
                                    <div class="col1">
                                        <div class="h_nav">
                                            <h4>Footwear</h4>
                                            <ul>
                                                <li><a href="product">Formal Shoes</a></li>
                                                <li><a href="product">Boots</a></li>
                                                <li><a href="product">Sports Shoes</a></li>
                                                <li><a href="product">Casual Shoes</a></li>
                                                <li><a href="product">Running Shoes</a></li>
                                                <li><a href="product">Sneakers</a></li>
                                                <li><a href="product">Loafers</a></li>
                                                <li><a href="product">Slippers</a></li>
                                                <li><a href="product">Sandals</a></li>
                                                <li><a href="product">Flip-flops</a></li>

                                            </ul>
                                        </div>
                                    </div>
                                    <div class="col1">
                                        <div class="h_nav">
                                            <h4>Popular Brands</h4>
                                            <ul>
                                                <li><a href="product">Levis</a></li>
                                                <li><a href="product">Persol</a></li>
                                                <li><a href="product">Nike</a></li>
                                                <li><a href="product">Edwin</a></li>
                                                <li><a href="product">New Balance</a></li>
                                                <li><a href="product">Jack & Jones</a></li>
                                                <li><a href="product">Paul Smith</a></li>
                                                <li><a href="product">Ray-Ban</a></li>
                                                <li><a href="product">Wood Wood</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
                        <li class="grid"><a href="#">女裝</a>
                            <div class="mepanel">
                                <div class="row">
                                    <div class="col1">
                                        <div class="h_nav">
                                            <h4>All Clothing</h4>
                                            <ul>
                                                <li><a href="product">Shirts & Tops</a></li>
                                                <li><a href="product">Sports Wear</a></li>
                                                <li><a href="product">Kurtas & Kurties</a></li>
                                                <li><a href="product">Suits & Blazers</a></li>
                                                <li><a href="product">Sarees</a></li>
                                                <li><a href="product">Sweatpants</a></li>
                                                <li><a href="product">Swimwear</a></li>
                                                <li><a href="product">Night-Suits</a></li>
                                                <li><a href="product">T-Shirts</a></li>
                                                <li><a href="product">Jeans</a></li>

                                            </ul>
                                        </div>
                                    </div>
                                    <div class="col1">
                                        <div class="h_nav">
                                            <h4>Footwear</h4>
                                            <ul>
                                                <li><a href="product">Heels</a></li>
                                                <li><a href="product">Flats</a></li>
                                                <li><a href="product">Sports Shoes</a></li>
                                                <li><a href="product">Casual Shoes</a></li>
                                                <li><a href="product">Running Shoes</a></li>
                                                <li><a href="product">Wedges</a></li>
                                                <li><a href="product">Boots</a></li>
                                                <li><a href="product">Pumps</a></li>
                                                <li><a href="product">Slippers</a></li>
                                                <li><a href="product">Flip-flops</a></li>

                                            </ul>
                                        </div>
                                    </div>
                                    <div class="col1">
                                        <div class="h_nav">
                                            <h4>Popular Brands</h4>
                                            <ul>
                                                <li><a href="product">Levis</a></li>
                                                <li><a href="product">Persol</a></li>
                                                <li><a href="product">Nike</a></li>
                                                <li><a href="product">Edwin</a></li>
                                                <li><a href="product">New Balance</a></li>
                                                <li><a href="product">Jack & Jones</a></li>
                                                <li><a href="product">Paul Smith</a></li>
                                                <li><a href="product">Ray-Ban</a></li>
                                                <li><a href="product">Wood Wood</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
						<li class="grid"><a href="#">配件</a>
                            <div class="mepanel">
                                <div class="row">
                                    <div class="col1">
                                        <div class="h_nav">
                                            <h4>All Clothing</h4>
                                            <ul>
                                                <li><a href="product">Shirts & Tops</a></li>
                                                <li><a href="product">Sports Wear</a></li>
                                                <li><a href="product">Kurtas & Kurties</a></li>
                                                <li><a href="product">Suits & Blazers</a></li>
                                                <li><a href="product">Sarees</a></li>
                                                <li><a href="product">Sweatpants</a></li>
                                                <li><a href="product">Swimwear</a></li>
                                                <li><a href="product">Night-Suits</a></li>
                                                <li><a href="product">T-Shirts</a></li>
                                                <li><a href="product">Jeans</a></li>

                                            </ul>
                                        </div>
                                    </div>
                                    <div class="col1">
                                        <div class="h_nav">
                                            <h4>Footwear</h4>
                                            <ul>
                                                <li><a href="product">Heels</a></li>
                                                <li><a href="product">Flats</a></li>
                                                <li><a href="product">Sports Shoes</a></li>
                                                <li><a href="product">Casual Shoes</a></li>
                                                <li><a href="product">Running Shoes</a></li>
                                                <li><a href="product">Wedges</a></li>
                                                <li><a href="product">Boots</a></li>
                                                <li><a href="product">Pumps</a></li>
                                                <li><a href="product">Slippers</a></li>
                                                <li><a href="product">Flip-flops</a></li>

                                            </ul>
                                        </div>
                                    </div>
                                    <div class="col1">
                                        <div class="h_nav">
                                            <h4>Popular Brands</h4>
                                            <ul>
                                                <li><a href="product">Levis</a></li>
                                                <li><a href="product">Persol</a></li>
                                                <li><a href="product">Nike</a></li>
                                                <li><a href="product">Edwin</a></li>
                                                <li><a href="product">New Balance</a></li>
                                                <li><a href="product">Jack & Jones</a></li>
                                                <li><a href="product">Paul Smith</a></li>
                                                <li><a href="product">Ray-Ban</a></li>
                                                <li><a href="product">Wood Wood</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
                        <li><a class="color6" href="contact.html">聯絡我們</a></li>
                    </ul> 
			</div>
				<div class="col-sm-2 search">		
			<a class="play-icon popup-with-zoom-anim" href="#small-dialog"><i class="glyphicon glyphicon-search"> </i> </a>
		</div>
		<div class="clearfix"> </div>
			<!---pop-up-box---->
					  <script type="text/javascript" src="js/modernizr.custom.min.js"></script>    
					<link href="css/popuo-box.css" rel="stylesheet" type="text/css" media="all"/>
					<script src="js/jquery.magnific-popup.js" type="text/javascript"></script>
					<!---//pop-up-box---->
				<div id="small-dialog" class="mfp-hide">
				<div class="search-top">
						<div class="login">
							<input type="submit" value="">
							<input type="text" value="Type something..." onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}">		
						</div>
						<p>	Shopping</p>
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
                        <h1>
                            <asp:Label ID="Label4" runat="server" Text=""></asp:Label></h1>
                        <p>產品註解</p>
                        <div class="clearfix"></div>
                    </div>
					<asp:Label ID="Label3" runat="server" Text="產品金額：" Font-Size="X-Large"></asp:Label>
					<asp:Label ID="Label2" runat="server" Text="" Font-Size="X-Large"></asp:Label>
                    <div class="available">
                        <ul>

                            <li>尺寸：Free Size</li>
                            <li>
                            顏色：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="category" DataValueField="category"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT [category] FROM [Products] WHERE ([productName] = @productName)">
                                    <SelectParameters>
                                        <asp:SessionParameter Name="productName" SessionField="product" Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource></li>
                        </ul>
					</div>
					<asp:Button ID="Button2" runat="server" Text="放入購物車" OnClick="Button2_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" style="float:right"/>
				</div>
			</div>
                    <div class="clearfix"></div>
                    <div class="content-top1">
                        <div class="col-md-4 col-md3">
                            <div class="col-md1 simpleCart_shelfItem">
                                <a href="single.html">
                                    <img class="img-responsive" src="images/pi6.png" alt="" />
                                </a>
                                <h3><a href="single.html">Jeans</a></h3>
                                <div class="price">
                                    <h5 class="item_price">$300</h5>
                                    <a href="#" class="item_add">Add To Cart</a>
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-md3">
                            <div class="col-md1 simpleCart_shelfItem">
                                <a href="single.html">
                                    <img class="img-responsive" src="images/pi7.png" alt="" />
                                </a>
                                <h3><a href="single.html">Tops</a></h3>
                                <div class="price">
                                    <h5 class="item_price">$300</h5>
                                    <a href="#" class="item_add">Add To Cart</a>
                                    <div class="clearfix"></div>
                                </div>

                            </div>
                        </div>
                        <div class="col-md-4 col-md3">
                            <div class="col-md1 simpleCart_shelfItem">
                                <a href="single.html">
                                    <img class="img-responsive" src="images/pi.png" alt="" />
                                </a>
                                <h3><a href="single.html">Tops</a></h3>
                                <div class="price">
                                    <h5 class="item_price">$300</h5>
                                    <a href="#" class="item_add">Add To Cart</a>
                                    <div class="clearfix"></div>
                                </div>

                            </div>
                        </div>

                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
<!----->
<div class="col-md-3 product-bottom">
			<!--categories-->
				<div class=" rsidebar span_1_of_left">
						<h3 class="cate">Categories</h3>
							 <ul class="menu-drop">
							<li class="item1"><a href="#">Men </a>
								<ul class="cute">
									<li class="subitem1"><a href="single.html">Cute Kittens </a></li>
									<li class="subitem2"><a href="single.html">Strange Stuff </a></li>
									<li class="subitem3"><a href="single.html">Automatic Fails </a></li>
								</ul>
							</li>
							<li class="item2"><a href="#">Women </a>
								<ul class="cute">
									<li class="subitem1"><a href="single.html">Cute Kittens </a></li>
									<li class="subitem2"><a href="single.html">Strange Stuff </a></li>
									<li class="subitem3"><a href="single.html">Automatic Fails </a></li>
								</ul>
							</li>
							<li class="item3"><a href="#">Kids</a>
								<ul class="cute">
									<li class="subitem1"><a href="single.html">Cute Kittens </a></li>
									<li class="subitem2"><a href="single.html">Strange Stuff </a></li>
									<li class="subitem3"><a href="single.html">Automatic Fails</a></li>
								</ul>
							</li>
							<li class="item4"><a href="#">Accesories</a>
								<ul class="cute">
									<li class="subitem1"><a href="single.html">Cute Kittens </a></li>
									<li class="subitem2"><a href="single.html">Strange Stuff </a></li>
									<li class="subitem3"><a href="single.html">Automatic Fails</a></li>
								</ul>
							</li>
									
							<li class="item4"><a href="#">Shoes</a>
								<ul class="cute">
									<li class="subitem1"><a href="single.html">Cute Kittens </a></li>
									<li class="subitem2"><a href="single.html">Strange Stuff </a></li>
									<li class="subitem3"><a href="single.html">Automatic Fails </a></li>
								</ul>
							</li>
						</ul>
					</div>
				<!--initiate accordion-->
						<script type="text/javascript">
							$(function() {
							    var menu_ul = $('.menu-drop > li > ul'),
							           menu_a  = $('.menu-drop > li > a');
							    menu_ul.hide();
							    menu_a.click(function(e) {
							        e.preventDefault();
							        if(!$(this).hasClass('active')) {
							            menu_a.removeClass('active');
							            menu_ul.filter(':visible').slideUp('normal');
							            $(this).addClass('active').next().stop(true,true).slideDown('normal');
							        } else {
							            $(this).removeClass('active');
							            $(this).next().stop(true,true).slideUp('normal');
							        }
							    });
							
							});
						</script>
<!--//menu-->
<!--seller-->
				<div class="product-bottom">
						<h3 class="cate">Best Sellers</h3>
					<div class="product-go">
						<div class=" fashion-grid">
							<a href="single.html"><img class="img-responsive " src="images/pr.jpg" alt=""></a>	
						</div>
						<div class=" fashion-grid1">
							<h6 class="best2"><a href="single.html" >Lorem ipsum dolor sitamet consectetuer  </a></h6>
							<span class=" price-in1"> $40.00</span>
						</div>	
						<div class="clearfix"> </div>
					</div>
					<div class="product-go">
						<div class=" fashion-grid">
							<a href="single.html"><img class="img-responsive " src="images/pr1.jpg" alt=""></a>	
						</div>
						<div class=" fashion-grid1">
							<h6 class="best2"><a href="single.html" >Lorem ipsum dolor sitamet consectetuer  </a></h6>
							<span class=" price-in1"> $40.00</span>
						</div>	
						<div class="clearfix"> </div>
					</div>
					<div class="product-go">
						<div class=" fashion-grid">
							<a href="single.html"><img class="img-responsive " src="images/pr2.jpg" alt=""></a>	
						</div>
						<div class=" fashion-grid1">
							<h6 class="best2"><a href="single.html" >Lorem ipsum dolor sitamet consectetuer  </a></h6>
							<span class=" price-in1"> $40.00</span>
						</div>	
						<div class="clearfix"> </div>
					</div>	
					<div class="product-go">
						<div class=" fashion-grid">
							<a href="single.html"><img class="img-responsive " src="images/pr3.jpg" alt=""></a>	
						</div>
						<div class=" fashion-grid1">
							<h6 class="best2"><a href="single.html" >Lorem ipsum dolor sitamet consectetuer  </a></h6>
							<span class=" price-in1"> $40.00</span>
						</div>	
						<div class="clearfix"> </div>
					</div>		
				</div>

<!--//seller-->
<!--tag-->
				<div class="tag">	
						<h3 class="cate">Tags</h3>
					<div class="tags">
						<ul>
							<li><a href="#">design</a></li>
							<li><a href="#">fashion</a></li>
							<li><a href="#">lorem</a></li>
							<li><a href="#">dress</a></li>
							<li><a href="#">fashion</a></li>
							<li><a href="#">dress</a></li>
							<li><a href="#">design</a></li>
							<li><a href="#">dress</a></li>
							<li><a href="#">design</a></li>
							<li><a href="#">fashion</a></li>
							<li><a href="#">lorem</a></li>
							<li><a href="#">dress</a></li>
						<div class="clearfix"> </div>
						</ul>
				</div>					
			</div>
		</div>
		<div class="clearfix"> </div>
	</div>
</div>
<!--footer-->
<div class="footer">
	<div class="container">
		<div class="footer-top">
			<div class="col-md-8 top-footer">
				<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d83998.91163207516!2d2.3470599!3d48.85885894999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47e66e1f06e2b70f%3A0x40b82c3688c9460!2sParis%2C+France!5e0!3m2!1sen!2sin!4v1436340519910" allowfullscreen=""></iframe>
			</div>
			<div class="col-md-4 top-footer1">
				<h2>Newsletter</h2>
						<input type="text" value="" onfocus="this.value='';" onblur="if (this.value == '') {this.value ='';}">
						<input type="submit" value="SUBSCRIBE">
					</div>
			<div class="clearfix"> </div>	
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
						<li> ut,DUI.</li>
						<li>nisi, dignissim</li>
						<li>gravida at.</li>
						<li class="phone">PH : 6985792466</li>
					</ul>
				</div>
				<div class="clearfix"> </div>
				<p class="footer-class"> © 2015 Fashion Mania. All Rights Reserved | Design by <a href="http://w3layouts.com/" target="_blank">W3layouts</a> </p>
			</div>
	</div>
</div>
<!-- slide -->
<script src="js/jquery.min.js"></script>
<script src="js/imagezoom.js"></script>
<!-- start menu -->
<link href="css/memenu.css" rel="stylesheet" type="text/css" media="all" />
<script type="text/javascript" src="js/memenu.js"></script>
<script>$(document).ready(function(){$(".memenu").memenu();});</script>
<script src="js/simpleCart.min.js"> </script>
<!--initiate accordion-->
						<script type="text/javascript">
							$(function() {
							    var menu_ul = $('.menu-drop > li > ul'),
							           menu_a  = $('.menu-drop > li > a');
							    menu_ul.hide();
							    menu_a.click(function(e) {
							        e.preventDefault();
							        if(!$(this).hasClass('active')) {
							            menu_a.removeClass('active');
							            menu_ul.filter(':visible').slideUp('normal');
							            $(this).addClass('active').next().stop(true,true).slideDown('normal');
							        } else {
							            $(this).removeClass('active');
							            $(this).next().stop(true,true).slideUp('normal');
							        }
							    });
							
							});
						</script>
						<!-- FlexSlider -->
  <script defer src="js/jquery.flexslider.js"></script>
<link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" />

<script>
// Can also be used with $(document).ready()
$(window).load(function() {
  $('.flexslider').flexslider({
    animation: "slide",
    controlNav: "thumbnails"
  });
});
</script>
<!---pop-up-box---->
					<link href="css/popuo-box.css" rel="stylesheet" type="text/css" media="all"/>
					<script src="js/jquery.magnific-popup.js" type="text/javascript"></script>
					<!---//pop-up-box---->
					 <script>
						$(document).ready(function() {
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