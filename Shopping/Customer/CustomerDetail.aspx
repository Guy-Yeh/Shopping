﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="CustomerDetail.aspx.cs" Inherits="Shopping.Customer.CustomerDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        $(document).ready(function () {

            //進頁面預設事件
            var initBut = () => {
                $('#accountClose').css('display', 'none');
                $('#accountEntrt').css('display', 'none');
                $('#accountInput').css('display', 'none');
                $('#accountEdit').css('display', '');
                $('#accountText').css('display', '');
            }

            //註冊編輯事件
            $('#accountEdit').click(function () {
                $('#accountClose').css('display', '');
                $('#accountEntrt').css('display', '');
                $('#accountEdit').css('display', 'none');
                $('#accountText').css('display', 'none');
                $('#accountInput').val($('#accountText').text())
                $('#accountInput').css('display', '');
            });

            //註冊取消事件
            $('#accountClose').click(function () {
                $('#accountClose').css('display', 'none');
                $('#accountEntrt').css('display', 'none');
                $('#accountEdit').css('display', '');
                $('#accountText').css('display', '');
                $('#accountInput').css('display', 'none');
            });


            //執行預設事件
            initBut();

        });

    </script>


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
                    <form>
                           <div class="col-md-12" style="padding: 5px;">
                            <div class="col-md-3 login-left">
                                <div class="forgot" style="font-size: 18px;">姓名</div>
                            </div>
                            <div class="col-md-6 login-left">
                                <span style="font-size: 18px;">車銀優</span>
                            </div>
                            <div class="col-md-3 login-left" style="padding: 0px;">
                                <button type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                    修改</button>
                            </div>
                        </div>

                        <div class="col-md-12" style="padding: 5px;">
                            <div class="col-md-3 login-left">
                                <div class="forgot" style="font-size: 18px;">帳號</div>
                            </div>
                            <div class="col-md-6 login-left">
                                <span id="accountText" style="font-size: 18px;">aaa123456789</span>
                                <input id="accountInput"/>
                            </div>
                            <div class="col-md-3 login-left" style="padding: 0px;">
                                <button id="accountEdit" type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                    修改</button>
                                 <button id="accountClose" type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                    取消</button>
                                <button  id="accountEntrt" type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                    確認</button>
                            </div>
                        </div>

                        <div class="col-md-12" style="padding: 5px;">
                            <div class="col-md-3 login-left">
                                <div class="forgot" style="font-size: 18px;">密碼</div>
                            </div>
                            <div class="col-md-6 login-left">
                                <span style="font-size: 18px;">************</span>
                            </div>
                            <div class="col-md-3 login-left" style="padding: 0px;">
                                <button type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                    取消</button>
                                <button type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                    確認</button>
                            </div>
                        </div>

                         <div class="col-md-12" style="padding: 5px;">
                            <div class="col-md-3 login-left">
                                <div class="forgot" style="font-size: 18px;">身分證字號</div>
                            </div>
                            <div class="col-md-6 login-left">
                                <span style="font-size: 18px;">A123456789</span>
                            </div>
                            <div class="col-md-3 login-left" style="padding: 0px;">
                                <button type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                    修改</button>
                            </div>
                        </div>

                        <div class="col-md-12" style="padding: 5px;">
                            <div class="col-md-3 login-left">
                                <div class="forgot" style="font-size: 18px;">手機</div>
                            </div>
                            <div class="col-md-6 login-left">
                                <span style="font-size: 18px;">0988777666</span>
                            </div>
                            <div class="col-md-3 login-left" style="padding: 0px;">
                                <button type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                                    修改</button>
                            </div>
                        </div>

                        <div class="col-md-12" style="padding: 5px;">
                            <div class="col-md-3 login-left">
                                <div class="forgot" style="font-size: 18px;">E-mail</div>
                            </div>
                            <div class="col-md-6 login-left">
                                <span style="font-size: 18px;">aassdd@gmail.com</span>
                            </div>
                            <div class="col-md-3 login-left" style="padding: 0px;">
                                <button type="button" class="btn btn-lg btn-info"
                                    style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;" disabled>
                                    修改</button>
                            </div>
                        </div>


                    </form>
                </div>


            </div>
        </div>
    </div>




</asp:Content>