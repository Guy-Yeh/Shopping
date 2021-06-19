<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="manageraccount.aspx.cs" Inherits="Shopping.manageraccount" %>

<!--A Design by W3layouts 
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html>
<head >
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
					
                        <asp:Label ID="helpSQL" runat="server" Text="helpSQL" Visible="False"></asp:Label>
					
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
                                                <asp:TextBox ID="TextBox3" runat="server" placeholder="輸入4-10個位元內中英文"></asp:TextBox></li>
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
                                                <asp:Label ID="hintPicture" runat="server" ForeColor="Black" Text="非必選"></asp:Label></li>
                                            <li>
                                                <asp:Button ID="Add" runat="server" OnClick="Button1_Click" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClientClick="javascript:if(!window.confirm('確定要新增嗎?')) window.event.returnValue=false;" /></li>
                                            <br>
                                            <br>
                                            <asp:GridView ID="useraccount" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" OnRowDeleting="useraccount_RowDeleting" OnRowCancelingEdit="useraccount_RowCancelingEdit" OnRowEditing="useraccount_RowEditing" OnRowUpdating="useraccount_RowUpdating" AllowPaging="True"  HorizontalAlign ="center" OnPageIndexChanging="useraccount_PageIndexChanging" PagerStyle-HorizontalAlign="NotSet" >
                                               <PagerStyle  ForeColor="Black" HorizontalAlign="Center" />  
                                                <Columns>
                                                    <asp:TemplateField HeaderText="image" ItemStyle-HorizontalAlign="Center">
                                                        <EditItemTemplate>
                                                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("picture") %>' Enabled="False" EnableViewState="True" Visible="False"></asp:TextBox>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Image ID="Image1" runat="server" Height="120px" ImageUrl='<%# Eval("picture") %>' Width="100px" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                                                    <asp:BoundField DataField="showpicture" HeaderText="picture" SortExpression="showpicture" Visible="False" ReadOnly="True" />
                                                    <asp:BoundField DataField="account" HeaderText="account" SortExpression="account" Visible="True" ReadOnly="True" />
                                                    <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" Visible="True" ReadOnly="True" />
                                                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" Visible="True" ReadOnly="True" />
                                                    <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" Visible="True" ReadOnly="True" />
                                                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" Visible="True" ReadOnly="True" />
                                                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" Visible="True" ReadOnly="True" />                                                     
                                                    <asp:BoundField DataField="discount" HeaderText="discount" SortExpression="discount" Visible="True" ReadOnly="True" />
                                                    <asp:TemplateField HeaderText="access" SortExpression="access">
                                                        <EditItemTemplate>
                                                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("access") %>'></asp:TextBox>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("access") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="initdate" HeaderText="initdate" SortExpression="initdate" Visible="True" ReadOnly="True" />
                                                    <asp:TemplateField HeaderText="revise" ShowHeader="False">
                                                        <EditItemTemplate>
                                                            <asp:LinkButton ID="Update" runat="server" CausesValidation="True" CommandName="Update" Text="更新" OnClientClick='return confirm("確定更新?")'></asp:LinkButton>
                                                            <asp:LinkButton ID="Cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="Edit" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯"></asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="delete" ShowHeader="False">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除" OnClientClick='return confirm("確定刪除?")'></asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>
                                                <asp:SqlDataSource ID="SqlDataSourceCustomer" runat="server" ConnectionString="<%$ ConnectionStrings:CustomersConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>Delete or Search User Account</h4>
                                        <ul>
                                            <li>
                                                <asp:Label ID="accountD" runat="server" Text="account"></asp:Label></li>
                                            <li>
                                                <asp:TextBox ID="TextBox6" runat="server" placeholder="輸入即將刪除的account"></asp:TextBox></li>
                                            <li>
                                                <%--<asp:DropDownList ID="DDLDeleteAccount" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px" >
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList>--%>
                                                <asp:SqlDataSource ID="SqlDataSourceAccount" runat="server" ConnectionString="<%$ ConnectionStrings:CustomersConnectionString %>" SelectCommand="SELECT account FROM Customers ORDER BY account"></asp:SqlDataSource>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintID" runat="server" Text=""></asp:Label></li>                                            
                                            <li>
                                                <asp:Button ID="Delete" runat="server" OnClick="Button2_Click" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClientClick="javascript:if(!window.confirm('確定要刪除?')) window.event.returnValue=false;" /></li>
                                            <br>
                                            <br>
                                            
                                             <li>
                                                <asp:Label ID="accountS" runat="server" Text="account"></asp:Label></li>
                                             <li>
                                                <asp:TextBox ID="TextBox7" runat="server" placeholder="輸入即將搜尋的account"></asp:TextBox></li>
                                            <li>
                                                <%--<asp:DropDownList ID="DDLSearchAccount" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px" >
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList>--%>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintIDS" runat="server" Text=""></asp:Label></li>                                            
                                            <li>
                                                <asp:Button ID="Search" runat="server" OnClick="Button4_Click" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add"/></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>Update User Account</h4>
                                        <ul>
                                            <li>
                                                <asp:Label ID="accountU" runat="server" Text="account"></asp:Label></li>
                                            <li><asp:TextBox ID="TextBox8" runat="server" placeholder="輸入即將更新的account"></asp:TextBox></li>
                                            <li>
                                                <%--<asp:DropDownList ID="DDLUpdateAccount" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px" >
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList></asp:DropDownList></li>--%>
                                            <li>
                                                <asp:Label ID="hintID2" runat="server" Text=""></asp:Label><li>
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
