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
    <title>丹丹服飾 : : 購物車</title>
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
                    </div>
                    <div class="col-sm-4 logo">
                        <a href="index">
                            <img src="images/CAT4.png" alt=""></a>
                    </div>

                    <div class="col-sm-4 header-left">
                        <asp:Button ID="Button3" runat="server" Text="註冊" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="45px" Style="float: right" OnClick="Button3_Click" />
                        <asp:Button ID="Button4" runat="server" Text="登錄" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="80px" Style="float: right" OnClick="Button4_Click" /><br>
                        <br>
                        <asp:Label ID="Label1" runat="server" Text="消費金額：" Style="float: right"></asp:Label><br>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/cart.png" Style="float: right" OnClick="ImageButton1_Click" Height="20" Width="20" />
                        <asp:Button ID="Button1" runat="server" Text="清空購物車" BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="#52D0C4" Width="100" Style="float: right" OnClick="Button1_Click" Font-Size="Larger" />
                    </div>
                    <div class="clearfix"></div>
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
                        <li><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Font-Size="Large" >購物須知</asp:LinkButton></li>
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


        <!--//header-->
        <!---->
        <div class="container">
                <div class="check-out">
                    <asp:GridView ID="userorder" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="ID" OnRowCommand="userorder_RowCommand" Width="100%">
                        <Columns>
                            <asp:TemplateField HeaderText="商品圖片">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("productPicture") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" Height="120px" ImageUrl='<%# Eval("productPicture") %>' Width="100px" />
                                </ItemTemplate>                               
                            </asp:TemplateField>
                            <asp:BoundField DataField="productPicture" HeaderText="productPicture" SortExpression="productPicture" Visible="False" />
                            <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="ID" Visible="False">
                                <EditItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="productName" HeaderText="商品名稱" SortExpression="productName" >
                            </asp:BoundField>
                            <asp:BoundField DataField="productColor" HeaderText="顏色" SortExpression="productColor" >
                            </asp:BoundField>
                            <asp:BoundField DataField="productPrice" HeaderText="金額" SortExpression="productPrice" >
                            </asp:BoundField>
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="false" CommandName="Subtract" Height="20px" ImageAlign="AbsMiddle" ImageUrl="~/images/dowm.png" Text="" Width="30px" CommandArgument='<%# Container.DataItemIndex%>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="qty" HeaderText="數量" SortExpression="qty" >
                            </asp:BoundField>
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="false" CommandName="Add" Height="20px" CommandArgument='<%# Container.DataItemIndex%>' ImageAlign="AbsMiddle" ImageUrl="~/images/up.png" Text="" Width="30px" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="刪除" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除" CommandArgument='<%# Container.DataItemIndex%>'></asp:LinkButton>
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
                    <asp:Label ID="Label4" runat="server" Text="Label" Style="float: right" ForeColor="#52D0C4" Font-Size="X-Large"></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="總金額：" Style="float: right" ForeColor="#52D0C4" Font-Size="X-Large"></asp:Label><br>
                    <br>
                    <asp:Button ID="Button2" runat="server" Text="確認購買" OnClick="Button2_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" Style="float: right" Font-Size="X-Large" BorderStyle="None" />
                    <div class="clearfix"></div>
                </div>
            </div>
        <!--footer-->
        <div class="footer">
            <div class="container">
                <div class="footer-top">
                    <div class="row">
                        <div class="col-sm-7">
                            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7659.912326510472!2d121.56070378360901!3d25.03417107027919!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442abb6da80a7ad%3A0xacc4d11dc963103c!2z5Y-w5YyXMTAx!5e0!3m2!1szh-TW!2stw!4v1623592494222!5m2!1szh-TW!2stw" width="600" height="450" style="border: 0;"></iframe>
                        </div>
                        <div class="col-sm-4">
                            <asp:Label ID="Label18" runat="server" Text="丹丹服飾股份有限公司" Font-Size="XX-Large" Font-Bold="True"></asp:Label><br>
                            <br>
                            <asp:Label ID="Label19" runat="server" Text="地址：(110)台北市信義區信義路五段7號"></asp:Label><br>
                            <asp:Label ID="Label20" runat="server" Text="No. 7, Sec. 5, Xinyi Rd., Xinyi Dist., Taipei City 110615 , Taiwan (R.O.C.)"></asp:Label><br>
                            <br>
                            </div>
                            <div class="col-sm-4">
                            <asp:Label ID="Label21" runat="server" Text="聯絡我們" Font-Size="X-Large" Font-Bold="True"></asp:Label><br>
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
    </form>
</body>
</html>
