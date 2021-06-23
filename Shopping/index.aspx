<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Shopping.index" %>

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
    <%--這段到42行只為了摺疊功能--%>
    <!-- Optional JavaScript; choose one of the two! -->

    <!-- Option 1: Bootstrap Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4" crossorigin="anonymous"></script>

    <!-- Option 2: Separate Popper and Bootstrap JS -->
    <!--
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.min.js" integrity="sha384-Atwg2Pkwv9vp0ygtn1JAojH0nYbwNJLPhwyoVbhoPwBhjQPR5VtM2+xf0Uwh9KtT" crossorigin="anonymous"></script>
    -->
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
                    </div>
                    <div class="col-sm-4 logo">
                        <a href="index">
                            <img src="images/CAT4.png" alt=""></a>
                    </div>

                    <div class="col-sm-4 header-left">

                        <asp:Button ID="Button11" runat="server" Text="註冊" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="45px" Style="float: right" OnClick="Button11_Click" />
                        <asp:Button ID="Button12" runat="server" Text="登錄" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="80px" Style="float: right" OnClick="Button12_Click" /><br>
                        <br>
                        <asp:Label ID="Label1" runat="server" Text="消費金額：" Style="float: right"></asp:Label><br>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/cart.png" Style="float: right" OnClick="ImageButton1_Click" Height="20" Width="20" />
                        <asp:Button ID="Button9" runat="server" Text="清空購物車" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="100" Style="float: right" OnClick="Button9_Click" Font-Size="Larger" />
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
            <div class="container">
                <div class="head-top">
                    <div class="col-sm-2 number">
                    </div>
                    <div class="col-md-8 h_menu4">
                        <ul class="memenu skyblue">
                            <li><a class="color6" href="shoppingcar">購物車</a></li>
                            <li><a class="color6" href="Customer\Chat.aspx">聯絡我們</a></li>
                            <li>
                                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Font-Size="Large">購物須知</asp:LinkButton></li>
                        </ul>
                    </div>
                    <div class="col-sm-2 search">
                        <a class="play-icon popup-with-zoom-anim" href="#small-dialog"><i class="glyphicon glyphicon-search"></i></a>
                    </div>
                    <div class="clearfix"></div>
                    <!---pop-up-box---->
                    <script type="text/javascript" src="js/modernizr.custom.min.js"></script>
                    <link href="css/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
                    <script src="js/jquery.magnific-popup.js" type="text/javascript"></script>
                    <!---//pop-up-box---->
                    <div id="small-dialog" class="mfp-hide">
                        <div class="search-top">
                            <div class="login">
                                <input type="submit" value="">
                                <input type="text" value="Type something..." onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}">
                            </div>
                            <p>Shopping</p>
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
        <!--banner-->
        <div class="banner">
            <div class="col-sm-3 banner-mat">
                <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="images\衣服\281901701-領造型線T\S__77931623.jpg" Height="100%" Width="100%" />
            </div>
            <div class="col-sm-6 matter-banner">
                <div class="slider">
                    <div class="callbacks_container">
                        <ul class="rslides" id="slider">
                            <li>
                                <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="images\衣服\281901801-細肩露肩t\S__49840130.jpg" Height="100%" Width="100%" />
                            </li>
                            <li>
                                <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="images\衣服\281906305-中抓摺雪紡衫\S__50069542.jpg" Height="100%" Width="100%" />
                            </li>
                            <li>
                                <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="images\衣服\281901701-領造型線T\S__49610819.jpg" Height="100%" Width="100%" />
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col-sm-3 banner-mat">
                <asp:ImageButton ID="ImageButton14" runat="server" ImageUrl="images\衣服\281901708-袖滾配色t\S__77931217.jpg" Height="100%" Width="100%" />
            </div>
            <div class="clearfix"></div>
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
                                    <asp:Label ID="Label2" runat="server" Text="領造型線T  售價："></asp:Label>
                                    <asp:Label ID="Label3" runat="server" Text="900"></asp:Label><br>
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                        <asp:ListItem>白</asp:ListItem>
                                        <asp:ListItem>綠</asp:ListItem>
                                        <asp:ListItem>紅</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Button ID="Button1" runat="server" Text="放入購物車" OnClick="Button1_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Style="float: right" />
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3 col-md2">
                            <div class="col-md1 simpleCart_shelfItem">
                                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images\衣服\281901708-袖滾配色t\S__49840211.jpg" Height="100%" Width="100%" OnClick="ImageButton3_Click" />
                                <div class="price">
                                    <asp:Label ID="Label4" runat="server" Text="袖滾配色T  售價："></asp:Label>
                                    <asp:Label ID="Label5" runat="server" Text="950"></asp:Label><br>
                                    <asp:DropDownList ID="DropDownList2" runat="server">
                                        <asp:ListItem>白</asp:ListItem>
                                        <asp:ListItem>綠</asp:ListItem>
                                        <asp:ListItem>橘</asp:ListItem>
                                        <asp:ListItem>黑</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Button ID="Button2" runat="server" Text="放入購物車" OnClick="Button2_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Style="float: right" />
                                    <div class="clearfix"></div>
                                </div>

                            </div>
                        </div>
                        <div class="col-md-3 col-md2">
                            <div class="col-md1 simpleCart_shelfItem">
                                <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/images\衣服\281901715-剪裁T\S__49840159.jpg" Height="100%" Width="100%" OnClick="ImageButton4_Click" />
                                <div class="price">
                                    <asp:Label ID="Label6" runat="server" Text="剪裁T  售價："></asp:Label>
                                    <asp:Label ID="Label7" runat="server" Text="850"></asp:Label><br>
                                    <asp:DropDownList ID="DropDownList3" runat="server">
                                        <asp:ListItem>白</asp:ListItem>
                                        <asp:ListItem>灰</asp:ListItem>
                                        <asp:ListItem>杏</asp:ListItem>
                                        <asp:ListItem>咖啡</asp:ListItem>
                                        <asp:ListItem>黑</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Button ID="Button3" runat="server" Text="放入購物車" OnClick="Button3_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Style="float: right" />
                                    <div class="clearfix"></div>
                                </div>

                            </div>
                        </div>
                        <div class="col-md-3 col-md2">
                            <div class="col-md1 simpleCart_shelfItem">
                                <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/images\衣服\281901801-細肩露肩t\S__49840130.jpg" Height="100%" Width="100%" OnClick="ImageButton5_Click" />
                                <div class="price">
                                    <asp:Label ID="Label8" runat="server" Text="細肩露肩T  售價："></asp:Label>
                                    <asp:Label ID="Label9" runat="server" Text="1000"></asp:Label><br>
                                    <asp:DropDownList ID="DropDownList4" runat="server">
                                        <asp:ListItem>白</asp:ListItem>
                                        <asp:ListItem>綠</asp:ListItem>
                                        <asp:ListItem>紅</asp:ListItem>
                                        <asp:ListItem>黑</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Button ID="Button4" runat="server" Text="放入購物車" OnClick="Button4_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Style="float: right" />
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="content-top1">
                        <div class="col-md-3 col-md2">
                            <div class="col-md1 simpleCart_shelfItem">
                                <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/images\衣服\281902805-胸抓摺衫\S__49954893.jpg" Height="100%" Width="100%" OnClick="ImageButton6_Click" />
                                <div class="price">
                                    <asp:Label ID="Label10" runat="server" Text="胸抓摺衫  售價："></asp:Label>
                                    <asp:Label ID="Label11" runat="server" Text="980"></asp:Label><br>
                                    <asp:DropDownList ID="DropDownList5" runat="server">
                                        <asp:ListItem>灰</asp:ListItem>
                                        <asp:ListItem>黑</asp:ListItem>
                                        <asp:ListItem>粉</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Button ID="Button5" runat="server" Text="放入購物車" OnClick="Button5_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Style="float: right" />
                                    <div class="clearfix"></div>
                                </div>

                            </div>
                        </div>
                        <div class="col-md-3 col-md2">
                            <div class="col-md1 simpleCart_shelfItem">
                                <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/images\衣服\281904506-格紋澎袖衫\S__49954861.jpg" Height="100%" Width="100%" OnClick="ImageButton7_Click" />
                                <div class="price">
                                    <asp:Label ID="Label12" runat="server" Text="格紋澎袖衫  售價："></asp:Label>
                                    <asp:Label ID="Label13" runat="server" Text="790"></asp:Label><br>
                                    <asp:DropDownList ID="DropDownList6" runat="server">
                                        <asp:ListItem>黑</asp:ListItem>
                                        <asp:ListItem>紅</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Button ID="Button6" runat="server" Text="放入購物車" OnClick="Button6_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Style="float: right" />
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3 col-md2">
                            <div class="col-md1 simpleCart_shelfItem">
                                <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/images\衣服\281906305-中抓摺雪紡衫\S__50069542.jpg" Height="100%" Width="100%" OnClick="ImageButton8_Click" />
                                <div class="price">
                                    <asp:Label ID="Label14" runat="server" Text="中抓摺雪紡衫  售價："></asp:Label>
                                    <asp:Label ID="Label15" runat="server" Text="980"></asp:Label><br>
                                    <asp:DropDownList ID="DropDownList7" runat="server">
                                        <asp:ListItem>杏</asp:ListItem>
                                        <asp:ListItem>白</asp:ListItem>
                                        <asp:ListItem>紅</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Button ID="Button7" runat="server" Text="放入購物車" OnClick="Button7_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Style="float: right" />
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3 col-md2">
                            <div class="col-md1 simpleCart_shelfItem">
                                <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/images\衣服\281905801-滾邊寬袖衫\S__50200586.jpg" Height="100%" Width="100%" OnClick="ImageButton9_Click" />
                                <div class="price">
                                    <asp:Label ID="Label16" runat="server" Text="滾邊寬袖衫  售價："></asp:Label>
                                    <asp:Label ID="Label17" runat="server" Text="990"></asp:Label><br>
                                    <asp:DropDownList ID="DropDownList8" runat="server">
                                        <asp:ListItem>白</asp:ListItem>
                                        <asp:ListItem>粉</asp:ListItem>
                                        <asp:ListItem>黑</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Button ID="Button8" runat="server" Text="放入購物車" OnClick="Button8_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Style="float: right" />
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
            <div class="container">
            <div align="center">
                <a class="btn btn-primary" data-bs-toggle="collapse" href="#collapseExample" role="button" aria-expanded="false" aria-controls="collapseExample" style="border-color: #FFFFFF; font-size: 50px; background-color: #FFFFFF; color: #000000;">更多商品
                </a>
            </div>
                
                <div class="collapse" id="collapseExample">
                   <div class="content-top1">
                        <script src="../js/index.js"> </script>
                        <div id="box-list1">
                            <%--<div class="col-md-3 col-md2">
                                <div class="col-md1 simpleCart_shelfItem">
                                    <a href="product.aspx">
                                        <img alt="" src="images\衣服\281906501-珍珠領垂中簍空衫\S__50069539.jpg" height="100%" width="100%" id="test1" /></a>
                                    <div class="price">
                                        <label id="test2">滾邊寬袖衫  售價：</label><label></label><br>
                                        <select name="cars" id="test3">
                                            <option value="藍">藍</option>
                                            <option value="白">白</option>
                                        </select>
                                        <input id="Button20" type="button" value="放入購物車" style="background: #52d0c4; color: white; float: right; border-style: none" />
                                    </div>
                                </div>
                            </div>--%>
                        </div>
                        <div class="clearfix"></div>
                </div>
            </div>
        </div>

</div>
        <!--//content-->

        <%--<div class="container">
            <div align="center">
                <a class="btn btn-primary" data-bs-toggle="collapse" href="#collapseExample" role="button" aria-expanded="false" aria-controls="collapseExample" style="border-color: #FFFFFF; font-size: 50px; background-color: #FFFFFF; color: #000000;">更多商品
                </a>
            </div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:TemplateField>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("picture") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl='<%# Eval("picture") %>' Width="120px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="picture" HeaderText="picture" SortExpression="picture" Visible="False" />
                    <asp:TemplateField HeaderText="商品名稱" SortExpression="productName">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("productName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("productName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="price" HeaderText="價格" SortExpression="price" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingConnectionString %>" SelectCommand="SELECT DISTINCT a.price, b.productName, b.picture FROM Products AS a INNER JOIN ShowPicture AS b ON a.productName = b.productName"></asp:SqlDataSource>
            <div class="collapse" id="collapseExample">
                <div class="card card-body">
                    Some placeholder content for the collapse component. This panel is hidden by default but revealed when the user activates the relevant trigger.
                </div>
            </div>
        </div>--%>
    </form>
    <!--footer-->
    <div class="footer">
        <div class="container">
            <div class="footer-top">
                <div class="row">
                    <div class="col-sm-7">
                        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7659.912326510472!2d121.56070378360901!3d25.03417107027919!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442abb6da80a7ad%3A0xacc4d11dc963103c!2z5Y-w5YyXMTAx!5e0!3m2!1szh-TW!2stw!4v1623592494222!5m2!1szh-TW!2stw" width="600" height="450" style="border: 0;"></iframe>
                    </div>
                    <div class="col-sm-5">
                        <asp:Label ID="Label18" runat="server" Text="丹丹服飾股份有限公司" Font-Size="XX-Large" Font-Bold="True"></asp:Label><br>
                        <br>
                        <asp:Label ID="Label19" runat="server" Text="地址：(110)台北市信義區信義路五段7號"></asp:Label><br>
                        <asp:Label ID="Label20" runat="server" Text="No. 7, Sec. 5, Xinyi Rd., Xinyi Dist., Taipei City 110615 , Taiwan (R.O.C.)"></asp:Label><br>
                        <br>
                    </div>
                    <div class="col-sm-5">
                        <asp:Label ID="Label21" runat="server" Text="聯絡我們" Font-Size="X-Large"></asp:Label><br>
                        <br>
                        <asp:Label ID="Label22" runat="server" Text="客服信箱 / vs.for.test2021@gmail.com"></asp:Label><br>
                        <asp:Label ID="Label23" runat="server" Text="服務時間 / 09:00 - 18:00 國定假日及例假日休息"></asp:Label><br>
                        <asp:Label ID="Label24" runat="server" Text="聯絡電話 / 02-2424-0000"></asp:Label><br>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <!--//footer-->
</body>
</html>
