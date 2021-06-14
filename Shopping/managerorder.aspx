<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="managerorder.aspx.cs" Inherits="Shopping.managerorder" %>
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
		function ConfirmMe()
		{
			if (Page_ClientValidate())
			{
				return confirm('確定送出嗎?');
			}
			else
			{
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
					<ul >
						
					</ul>
				</div>
				<div class="col-md-4 logo">
					<a href="index.html"><img src="images/CAT4.png" alt=""></a>	
				</div>
		
			<div class="col-md-4 header-left">		
					<p class="log"><a href="account.html"  >Login</a>
						<span>or</span><a  href="account.html"  >Signup</a></p>
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
					<span><i class="glyphicon glyphicon-phone"></i>085 596 234</span>
				</div>
		  <div class="col-md-8 h_menu4">
				<ul class="memenu skyblue">
					  <li><a  href="managerhome">首頁</a></li>	
				      <li><a  href="manageraccount">帳戶</a>
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
				    <li class="grid"><a  href="managerproduct">產品</a>
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
				<li><a  href="managerorder">訂單</a></li>				
				<li><a class="color6" href="managercontact">回覆訊息</a></li>
			  </ul> 
			</div>
				<div class="col-md-2 search">		
			<a class="play-icon popup-with-zoom-anim" href="#small-dialog"><i class="glyphicon glyphicon-search"> </i> </a>
		</div>

					<br>
			<br>
			<br>
			
			<h3><li>Revise Order Table</li></h3>
					  	<div class="mepanel">
						<div class="row">
							<div class="col1">
								<div class="h_nav">	
									<h4>Search Order Information</h4>
									<ul>
										<li><asp:Label ID="serial" runat="server" Text="serial"></asp:Label></li>
                                        <li><asp:DropDownList ID="DDLSS" runat="server" AppendDataBoundItems="True" Height="30px" Width="195px"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList></asp:DropDownList><li>
										<li><asp:Label ID="hintSerial" runat="server" Text="" ></asp:Label></li> 
										<li><asp:Button ID="serialSearch" runat="server" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="serialSearch_Click"/></li>
										<br>
										<li><asp:Label ID="customerAccount" runat="server" Text="customerAccount"></asp:Label></li>
										<li>
                                            <asp:DropDownList ID="DDLSearchCustomerAccount" runat="server" AppendDataBoundItems="True" Width="195px" Height="30px"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceCustomerAccount" runat="server" ConnectionString="<%$ ConnectionStrings:CustomersConnectionString %>" SelectCommand="SELECT [account] FROM [Customers]"></asp:SqlDataSource>
                                        </li>
										<li><asp:Label ID="hintCustomerAccount" runat="server" Text=""></asp:Label></li>
										<li><asp:Button ID="customerAccountsearch" runat="server" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="customerAccountsearch_Click"/></li>
										<br>
										<li><asp:Label ID="productName" runat="server" Text="productName"></asp:Label></li>
										<li><asp:DropDownList ID="DDLSearchProductName" runat="server" AppendDataBoundItems="True"  Height="30px" Width="195px"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceProductName" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT DISTINCT productName FROM Products"></asp:SqlDataSource>
                                        </li>
										<li><asp:Label ID="hintProductName" runat="server" Text=""></asp:Label></li>
										<li><asp:Button ID="productNamesearch" runat="server" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="productNamesearch_Click"/></li>
										<br>
										<li><asp:Label ID="name" runat="server" Text="name"></asp:Label></li>
										<li>
                                            <asp:DropDownList ID="DDLSearchName" runat="server" AppendDataBoundItems="True"  Height="30px" Width="195px"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceSearchName" runat="server" ConnectionString="<%$ ConnectionStrings:OrdersConnectionString %>" SelectCommand="SELECT DISTINCT name FROM Orders"></asp:SqlDataSource>
                                        </li>
										<li><asp:Label ID="hintName" runat="server" Text=""></asp:Label></li>
										<li><asp:Button ID="namesearch" runat="server" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="namesearch_Click"/></li>
										<br>
										<li><asp:Label ID="status" runat="server" Text="status"></asp:Label></li>
										<li><asp:DropDownList ID="DDLSearchStatus" runat="server" AppendDataBoundItems="True"  Height="30px" Width="195px"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceOrdersStatus" runat="server" ConnectionString="<%$ ConnectionStrings:OrdersStatusConnectionString %>" SelectCommand="SELECT [Cols] FROM [OrdersStatus]"></asp:SqlDataSource>
                                        </li>
										<li><asp:Label ID="hintStatus" runat="server" Text="" ></asp:Label></li>
										<li><asp:Button ID="statussearch" runat="server" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="statussearch_Click"/></li>
									<br>
									<br>

				<asp:GridView ID="userorder" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" >
                <Columns>
                    <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="ID">
                        <EditItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="serial" SortExpression="serial">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("serial") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("serial") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="productName" SortExpression="productName">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("productName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("productName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="productColor" SortExpression="productColor">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("productColor") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("productColor") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="productPicture" SortExpression="productPicture" Visible="False">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("productPicture") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("productPicture") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="image" SortExpression="productPicture">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="120px" Width="100px" ImageUrl='<%#Eval("productPicture") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="productPrice" SortExpression="productPrice">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("productPrice") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("productPrice") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="qty" SortExpression="qty">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("qty") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%# Bind("qty") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="customerAccount" SortExpression="customerAccount">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("customerAccount") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label8" runat="server" Text='<%# Bind("customerAccount") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="name" SortExpression="name">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label9" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="phone" SortExpression="phone">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox10" runat="server" Text='<%# Bind("phone") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label10" runat="server" Text='<%# Bind("phone") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="address" SortExpression="address">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("address") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label11" runat="server" Text='<%# Bind("address") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="status" SortExpression="status">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox12" runat="server" Text='<%# Bind("status") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label12" runat="server" Text='<%# Bind("status") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="initdate" HeaderText="initdate" SortExpression="initdate" />
					<asp:BoundField DataField="upInitdate" HeaderText="upInitdate" SortExpression="upInitdate" />
                </Columns>
            </asp:GridView>
									</ul>	
								</div>							
							</div>
							<div class="col1">
								<div class="h_nav">
									<h4>Delete Order Information</h4>
									<ul>
										<li><asp:Label ID="orderID" runat="server" Text="orderSerial"></asp:Label></li>
										<li><asp:DropDownList ID="DDLDeleteOrderID" runat="server"  AppendDataBoundItems="True"  Width="195px" Height="30px" ><asp:ListItem Value="delete">請選擇</asp:ListItem></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceOrderSerial" runat="server" ConnectionString="<%$ ConnectionStrings:OrdersConnectionString %>" SelectCommand="SELECT [serial] FROM [Orders]"></asp:SqlDataSource>
                                        </li>
										<li><asp:Label ID="hintID" runat="server" Text="選擇即將刪除的orderSerial"></asp:Label></li>
										<br>
										<li><asp:Button ID="Delete" runat="server" OnClick="Button2_Click" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" onClientclick = "javascript:if(!window.confirm('確定要刪除嗎?')) window.event.returnValue=false;"/></li>
										
									</ul>
								</div>							
							</div>
							<div class="col1">
								<div class="h_nav">
									<h4>Update Order Information</h4>
									<ul>
										<li><asp:Label ID="orderID2" runat="server" Text="orderDetailID"></asp:Label></li>
										<li><asp:DropDownList ID="DDLUpdateOrderDetailID" runat="server" AppendDataBoundItems="True" Height="30px" Width="195px" ><asp:ListItem Value="delete">請選擇</asp:ListItem></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceOrderDetailSearch" runat="server" ConnectionString="<%$ ConnectionStrings:OrderDetailConnectionString %>" SelectCommand="SELECT ID FROM Orderdetail WHERE (cart = N'否')"></asp:SqlDataSource>
                                        </li>
										<li><asp:Label ID="hintID2" runat="server" Text="選擇即將更新的orderDetailID"></asp:Label><li>
										<br>
										<li><asp:Label ID="column" runat="server" Text="column"></asp:Label></li>
										<li><asp:DropDownList ID="DDLUpdateOrderCols" runat="server" AppendDataBoundItems="True" Height="30px" Width="195px"><asp:ListItem Value="delete">請選擇</asp:ListItem></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceOrderCols" runat="server" ConnectionString="<%$ ConnectionStrings:OrdersColsConnectionString %>" SelectCommand="SELECT [Cols] FROM [OrdersCols]"></asp:SqlDataSource>
                                        </li>
										<li><asp:Label ID="hintColumn" runat="server" Text="選擇即將更新的欄位"></asp:Label></li>
										<br>
										<li><asp:Label ID="value" runat="server" Text="update value"></asp:Label></li>
										<li><asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></li>
										<li><asp:Label ID="hintAll" runat="server" Text="輸入更新的值"></asp:Label></li>
										<br>
										<li><asp:Button ID="Update" runat="server" Text="submit" OnClick="Button3_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" onClientclick= "javascript:if(!window.confirm('確定要修改嗎?')) window.event.returnValue=false"/>
                                            
                                        </li>
									</ul>	
								</div>												
							</div>
						  </div>

						</div>
				
				
			
		<div class="clearfix"> 

                <asp:SqlDataSource ID="SqlDataSourceAllorders" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingConnectionString %>" SelectCommand="SELECT a.ID, a.serial, a.productName, a.productColor, a.productPicture, a.productPrice, a.qty, a.customerAccount, b.name, b.phone, b.address, b.status, b.initdate FROM OrderDetail AS a INNER JOIN Orders AS b ON a.serial = b.serial"></asp:SqlDataSource>
            
                <asp:SqlDataSource ID="SqlDataSourceAllOrders2" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingConnectionString %>" SelectCommand="SELECT a.ID, a.serial, a.productName, a.productColor, a.productPicture, a.productPrice, a.qty, b.name, b.phone, b.address, b.status, b.initdate FROM OrderDetail AS a INNER JOIN Orders AS b ON a.serial = b.serial"></asp:SqlDataSource>
            
                </div>
				<div id="small-dialog" class="mfp-hide">
				<div class="search-top">
						<div class="login">
							<input type="submit" value="">
							<input type="text" value="Type something..." onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}">		
						</div>
						<p>	Shopping</p>
					</div>				
				</div>		
	<!---->		
		</div>
	</div>
</div>
<!---->
<div class="single">

<div class="container">

<!----->

		
	</div>
	</div>
<!--footer-->
<div class="footer">
	<div class="container">
		<div class="footer-top">
			<div class="col-md-8 top-footer">
				<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7659.912326510472!2d121.56070378360901!3d25.03417107027919!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442abb6da80a7ad%3A0xacc4d11dc963103c!2z5Y-w5YyXMTAx!5e0!3m2!1szh-TW!2stw!4v1623592494222!5m2!1szh-TW!2stw" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
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