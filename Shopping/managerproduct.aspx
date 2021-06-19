<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="managerproduct.aspx.cs" Inherits="Shopping.managerproduct" %>

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
</head>
<body>
    <form runat="server" method="post">
        <!--header-->
        <div class="header">
            <div class="header-top">
                <div class="container">
                    <div class="col-md-4 number">
                        <span><i class="glyphicon glyphicon-phone"></i>0</span>2-2424-0000
                            <asp:Label ID="helpSQL" runat="server" Text="" Visible="False"></asp:Label>
                    </div>
                    <div class="col-md-4 logo">
                        <a href="index.html">
                            <img src="images/CAT4.png" alt=""></a>
                    </div>

                    <div class="col-md-4 header-left">
                        <p class="log">
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
                        </p>
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
                <br>
                <div class="container">

                    <div style="text-align: center">

                        <h1>Revise Product Table&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>

                    </div>
                    <br>

                    <div class="mepanel">
                        <div class="row">
                            <div class="col1">
                                <div class="h_nav">
                                    <h4>Add Product</h4>
                                    <ul>
                                        <li>
                                            <asp:Label ID="productName" runat="server" Text="productName"></asp:Label></li>
                                        <li>
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></li>
                                        <li>
                                            <asp:Label ID="hintPN" runat="server" Text=""></asp:Label></li>
                                        <br>
                                        <li>
                                            <asp:Label ID="category" runat="server" Text="category"></asp:Label></li>
                                        <li>
                                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></li>
                                        <li>
                                            <asp:Label ID="hintCategory" runat="server" Text=""></asp:Label></li>
                                        <br>
                                        <li>
                                            <asp:Label ID="inventory" runat="server" Text="inventory"></asp:Label></li>
                                        <li>
                                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></li>
                                        <li>
                                            <asp:Label ID="hintInventory" runat="server" Text=""></asp:Label></li>
                                        <br>
                                        <li>
                                            <asp:Label ID="price" runat="server" Text="price"></asp:Label></li>
                                        <li>
                                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></li>
                                        <li>
                                            <asp:Label ID="hintPrice" runat="server" Text=""></asp:Label></li>
                                        <br>
                                        <li>
                                            <asp:Label ID="picture" runat="server" Text="picture"></asp:Label></li>
                                        <li>
                                            <asp:FileUpload ID="FileUpload1" runat="server" /></li>
                                        <li>
                                            <asp:Label ID="hintPicture" runat="server" Text=""></asp:Label></li>
                                        <li>
                                            <asp:Button ID="Add" runat="server" OnClick="Button1_Click" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClientClick="javascript:if(!window.confirm('確定要新增嗎?')) window.event.returnValue=false;" /></li>
                                        <br>
                                        <br>
                                    </ul>
                                </div>
                            </div>
                            <div class="col1">
                                <div class="h_nav">
                                    <h4>Delete or Search Product</h4>
                                    <ul>
                                        <li>
                                            <asp:Label ID="productID" runat="server" Text="productID"></asp:Label></li>
                                        <li>
                                            <asp:DropDownList ID="DDLDeleterProductID" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px">
                                                <asp:ListItem Value="0">請選擇</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceProductsID" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT [ID] FROM [Products]"></asp:SqlDataSource>
                                        </li>
                                        <li>
                                            <asp:Label ID="hintID" runat="server" Text="選擇即將刪除的productID"></asp:Label></li>
                                        <li>
                                            <asp:Button ID="Delete" runat="server" OnClick="Button2_Click" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClientClick="javascript:if(!window.confirm('確定要刪除嗎?')) window.event.returnValue=false;" /></li>
                                        <br>
                                        <br>
                                        <li>
                                            <asp:Label ID="productNS" runat="server" Text="productName"></asp:Label></li>
                                        <li>
                                            <asp:DropDownList ID="DDLSearchProductName" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px">
                                                <asp:ListItem Value="0">請選擇</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceProductName" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT DISTINCT productName FROM Products"></asp:SqlDataSource>
                                        </li>
                                        <li>
                                            <asp:Label ID="hintPS" runat="server" Text="選擇即將搜尋的productName"></asp:Label></li>
                                        <li>
                                            <asp:Button ID="Search" runat="server" OnClick="Button4_Click" Text="submit" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" /></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col1">
                                <div class="h_nav">
                                    <h4>Update Product</h4>
                                    <ul>
                                        <li>
                                            <asp:Label ID="productID2" runat="server" Text="productID"></asp:Label></li>
                                        <li>
                                            <asp:DropDownList ID="DDLUpdateProductID" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px">
                                                <asp:ListItem Value="0">請選擇</asp:ListItem>
                                            </asp:DropDownList></li>
                                        <li>
                                            <asp:Label ID="hintID2" runat="server" Text="選擇即將更新的productID"></asp:Label><li>
                                                <br>
                                                <li></li>
                                        <li>
                                            <asp:Label ID="column" runat="server" Text="column"></asp:Label></li>
                                        <li>
                                            <asp:DropDownList ID="DDLUpdateCols" AppendDataBoundItems="True" runat="server" Height="30px" Width="195px">
                                                <asp:ListItem Value="0">請選擇</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSourceProductsCols" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsColsConnectionString %>" SelectCommand="SELECT [Cols] FROM [ProductsCols]"></asp:SqlDataSource>
                                        </li>
                                        <li>
                                            <asp:Label ID="hintColumn" runat="server" Text="選擇即將更新的欄位"></asp:Label></li>
                                        <br>
                                        <li></li>
                                        <li>
                                            <asp:Label ID="value" runat="server" Text="update value"></asp:Label></li>
                                        <li>
                                            <asp:TextBox ID="TextBox9" runat="server" placeholder="輸入更新的值"></asp:TextBox></li>
                                        <li>
                                            <asp:Label ID="hintValue" runat="server" Text=""></asp:Label></li>
                                        <li>
                                            <asp:Button ID="Update" runat="server" Text="submit" OnClick="Button3_Click" BackColor="#52d0c4" ForeColor="White" CssClass="item_add" OnClientClick="javascript:if(!window.confirm('確定要修改嗎?')) window.event.returnValue=false;" /></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="container">
                        <div class = "row">
                            <div class = "col-sm-5">
                            </div>
                            <div class = "col-sm-4">
                                <h3><asp:Label ID="Label9" runat="server" Text="商品上架" ForeColor ="#52d0c4" Font-Bold="true"></asp:Label></h3>  
                                <br>
                            </div>
                       </div>
                    </div>
                    <div class="container">
                        <div class = "row">
                            <div class = "col-sm-1">
                            </div>
                            <div class ="col-sm-10">
                    <asp:Table ID="Tableadd" runat="server" GridLines="Both" CellPadding="10" align="center">
                        <asp:TableRow>
                            <asp:TableCell ForeColor="#52d0c4">
                                productName
                            </asp:TableCell>
                            <asp:TableCell ForeColor="#52d0c4">
                                category
                            </asp:TableCell>
                            <asp:TableCell ForeColor="#52d0c4">
                                picture
                            </asp:TableCell>
                            <asp:TableCell ForeColor="#52d0c4">
                                inventory
                            </asp:TableCell>
                            <asp:TableCell ForeColor="#52d0c4">
                                price
                            </asp:TableCell>
                            <asp:TableCell ForeColor="#52d0c4">
                                introduction
                            </asp:TableCell>
                            <asp:TableCell ForeColor="#52d0c4">
                                送出
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox ID="TextBox10" runat="server" Width="100"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="TextBox11" runat="server" Width="100"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:FileUpload ID="FileUpload2" runat="server" Width="80" />
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="TextBox12" runat="server" Width="100"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="TextBox13" runat="server" Width="100"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <textarea rows="5" id="TextBox14" name="contactresponse" class="form-control" placeholder="請輸入介紹"></textarea>
                            </asp:TableCell>
                            <asp:TableCell ForeColor="#52d0c4">
                                <asp:LinkButton ID="adding" runat="server" OnClientClick='return confirm("確定新增?")' Width="50">送出</asp:LinkButton>                               
                            </asp:TableCell>
                        </asp:TableRow>
                        </asp:Table>
                                </div>
                                </div>
                            </div>
                        </div>
                    <div class="clearfix">

                        <br>
                        
                        <asp:GridView ID="product" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" OnRowDeleting="product_RowDeleting" OnRowCancelingEdit="product_RowCancelingEdit" OnRowEditing="product_RowEditing" OnRowUpdating="product_RowUpdating" AllowPaging="True" OnPageIndexChanging="product_PageIndexChanging">
                            <PagerStyle ForeColor="Black" HorizontalAlign="Center" />
                            <Columns>
                                <asp:TemplateField HeaderText="image">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("picture") %>' ReadOnly="True" Visible="False"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Image ID="Image1" runat="server" Height="120px" ImageUrl='<%# Eval("picture") %>' Width="100px" ValidateRequestMode="Inherit" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="ID">
                                    <EditItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="productName" SortExpression="productName">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("productName") %>'></asp:TextBox>

                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("productName") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="picture" SortExpression="picture" Visible="False" ValidateRequestMode="Enabled">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("picture") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("picture") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="category" SortExpression="category">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("category") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("category") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="picture" SortExpression="picture">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("showpicture") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("showpicture") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="inventory" SortExpression="inventory">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("inventory") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("inventory") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="price" SortExpression="price">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("price") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("price") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="introduction" SortExpression="introduction">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("introduction") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("introduction") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="initdate" HeaderText="initdate" SortExpression="initdate" ReadOnly="True" />
                                <asp:TemplateField HeaderText="revise" ShowHeader="False">
                                    <EditItemTemplate>
                                        <asp:LinkButton ID="Update" runat="server" CausesValidation="False" CommandName="Update" Text="更新" OnClientClick='return confirm("確定更新?")'></asp:LinkButton>
                                        <asp:LinkButton ID="Cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="Edit" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="delete" ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="Delete" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除" OnClientClick='return confirm("確定刪除?")'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>
                            <PagerStyle CssClass="fvPagerStyle" HorizontalAlign="Center" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSourceProduct" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>

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
