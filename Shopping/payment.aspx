<%@ Page Title="payment" Language="C#"  AutoEventWireup="true" CodeBehind="payment.aspx.cs" Inherits="Shopping.payment" %>

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
    <style type="text/css">
        .auto-style1 {
            height: 42px;
        }
        .auto-style2 {
            width: 204px;
        }
        .auto-style3 {
            width: 60%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
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
					<p class="log"><a href="account.html">登錄</a> <a href="account.html">註冊</a></p>
					<div class="cart box_1">
						<a href="shoppingcar">
						<h3> <div class="total">
							<span class="simpleCart_total"></span></div>
							<img src="images/cart.png" alt=""/></h3>
						</a>
						<p><a href="javascript:;" class="simpleCart_empty">Empty Cart</a></p>

					</div>
					<div class="clearfix"> </div>
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
        <div class="container">
	        <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>   
            <asp:TextBox ID="TextBox1" runat="server" style="float:right"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="收件人姓名" ForeColor="#52D0C4" style="float:right"></asp:Label><br><br>

            <asp:TextBox ID="TextBox2" runat="server" style="float:right"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="收件人地址" ForeColor="#52D0C4" style="float:right"></asp:Label><br><br>
            
            <asp:TextBox ID="TextBox3" runat="server" style="float:right"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="收件人電話" ForeColor="#52D0C4" style="float:right"></asp:Label><br><br>
            <asp:Button ID="Button1" runat="server" Text="確認" BackColor="#52D0C4" BorderStyle="None" ForeColor="White" style="float:right" OnClick="Button1_Click"/>
        </div>
                <div class="col-sm-2 number">

				</div>
           


    </form>
