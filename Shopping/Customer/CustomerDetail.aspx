<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="CustomerDetail.aspx.cs" Inherits="Shopping.Customer.CustomerDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- customerDetail拉回 -->
    <script src="../js/customer/customerDetail.js"> </script>


    <!-- 內容 -->
    <div class="account">
        <div class="container">
            <h1>會員資料</h1>
   <%--         <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource123" DataTextField="city" DataValueField="city"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource123" runat="server" ConnectionString="<%$ ConnectionStrings:CityConnectionString %>" SelectCommand="SELECT [city] FROM [City$]"></asp:SqlDataSource>
  --%>          <div class="account_grid">
      <div class="col-md-1 login-left"></div>
                <div class="col-md-3 login-left">
                    <div style="display: flex; justify-content: flex-start;">
                        <%--        <img style="width: 200px; height: 200px;">
                         <a class="acount-btn" href="#">上傳檔案</a>--%>

                        <asp:Image ID="accountImg" style="width: 200px; height: 200px;" runat="server" />
                        <%--ImageUrl=<%# Eval(  customersModel.picture, "images/thumbs/{0} ") %>--%>
                        <%--<img id="accountImg" style="width: 200px; height: 200px;">--%>
                    </div>
                    <div style="display: flex; justify-content: flex-end; padding-top: 5px;">

                        <asp:FileUpload ID="FileUpload1" runat="server" accept=".jepg,.jpg,.png"/>
                        </div><div>
                        <asp:Button ID="Button1" class="btn btn-lg btn-info" style="border-radius: 0px; background: #52d0c4;padding: 2px 2px;" runat="server" Text="上傳圖片" OnClick="Button1_FileUpload" ForeColor="White" />
                    </div>


                        <%--<label class="upload_cover">
                            <input id="upload_input" type="file">
                            <span class="upload_icon">➕</span>
                            <i class="delAvatar fa fa-times-circle-o" title="刪除"></i>
                        </label>
                        <style>
                            .upload_cover {
                                position: relative;
                                width: 200px;
                                height: 200px;
                                text-align: center;
                                cursor: pointer;
                                background: #efefef;
                                border: 1px solid #595656;
                            }

                            #upload_input {
                                display: none;
                            }

                            .upload_icon {
                                font-weight: bold;
                                font-size: 180%;
                                position: absolute;
                                left: 0;
                                width: 100%;
                                top: 20%;
                            }

                            .delAvatar {
                                position: absolute;
                                right: 2px;
                                top: 2px;
                            }
                        </style>
                    </div>
                    <div style="display: flex; justify-content: flex-end; padding-top: 5px;">
                       
                        <label class="btn btn-info" style="background-color: #52d0c4">
                            <input id="upload_img" style="display: none;" type="file">
                            <i class="fa fa-photo"></i>上傳圖片</label>
                    </div>--%>
                    </div>
                </div>
                <div class="col-md-8 login-left">
                    <%--<form id="form111" runat="server">--%>
                    <div class="col-md-12" style="padding: 5px;">
                        <div class="col-md-3 login-left">
                            <div class="forgot" style="font-size: 18px;">姓名</div>
                        </div>
                        <div class="col-md-6 login-left">
                            <span id="nameText" style="font-size: 18px;">車銀優</span>
                            <input id="nameInput" />
                        </div>
                        <div class="col-md-3 login-left" style="padding: 0px;">
                            <button id="nameEdit" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                修改</button>
                            <button id="nameEntrt" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                確認</button>
                            <button id="nameClose" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                取消</button>
                        </div>
                    </div>

                    <div class="col-md-12" style="padding: 5px;">
                        <div class="col-md-3 login-left">
                            <div class="forgot" style="font-size: 18px;">帳號</div>
                        </div>
                        <div class="col-md-6 login-left">
                            <span id="accountText" style="font-size: 18px;">aaa123456789</span>

                        </div>
                        <div class="col-md-3 login-left" style="padding: 0px;">
                            <button id="accountDelet" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                刪除</button>

                        </div>
                    </div>

                    <!-- 密碼 -->
                    <div id="passwordAll" class="col-md-12" style="border-width: 3px; border-style: solid; border-color: #52d0c4; border-radius: 10px; padding: 5px;">
                        <div class="col-md-3 login-left">
                            <div class="forgot" style="font-size: 18px;">密碼</div>
                        </div>

                        <div class="col-md-6 login-left">
                            <span style="font-size: 18px;">************</span>
                        </div>
                        <div class="col-md-3 login-left" style="padding: 0px;">
                            <button id="passwordEdit" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                修改</button>
                            <button id="passwordClose" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                取消</button>
                        </div>

                        <div class="col-md-3 login-left pwd-box">
                            <div id="oldPassword" class="forgot" style="font-size: 18px; padding: 5px 0px;">舊密碼</div>
                        </div>
                        <div class="col-md-9 login-left pwd-box">
                            <div style="padding: 5px 0px;">
                                <input type="password" id="oldPasswordInput" />
                            </div>
                        </div>

                        <div class="col-md-3 login-left pwd-box">
                            <div id="newPassword" class="forgot" style="font-size: 18px; padding: 5px 0px;">新密碼</div>
                        </div>
                        <div class="col-md-9 login-left pwd-box">
                            <div style="padding: 5px 0px;">
                                <input type="password" id="newPasswordInput" />
                            </div>
                        </div>

                        <div class="col-md-3 login-left pwd-box">
                            <div id="newDoublePassword" class="forgot" style="font-size: 18px; padding: 5px 0px;">再輸入一次新密碼</div>
                        </div>
                        <div class="col-md-6 login-left pwd-box">
                            <div style="padding: 5px 0px;">
                                <input type="password" id="newDoublePasswordInput" />
                            </div>
                        </div>

                        <div class="col-md-3 login-left pwd-box">
                            <button id="passwordEntrt" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                確認</button>
                        </div>

                    </div>



                    <div class="col-md-12" style="padding: 5px;">
                        <div class="col-md-3 login-left">
                            <div class="forgot" style="font-size: 18px;">手機</div>
                        </div>
                        <div class="col-md-6 login-left">
                            <span id="phoneNumberText" style="font-size: 18px;">0988777666</span>
                            <input id="phoneNumberInput" />
                        </div>
                        <div class="col-md-3 login-left" style="padding: 0px;">
                            <button id="phoneNumberEdit" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                修改</button>
                            <button id="phoneNumberEntrt" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                確認</button>
                            <button id="phoneNumberClose" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                取消</button>


                        </div>
                    </div>

                    <div id="mailAll" class="col-md-12" style="border-width: 0px; border-style: solid; border-color: #52d0c4; border-radius: 10px; padding: 5px;">
                        <div class="col-md-3 login-left">
                            <div class="forgot" style="font-size: 18px;">E-mail</div>
                        </div>
                        <div class="col-md-6 login-left ">
                            <span id="mailText" style="font-size: 18px;">aassdd@gmail.com</span>
                        </div>
                        <div class="col-md-3 login-left" style="padding: 0px;">
                            <button id="mailEdit" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                修改</button>
                            <button id="mailClose" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                取消</button>

                        </div>
                        <div class="col-md-3 login-left ma-box">
                            <div id="newMail" class="forgot" style="font-size: 18px; padding: 5px 0px;height: 47px;">新信箱</div>
                        </div>
                        <div class="col-md-4 login-left ma-box"style="height: 47px;">
                            <div style="padding: 3px 0px;">
                                <input id="newMailInput" name="newMailInput"/>
                                <asp:TextBox runat="server" ID="newMailInput2" name="newMailInput2" style="display:none" Text=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-5 login-left ma-box" style="height: 47px;">
                            <div style="height: 38px; display: flex; align-items: flex-end">
                        <%--        <button id="passTestNumberEntrt" type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 0px 0px; font-size: 15px;">
                                    寄驗證碼</button>--%>
                                   <asp:Button ID="passTestNumberEntrt" class="btn btn-lg btn-info" style="border-radius: 0px; background: #52d0c4; padding: 0px 0px; font-size: 15px;" runat="server" Text="寄驗證碼"  OnClick="Button_passTestNumberEntrt" />
                            </div>

                        </div>
                        <div class="col-md-3 login-left ma-box" style="height: 47px;">
                            <div id="testNumberMail" class="forgot" style="font-size: 18px; padding: 5px 0px;">驗證碼</div>
                        </div>
                        <div class="col-md-6 login-left ma-box" style="height: 47px;">
                            <div style="padding: 5px 0px;">
                                <input id="testNumberMailInput" name="testNumberMailInput"/>
                            </div>
                        </div>
                        <div class="col-md-3 login-left ma-box" style="height: 47px;">
                        <%--    <button id="mailEntrt" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                確認</button>--%>
                             <asp:Button ID="mailEntrt" class="btn btn-lg btn-info" style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;" runat="server" Text="確認"  OnClick="Button_mailEntrt" />
                        </div>
                    </div>

                     <div class="col-md-12" style="padding: 5px;">
                        <div class="col-md-3 login-left">
                            <div class="forgot" style="font-size: 18px;">地址</div>
                        </div>
                        <div class="col-md-6 login-left">
                            <span id="addressText" style="font-size: 18px;">Taiwan</span>
                            <input id="addressInput" />
                        </div>
                        <div class="col-md-3 login-left" style="padding: 0px;">
                            <button id="addressEdit" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                修改</button>
                            <button id="addressEntrt" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                確認</button>
                            <button id="addressClose" type="button" class="btn btn-lg btn-info"
                                style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                取消</button>
                        </div>
                    </div>



<%--                    <button id="btnClick" type="button" class="btn btn-lg btn-info"
                        style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                        驗證使用者</button>--%>

                    <%--</form>--%>
                </div>



            </div>


        </div>





    </div>

    <script src="../js/customer/customerDetailEditEnter.js"> </script>
   <%-- <script type="text/javascript">
        $(document).ready(function () {

      

            $("#btnClick").click(function () {
                $.ajax({
                    type: "post",
                    url: '<%= ResolveUrl("CustomerDetail.aspx/GetCustomers") %>',
                       data: JSON.stringify({ str: "123456" }),
                       contentType: "application/json; charset=utf-8",
                       dataType: "json",
                       success: (e) => {
                           if (e.d.Status == 0) {
                               let data = e.d.Data[0];
                               $('#nameText').text(data.name);
                               $('#accountText').text(data.account);
                               $('#phoneNumberText').text(data.phone);
                           } else {
                               alert(e.d.Message);
                           }
                       },
                       error: (e) => {
                           console.log("ERROR");

                           alert(e.d.Message);
                       }

                   });
                return false;

            });


        });

    </script>--%>


</asp:Content>
