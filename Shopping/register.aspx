﻿<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Shopping.register" %>

<!--A Design by W3layouts 
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->

<!DOCTYPE html >
<html>
<head>
<title>丹丹服飾 : : 註冊</title>
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
<form id="Form1" runat="server" method="post"> 
<!--header-->
<div class="header">
	<div class="header-top">
		<div class="container">
		<div class="col-md-4 world">
						
				</div>
				<div class="col-md-4 logo">
					<a href="index.aspx"><img src="images/CAT4.png" alt=""></a>	
				</div>
		
			<div class="col-md-4 header-left">		
					<p class="log">
						<asp:LinkButton ID="loginLinkButton" runat="server" OnClick="loginLinkButton_Click">登入</asp:LinkButton>或
						<asp:LinkButton ID="registerLinkButton" runat="server" OnClick="registerLinkButton_Click">註冊</asp:LinkButton>
					

					</div>
					<div class="clearfix"> </div>
			
				<div class="clearfix"> </div>
		</div>
		</div>
		<div class="container">
			<div class="head-top">
				<div class="col-md-2 number">
                    
					
				</div>
		  <div class="col-md-8 h_menu4">
				<ul class="memenu skyblue">
					  
				      
				    
						
				
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
<div class="container">
	<div class="register">
		<h1><span style="font-family:Microsoft JhengHei;">註冊</span></h1>
		  	  
				 <div class="col-md-6  register-top-grid">
					
					<div class="mation">
						<asp:Label ID="account" runat="server" Text="帳號"></asp:Label>
						<asp:TextBox ID="accountText" runat="server" placeholder="請輸入6-15字元英文數字"></asp:TextBox>
						<asp:Label ID="password" runat="server" Text="密碼"></asp:Label>
						<asp:TextBox ID="passwordText" runat="server" placeholder="請輸入7-20字元英文數字" BorderColor="#E7E7E7" BorderStyle="Solid" BorderWidth="1px" Height="36px" TextMode="Password" Width="100%"></asp:TextBox>
						<asp:Label ID="passwordCheck" runat="server" Text="確認密碼" ></asp:Label>
						<asp:TextBox ID="passwordCheckText" runat="server" placeholder="請重複輸入您的密碼" BorderColor="#E7E7E7" BorderStyle="Solid" BorderWidth="1px" Height="36px" TextMode="Password" Width="100%"></asp:TextBox>
&nbsp;</div>
					 <div class="clearfix"> </div>
					 
					   <a class="news-letter" href="#">
                         <asp:CheckBox ID="logingcheck" runat="server" Text="註冊後登入"  />
						 
					   </a>
					 </div>
				     <div class=" col-md-6 register-bottom-grid">
						   
							<div class="mation">
								
								<asp:Label ID="name" runat="server" Text="姓名"></asp:Label>
								<asp:TextBox ID="nameText" runat="server" placeholder="請輸中英文名字合計4-10字元"></asp:TextBox>
																				
								<asp:Label ID="phone" runat="server" Text="手機"></asp:Label>
								<asp:TextBox ID="phoneText" runat="server" placeholder="請輸入含09開頭十位數字號碼"></asp:TextBox>
					 
								<asp:Label ID="email" runat="server" Text="信箱"></asp:Label>
								<asp:TextBox ID="emailText" runat="server" placeholder="請輸入有效電子信箱"></asp:TextBox>

								<asp:Label ID="address" runat="server" Text="地址"></asp:Label>
								<asp:TextBox ID="addressText" runat="server" placeholder="請輸入有效地址"></asp:TextBox>

							</div>
					 </div>
					 <div class="clearfix"> </div>
				
				
				<div class="register-but">
					
					<asp:TextBox ID="verificationText" runat="server" ></asp:TextBox>
					<asp:Image ID="verificationImage" imageUrl=~\verification.aspx runat="server"  />
					<asp:LinkButton ID="verificationLinkButton1" runat="server" style="font-size: small; ">看不清楚，換一張</asp:LinkButton>
					<br>
					<br>
                    <asp:Button ID="registerButton" runat="server" Text="確認" OnClick="registerButton_Click" Style="font: 12pt Verdana;font-weight:700;color:white;" BorderStyle="None" BackColor="#52D0C4" Height="35px" Width="59px"  />					   
				   
				    <asp:Label ID="errorText" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
				   
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

<!--//footer-->
</form>
</body>
</html>