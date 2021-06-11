<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Shopping.index" %>
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
<script>$(document).ready(function(){$(".memenu").memenu();});</script>
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
				   <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
			    <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Button" />
			</div>
			<div class="col-sm-4 logo">
				<a href="index"><img src="images/logo.png" alt=""></a>	
			</div>
		
			<div class="col-sm-4 header-left">		
				<p class="log">
					<a href="account.html">登錄</a><br>
					<a href="account.html">註冊</a>

				</p>
				<asp:Label ID="Label1" runat="server" Text="消費金額：" ></asp:Label>
				<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/cart.png" style="float:right" OnClick="ImageButton1_Click" /><br>
                <asp:Button ID="Button9" runat="server" Text="清空購物車" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="87px" style="float:right" OnClick="Button9_Click"/>
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
	<!---->		
		</div>
	</div>
</div>
<!--banner-->
<div class="banner">
	<div class="col-sm-3 banner-mat">
		<img class="img-responsive"	src="images\衣服\281901701-領造型線T\S__77931623.jpg" alt="">
	</div>
	<div class="col-sm-6 matter-banner">
	 	<div class="slider">
	    	<div class="callbacks_container">
	      		<ul class="rslides" id="slider">
	        		<li>
	          			<img src="images\衣服\281901715-剪裁T\S__49840159.jpg" alt="">
	       			 </li>
			 		 <li>
	          			<img src="images\衣服\281901801-細肩露肩t\S__49840130.jpg" alt="">   
	       			 </li>
					 <li>
	          			<img src="images\衣服\281902805-胸抓摺衫\S__49954893.jpg" alt="">
	        		</li>	
	      		</ul>
	 	 	</div>
		</div>
	</div>
	<div class="col-sm-3 banner-mat">
		<img class="img-responsive" src="images\衣服\281901708-袖滾配色t\S__77931217.jpg" alt="">
	</div>
	<div class="clearfix"> </div>
</div>
<!--//banner-->
<!--content-->
<div class="content">
	<div class="container">
		<div class="content-top">
			<h1>最新產品</h1>
			<div class="content-top1">
				<div class="col-md-3 col-md2">
					<div class="col-md1 simpleCart_shelfItem">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images\衣服\281901701-領造型線T\S__49610819.jpg" Height="100%" Width="100%" OnClick="ImageButton2_Click" />						
						<div class="price">
								<asp:Label ID="Label2" runat="server" Text="售價："></asp:Label>
								<asp:Label ID="Label3" runat="server" Text="900"></asp:Label><br>
								<asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>白</asp:ListItem>
                                    <asp:ListItem>綠</asp:ListItem>
                                    <asp:ListItem>紅</asp:ListItem>
                                </asp:DropDownList>
								<asp:Button ID="Button1" runat="server" Text="放入購物車" OnClick="Button1_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" style="float:right"/>
								<div class="clearfix"> </div>
						</div>
					</div>
				</div>	
				<div class="col-md-3 col-md2">
					<div class="col-md1 simpleCart_shelfItem">
							<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images\衣服\281901708-袖滾配色t\S__49840211.jpg" Height="100%" Width="100%" OnClick="ImageButton3_Click" />
						<div class="price">
								<asp:Label ID="Label4" runat="server" Text="售價："></asp:Label>
								<asp:Label ID="Label5" runat="server" Text="950"></asp:Label><br>
								<asp:DropDownList ID="DropDownList2" runat="server">
									<asp:ListItem>白</asp:ListItem>
									<asp:ListItem>綠</asp:ListItem>
                                    <asp:ListItem>橘</asp:ListItem>
                                    <asp:ListItem>黑</asp:ListItem>
                                </asp:DropDownList>
								<asp:Button ID="Button2" runat="server" Text="放入購物車" OnClick="Button2_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" style="float:right" />
								<div class="clearfix"> </div>
						</div>
						
					</div>
				</div>	
				<div class="col-md-3 col-md2">
					<div class="col-md1 simpleCart_shelfItem">
							<asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/images\衣服\281901715-剪裁T\S__49840159.jpg" Height="100%" Width="100%" OnClick="ImageButton4_Click" />
						<div class="price">
								<asp:Label ID="Label6" runat="server" Text="售價："></asp:Label>
								<asp:Label ID="Label7" runat="server" Text="850"></asp:Label><br>
								<asp:DropDownList ID="DropDownList3" runat="server">
									<asp:ListItem>白</asp:ListItem>
									<asp:ListItem>灰</asp:ListItem>
                                    <asp:ListItem>杏</asp:ListItem>
                                    <asp:ListItem>咖啡</asp:ListItem>
                                    <asp:ListItem>黑</asp:ListItem>
                                </asp:DropDownList>
								<asp:Button ID="Button3" runat="server" Text="放入購物車" OnClick="Button3_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" style="float:right" />
								<div class="clearfix"> </div>
						</div>
						
					</div>
				</div>	
				<div class="col-md-3 col-md2">
					<div class="col-md1 simpleCart_shelfItem">
							<asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/images\衣服\281901801-細肩露肩t\S__49840130.jpg" Height="100%" Width="100%" OnClick="ImageButton5_Click" />
						<div class="price">
								<asp:Label ID="Label8" runat="server" Text="售價："></asp:Label>
								<asp:Label ID="Label9" runat="server" Text="1000"></asp:Label><br>
								<asp:DropDownList ID="DropDownList4" runat="server">
									<asp:ListItem>白</asp:ListItem>
									<asp:ListItem>綠</asp:ListItem>
                                    <asp:ListItem>紅</asp:ListItem>
                                    <asp:ListItem>黑</asp:ListItem>
                                </asp:DropDownList>
								<asp:Button ID="Button4" runat="server" Text="放入購物車" OnClick="Button4_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" style="float:right" />
								<div class="clearfix"> </div>
						</div>						
					</div>
				</div>	
				<div class="clearfix"> </div>
			</div>
			<div class="content-top1">
				<div class="col-md-3 col-md2">
					<div class="col-md1 simpleCart_shelfItem">
							<asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/images\衣服\281902805-胸抓摺衫\S__49954893.jpg" Height="100%" Width="100%" OnClick="ImageButton6_Click" />
						<div class="price">
								<asp:Label ID="Label10" runat="server" Text="售價："></asp:Label>
								<asp:Label ID="Label11" runat="server" Text="980"></asp:Label><br>
								<asp:DropDownList ID="DropDownList5" runat="server">
									<asp:ListItem>灰</asp:ListItem>
									<asp:ListItem>黑</asp:ListItem>
                                    <asp:ListItem>粉</asp:ListItem>
                                </asp:DropDownList>
								<asp:Button ID="Button5" runat="server" Text="放入購物車" OnClick="Button5_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" style="float:right"/>
								<div class="clearfix"> </div>
						</div>
						
					</div>
				</div>	
				<div class="col-md-3 col-md2">
					<div class="col-md1 simpleCart_shelfItem">
							<asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/images\衣服\281904506-格紋澎袖衫\S__49954861.jpg" Height="100%" Width="100%" OnClick="ImageButton7_Click" />
						<div class="price">
								<asp:Label ID="Label12" runat="server" Text="售價："></asp:Label>
								<asp:Label ID="Label13" runat="server" Text="790"></asp:Label><br>
								<asp:DropDownList ID="DropDownList6" runat="server">
									<asp:ListItem>黑</asp:ListItem>
									<asp:ListItem>紅</asp:ListItem>
                                </asp:DropDownList>
								<asp:Button ID="Button6" runat="server" Text="放入購物車" OnClick="Button6_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" style="float:right" />
								<div class="clearfix"> </div>
						</div>
						
					</div>
				</div>	
				<div class="col-md-3 col-md2">
					<div class="col-md1 simpleCart_shelfItem">
							<asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/images\衣服\281906305-中抓摺雪紡衫\S__50069542.jpg" Height="100%" Width="100%" OnClick="ImageButton8_Click" />
						<div class="price">
								<asp:Label ID="Label14" runat="server" Text="售價："></asp:Label>
								<asp:Label ID="Label15" runat="server" Text="980"></asp:Label><br>
								<asp:DropDownList ID="DropDownList7" runat="server">
									<asp:ListItem>杏</asp:ListItem>
									<asp:ListItem>白</asp:ListItem>
                                    <asp:ListItem>紅</asp:ListItem>
                                </asp:DropDownList>
								
								<asp:Button ID="Button7" runat="server" Text="放入購物車" OnClick="Button7_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" style="float:right" />
								<div class="clearfix"> </div>
						</div>
						
					</div>
				</div>	
				<div class="col-md-3 col-md2">
					<div class="col-md1 simpleCart_shelfItem">
							<asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/images\衣服\281905801-滾邊寬袖衫\S__50200586.jpg" Height="100%" Width="100%" OnClick="ImageButton9_Click" />
						<div class="price">
								<asp:Label ID="Label16" runat="server" Text="售價："></asp:Label>
								<asp:Label ID="Label17" runat="server" Text="990"></asp:Label><br>
								<asp:DropDownList ID="DropDownList8" runat="server">
									<asp:ListItem>白</asp:ListItem>
									<asp:ListItem>粉</asp:ListItem>
                                    <asp:ListItem>黑</asp:ListItem>
                                </asp:DropDownList>
								<asp:Button ID="Button8" runat="server" Text="放入購物車" OnClick="Button8_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" style="float:right" />
								<div class="clearfix"> </div>
						</div>
						
					</div>
				</div>	
				<div class="clearfix"> </div>
			</div>	
		</div>
	</div>
</div>
</form>
<!--//content-->
<!--footer-->
<div class="footer">
	<div class="container">
		<div class="footer-top">
			<div class="col-md-8 top-footer">
				<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d83998.91163207516!2d2.3470599!3d48.85885894999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47e66e1f06e2b70f%3A0x40b82c3688c9460!2sParis%2C+France!5e0!3m2!1sen!2sin!4v1436340519910" allowfullscreen=""></iframe>
			</div>
			<div class="col-md-4 top-footer1">
				<h2>Newsletter</h2>
					<form>
						<input type="text" value="" onfocus="this.value='';" onblur="if (this.value == '') {this.value ='';}">
						<input type="submit" value="SUBSCRIBE">
					</form>
			</div>
			<div class="clearfix"> </div>	
		</div>	
	</div>
	<div class="footer-bottom">
		<div class="container">
				<div class="col-sm-3 footer-bottom-cate">
					<h6>Categories</h6>
					<ul>
						<li><a href="#">Curabitur sapien</a></li>
						<li><a href="#">Dignissim purus</a></li>
						<li><a href="#">Tempus pretium</a></li>
						<li><a href="#">Dignissim neque</a></li>
						<li><a href="#">Ornared id aliquet</a></li>
						
					</ul>
				</div>
				<div class="col-sm-3 footer-bottom-cate">
					<h6>Feature Projects</h6>
					<ul>
						<li><a href="#">Curabitur sapien</a></li>
						<li><a href="#">Dignissim purus</a></li>
						<li><a href="#">Tempus pretium</a></li>
						<li><a href="#">Dignissim neque</a></li>
						<li><a href="#">Ornared id aliquet</a></li>
						
					</ul>
				</div>
				<div class="col-sm-3 footer-bottom-cate">
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
				<div class="col-sm-3 footer-bottom-cate cate-bottom">
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

<!--//footer-->
</body>
</html>
