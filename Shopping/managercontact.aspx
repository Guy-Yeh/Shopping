<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="managercontact.aspx.cs" Inherits="Shopping.managercontact"  MaintainScrollPositionOnPostback="true" %>

<!--A Design by W3layouts 
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html>
<head>
    <title>丹丹服飾 : : 回覆訊息</title>
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
                    <div class="col-md-4 world">

                        <asp:Label ID="helpSQL" runat="server" Text="" Visible="False"></asp:Label>
                        <asp:Label ID="helpSQL2" runat="server" Text="" Visible="False"></asp:Label>
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
        <br>
        

            <div class="container">

                <div style="text-align: center">
                    <h1>回覆顧客留言&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
                </div>
                <br>
                <br>
                <div class="mepanel">
                    <div class="row">
                        <div class="col1">
                            <div class="h_nav">
                                <h4>查詢方式:帳號</h4>
                                <ul>
                                    <li>
                                        <input type="text" id="searchaccount" name="searchaccount" class="form-control" placeholder="請輸入帳號"></li>
                                    <li>
                                        <asp:Label ID="hintSearch" runat="server" Text=""></asp:Label></li>
                                    <li>
                                        <asp:Button ID="search" runat="server" Text="送出" OnClick="Button2_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" />
                                    </li>
                                </ul>
                            </div>
                            <br>
                            <br>
                        </div>
                        <div class="col1">
                            <div class="h_nav">
                                <h4>查詢:起始日期</h4>
                                <ul>
                                    <li>
                                        <asp:DropDownList ID="DDLYearS" runat="server" AppendDataBoundItems="True" Width="365px" Height="30px">
                                            <asp:ListItem Value="0">年</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSourceYears" runat="server" ConnectionString="<%$ ConnectionStrings:YearsConnectionString %>" SelectCommand="SELECT [years] FROM [YearsMonthsDays]"></asp:SqlDataSource>
                                    </li>
                                    <br>
                                    <li>
                                        <asp:DropDownList ID="DDLMonthS" runat="server" AppendDataBoundItems="True" Width="365px" Height="30px">
                                            <asp:ListItem Value="0">月</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSourceMonth" runat="server" ConnectionString="<%$ ConnectionStrings:MonthsConnectionString %>" SelectCommand="SELECT months FROM YearsMonthsDays WHERE (months IS NOT NULL)"></asp:SqlDataSource>
                                    </li>
                                    <br>
                                    <li>
                                        <asp:DropDownList ID="DDLDayS" runat="server" AppendDataBoundItems="True" Width="365px" Height="30px">
                                            <asp:ListItem Value="0">日</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSourceDay" runat="server" ConnectionString="<%$ ConnectionStrings:DaysConnectionString %>" SelectCommand="SELECT days FROM YearsMonthsDays WHERE (days IS NOT NULL)"></asp:SqlDataSource>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class="col1">
                            <div class="h_nav">
                                <h4>查詢:終止日期(預設為當天)</h4>
                                <ul>
                                    <li>
                                        <asp:DropDownList ID="DDLYearE" runat="server" AppendDataBoundItems="True" Width="365px" Height="30px">
                                            <asp:ListItem Value="0">年</asp:ListItem>
                                        </asp:DropDownList></li>
                                    <br>
                                    <li>
                                        <asp:DropDownList ID="DDLMonthE" runat="server" AppendDataBoundItems="True" Width="365px" Height="30px">
                                            <asp:ListItem Value="0">月</asp:ListItem>
                                        </asp:DropDownList></li>
                                    <br>
                                    <li>
                                        <asp:DropDownList ID="DDLDayE" runat="server" AppendDataBoundItems="True" Width="365px" Height="30px">
                                            <asp:ListItem Value="0">日</asp:ListItem>
                                        </asp:DropDownList></li>
                                   
                                    <li></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <asp:SqlDataSource ID="SqlDataSourceChatting" runat="server" ConnectionString="<%$ ConnectionStrings:ChatConnectionString %>" SelectCommand="SELECT * FROM [Chat]"></asp:SqlDataSource>
            <!----->
            <div class="container">
                <div class="row">
                    <div class="col-sm-7">
                    </div>
                    <div class="col-sm-5">
                        <asp:Button ID="show" runat="server" Text="送出" OnClick="Button3_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Width="100" Height="30" />
                         <asp:Label ID="hintDate" runat="server" Text=""></asp:Label>
                        <br>
                        <br>
                        <br>
                    </div>
                </div>
            </div>

            <div class="container">
                <div class="row">
                    <div class="col-sm-9">
                    </div>
                    <div class="col-sm-2">
                        <br>
                        <asp:Button ID="all" runat="server" Text="查看尚未回覆" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClick="all_Click" Width="135px" Height="40" />
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-sm-2">
                    </div>
                    <div class="col-sm-10">

                        <asp:GridView ID="usercontact" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" AllowPaging="True" OnPageIndexChanging="usercontact_PageIndexChanging" OnRowCancelingEdit="usercontact_RowCancelingEdit" OnRowEditing="usercontact_RowEditing" OnRowUpdating="usercontact_RowUpdating">
                            <PagerStyle ForeColor="Black" HorizontalAlign="Center" />
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                                <asp:BoundField DataField="account" HeaderText="帳號" SortExpression="account" ReadOnly="True" />
                                <asp:BoundField DataField="message" HeaderText="顧客訊息" SortExpression="message" ReadOnly="True" />
                                <asp:BoundField DataField="initdate" HeaderText="發問日期" SortExpression="initdate" ReadOnly="True" />
                                <asp:TemplateField HeaderText="回覆內容" SortExpression="response">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("response") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("response") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="updateInitdate" HeaderText="回覆日期" SortExpression="updateInitdate" ReadOnly="True" />
                                <asp:TemplateField HeaderText="回覆" ShowHeader="False">
                                    <EditItemTemplate>
                                        <asp:LinkButton ID="Update" runat="server" CausesValidation="True" CommandName="Update" Text="更新" OnClientClick='return confirm("確定回覆?")'></asp:LinkButton>
                                        <asp:LinkButton ID="Cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="回覆" runat="server" CausesValidation="False" CommandName="Edit" Text="回覆"></asp:LinkButton>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
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
