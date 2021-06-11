<%@ Page Title="shoppingcar" Language="C#"  AutoEventWireup="true" CodeBehind="shoppingcar.aspx.cs" Inherits="Shopping.shoppingcar" %>

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
    <form id="form1" runat="server">
<!--header-->
<div class="header">
	<div class="header-top">
		<div class="container">
		<div class="col-sm-4 number">
					<span><i class="glyphicon glyphicon-phone"></i>0</span>2-2424-0000<br>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
				</div>
				<div class="col-sm-4 logo">
					<a href="index"><img src="images/logo.png" alt=""></a>	
				</div>
		
			<div class="col-sm-4 header-left">		
					<p class="log"><a href="account.html">登錄</a> <a href="account.html">註冊</a></p>
					<asp:Label ID="Label1" runat="server" Text="消費金額：" ></asp:Label>
				    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/cart.png" style="float:right" OnClick="ImageButton1_Click" /><br>
                    <asp:Button ID="Button1" runat="server" Text="清空購物車" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="87px" style="float:right" OnClick="Button1_Click" />

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


<!--//header-->
<!---->
<div class="container">
	<div class="check-out">   	
        <asp:GridView ID="userorder" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowDeleting="userorder_RowDeleting" DataKeyNames="ID">
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("productPicture") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Height="120px" ImageUrl='<%# Eval("productPicture") %>' Width="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="productPicture" HeaderText="productPicture" SortExpression="productPicture" Visible="False" />
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="productName" HeaderText="productName" SortExpression="productName" />
                <asp:BoundField DataField="productColor" HeaderText="productColor" SortExpression="productColor" />
                <asp:BoundField DataField="productPrice" HeaderText="productPrice" SortExpression="productPrice" />
                <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
                <asp:TemplateField HeaderText="刪除" ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OrderDetailConnectionString %>" SelectCommand="SELECT [productName], [productColor], [productPrice], [qty], [productPicture], [ID] FROM [OrderDetail] WHERE (([customerAccount] = @customerAccount) AND ([cart] = @cart))">
            <SelectParameters>
                <asp:SessionParameter Name="customerAccount" SessionField="loginstatus" Type="String" />
                <asp:Parameter DefaultValue="是" Name="cart" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Label ID="Label4" runat="server" Text="Label" style="float:right" ForeColor="#52D0C4" Font-Size="X-Large"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="總金額：" style="float:right" ForeColor="#52D0C4" Font-Size="X-Large"></asp:Label><br><br>
        <asp:Button ID="Button2" runat="server" Text="確認購買" OnClick="Button2_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" style="float:right" Font-Size="X-Large" BorderStyle="None"/>
	<div class="clearfix"> </div>
    </div>
</div>
<!--footer-->
<div class="footer">
	<div class="container">
		<div class="footer-top">
			<div class="col-md-8 top-footer">
				<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d83998.91163207516!2d2.3470599!3d48.85885894999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47e66e1f06e2b70f%3A0x40b82c3688c9460!2sParis%2C+France!5e0!3m2!1sen!2sin!4v1436340519910" ></iframe>
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

<!--//footer-->
    </form>
</body>
</html>