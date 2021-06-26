<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="manageraccount.aspx.cs" Inherits="Shopping.manageraccount"  MaintainScrollPositionOnPostback="true"%>

<!--A Design by W3layouts 
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html>
<head>
    <title>丹丹服飾 : : 帳戶管理</title>
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

                        
					
                        <asp:Label ID="helpSQL" runat="server" Text="helpSQL" Visible="False"></asp:Label>

                    </div>
                    <div class="col-md-4 logo">
                        <a href="">
                            <img src="images/CAT4.png" alt=""></a>
                    </div>

                    <div class="col-md-4 header-left">
                        <p class="log">
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">登出</asp:LinkButton>
                        </p>
                        <div class="cart box_1">
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
           </div>
            <div class="container">
                <div class="head-top">
                    <div class="col-md-2 number">
                    </div>
                    <div class="col-md-8 h_menu4">
                        <ul class="memenu skyblue">
                            <li><a href="manageraccount">帳戶</a></li>
                            <li><a href="managerproduct">商品</a></li>
                            <li><a href="managerorder">訂單</a></li>
                            <li><a href="managershoppingcar">購物車</a></li>
                            <li><a href="managercontact">回覆訊息</a></li>
                            <li><a href="managershowpicture">主頁顯示</a></li>
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
                            <h1>帳號管理&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h1>
                        </div>
                        <br>

                        <div class="container">
                            <div class="row">
                                <div class="col-sm-4">
                                    <div class="h_nav">
                                        <h4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h4>
                                        <ul>
                                            
                                        </ul>
                                    </div>
                                </div>
                                <div class="col-sm-4">
                                    <div class="h_nav">
                                        <h4>查詢方式:使用者帳戶</h4>
                                        <ul>                                            
                                            <li>
                                                <asp:Label ID="accountS" runat="server" Text="帳號"></asp:Label></li>
                                            <li>
                                                <asp:TextBox ID="TextBox7" runat="server" placeholder="輸入搜尋的帳號"></asp:TextBox></li>
                                            <li>
                                                <%--<asp:DropDownList ID="DDLSearchAccount" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px" >
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                </asp:DropDownList>--%>
                                            </li>
                                            <li>
                                                <asp:Label ID="hintIDS" runat="server" Text=""></asp:Label></li>
                                            <li>
                                                <asp:Button ID="Search" runat="server" OnClick="Button4_Click" Text="送出" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" /></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col-sm-4">
                                    <div class="h_nav">
                                        <h4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h4>
                                        <ul>
                                            
                                        </ul>
                                    </div>
                                </div>                                
                            </div>
                        </div>
 
                        <div class="container">
                            <div class="row">
                                <div class="col-sm-9">
                                </div>
                                <div class="col-sm-2">
                                    <br>
                                    <asp:Button ID="all" runat="server" Text="查看所有" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="all_Click" Width="102px" Height="40" />
                                </div>
                            </div>
                        </div>

                        <div class="container">
                            <div class="row">
                                <div class="col-sm-12">
                                    <asp:GridView ID="useraccount" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" OnRowDeleting="useraccount_RowDeleting" OnRowCancelingEdit="useraccount_RowCancelingEdit" OnRowEditing="useraccount_RowEditing" OnRowUpdating="useraccount_RowUpdating" AllowPaging="True"  OnPageIndexChanging="useraccount_PageIndexChanging" PagerStyle-HorizontalAlign="NotSet">
                                        <PagerStyle ForeColor="Black" HorizontalAlign="Center" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="帳號照片" ItemStyle-HorizontalAlign="Center">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("picture") %>' Enabled="False" EnableViewState="True" Visible="False"></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Image ID="Image1" runat="server" Height="120px" ImageUrl='<%# Eval("picture") %>' Width="100px" />
                                                </ItemTemplate>                                                
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                                            <asp:TemplateField HeaderText="picture" SortExpression="Picture" Visible="false">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("picture") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("picture") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="showpicture" HeaderText="照片檔名" SortExpression="showpicture" Visible="False" ReadOnly="True" />
                                            <asp:BoundField DataField="account" HeaderText="帳號" SortExpression="account" Visible="True" ReadOnly="True" />
                                            <asp:BoundField DataField="password" HeaderText="密碼" SortExpression="password" Visible="False" ReadOnly="True" />
                                            <asp:BoundField DataField="name" HeaderText="暱稱" SortExpression="name" Visible="True" ReadOnly="True" />
                                            <asp:BoundField DataField="phone" HeaderText="電話" SortExpression="phone" Visible="True" ReadOnly="True" />
                                            <asp:BoundField DataField="email" HeaderText="郵件" SortExpression="email" Visible="True" ReadOnly="True" />
                                            <asp:BoundField DataField="address" HeaderText="地址" SortExpression="address" Visible="True" ReadOnly="True" >
                                            <HeaderStyle Width="100px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="discount" HeaderText="購物金" SortExpression="discount" Visible="True" ReadOnly="True" />
                                            <asp:TemplateField HeaderText="權限" SortExpression="access">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("access") %>' Width="60"></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("access") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="initdate" HeaderText="創建日期" SortExpression="initdate" Visible="False" ReadOnly="True" />
                                            <asp:TemplateField HeaderText="編輯" ShowHeader="False">
                                                <EditItemTemplate>
                                                    <asp:LinkButton ID="Update" runat="server" CausesValidation="True" CommandName="Update" Text="更新" OnClientClick='return confirm("確定更新?")' Width="50"></asp:LinkButton>
                                                    <asp:LinkButton ID="Cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" Width="50"></asp:LinkButton>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="Edit" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="刪除" ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除" OnClientClick='return confirm("確定刪除?")'></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </div>
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
