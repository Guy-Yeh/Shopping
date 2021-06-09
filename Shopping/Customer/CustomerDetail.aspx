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
            <div class="account_grid">

                <div class="col-md-4 login-left">
                    <div style="display: flex; justify-content: flex-end;">
                        <img style="width: 200px; height: 200px;">
                    </div>
                    <div style="display: flex; justify-content: flex-end; padding-top: 5px;">
                        <a class="acount-btn" href="#">上傳檔案</a>
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
                                    <input id="oldPasswordInput" />
                                </div>
                            </div>

                            <div class="col-md-3 login-left pwd-box">
                                <div id="newPassword" class="forgot" style="font-size: 18px; padding: 5px 0px;">新密碼</div>
                            </div>
                            <div class="col-md-9 login-left pwd-box">
                                <div style="padding: 5px 0px;">
                                    <input id="newPasswordInput" />
                                </div>
                            </div>

                            <div class="col-md-3 login-left pwd-box">
                                <div id="newDoublePassword" class="forgot" style="font-size: 18px; padding: 5px 0px;">再輸入一次新密碼</div>
                            </div>
                            <div class="col-md-6 login-left pwd-box">
                                <div style="padding: 5px 0px;">
                                    <input id="newDoublePasswordInput" />
                                </div>
                            </div>

                            <div class="col-md-3 login-left">
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
                                <div id="newMail" class="forgot" style="font-size: 18px; padding: 5px 0px;">新信箱</div>
                            </div>
                            <div class="col-md-4 login-left ma-box">
                                <div style="padding: 3px 0px;">
                                    <input id="newMailInput" />
                                </div>
                            </div>
                            <div class="col-md-5 login-left ma-box">
                                <div style="height: 38px; display: flex; align-items: flex-end">
                                    <button id="passTestNumberEntrt" type="button" class="btn btn-lg btn-info"
                                        style="border-radius: 0px; background: #52d0c4; padding: 0px 0px; font-size: 15px;">
                                        寄驗證碼</button>
                                </div>

                            </div>
                            <div class="col-md-3 login-left ma-box">
                                <div id="testNumberMail" class="forgot" style="font-size: 18px; padding: 5px 0px;">驗證碼</div>
                            </div>
                            <div class="col-md-6 login-left ma-box">
                                <div style="padding: 5px 0px;">
                                    <input id="testNumberMailInput" />
                                </div>
                            </div>
                            <div class="col-md-3 login-left">
                                <button id="mailEntrt" type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                    確認</button>
                            </div>
                        </div>

                      <button id="btnClick" type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                    驗證使用者</button>
                 
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
