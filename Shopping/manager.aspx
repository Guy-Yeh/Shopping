<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="manager.aspx.cs" Inherits="Shopping.manager" %>
<!--A Design by W3layouts 
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html>
<head>
<title>Fashion Mania A Ecommerce Category Flat Bootstarp Resposive Website Template | Account :: w3layouts</title>
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
</head>
<body>
<form runat="server" method="post">
<!--header-->
<div class="header">
	<div class="header-top">
		<div class="container">
		<div class="col-md-4 number">
					
						
					
				</div>
				<div class="col-md-4 logo">
					<a href="index.html"><img src="images/CAT4.png" alt=""></a>	
				</div>
		
			<div class="col-md-4 header-left">		
					
					<div class="cart box_1">
						

					</div>
					<div class="clearfix"> </div>
			</div>
				<div class="clearfix"> </div>
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
                      <li><a href="managercontact">回覆訊息</a></li>
					  <li><a href="managershowpicture">主頁顯示</a></li>
			  </ul> 
			</div>
		<div class="col-md-2 search">		
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
<!--//header-->
<div class="account">
	<div class="container">
		<h1>管理者登入頁</h1>
		<div class="account_grid">
			   <div class="col-md-6 login-right">
				<form>

					<span>帳號</span>
				    <asp:TextBox ID="account" runat="server" Height="30px" Width="220px" required="required" aria-required="true" oninvalid="setCustomValidity('這是必填項目，請輸入')" oninput="this.setCustomValidity('')"></asp:TextBox>
					<br>
					<br>
					<span>密碼</span>
					<asp:TextBox ID="password" runat="server" required="required" aria-required="true" oninvalid="setCustomValidity('這是必填項目，請輸入')" TextMode="Password" oninput="this.setCustomValidity('')" Width="220" Height="30px"></asp:TextBox>
					<asp:Label ID="plabel" runat="server" Text=""></asp:Label>
					<br>
					<div class="word-in">
				  		
						<asp:Button ID="submit" runat="server" Text="送出" OnClick="submit_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add"/>
				  	</div>
			    </form>
			   </div>	
			    <div class="col-md-6 login-left">
			  	 <h4>提醒:</h4>
				 <p>透過使用本網站來管理您的線上購物商店，您將能夠更新並管理以下項目: <br>1.顧客帳戶&nbsp&nbsp2.商品項目&nbsp&nbsp3.訂單進度追蹤&nbsp&nbsp4.購物車資料蒐集&nbsp&nbsp5.顧客問題回覆</p>
				 
				 <h4>IT聯繫方式:</h4>
				 <p>如果有無法登入或操作上的問題麻煩聯繫以下窗口，感謝您的配合！
					 <li>Email: ITHelp@dandancloth.com</li>
					 <li>Phone: 02-2424-0000 ext.9595</li>
				 </p>
			   </div>
			   <div class="clearfix"> </div>
			 </div>
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
</form>
<!--//footer-->
</body>
</html>