    $(document).ready(function () {
    //name預設事件
    var initnameBut = () => {
        $('#nameClose').css('display', 'none');
        $('#nameEntrt').css('display', 'none');
        $('#nameInput').css('display', 'none');
        $('#nameEdit').css('display', '');
        $('#nameText').css('display', '');
     
    }

    //name註冊編輯事件
    $('#nameEdit').click(function () {
        $('#nameClose').css('display', '');
        $('#nameEntrt').css('display', '');
        $('#nameEdit').css('display', 'none');
        $('#nameText').css('display', 'none');
        $('#nameInput').val($('#nameText').text())
        $('#nameInput').css('display', '');
        $('#phoneNumberEdit').attr('disabled', true);
        $('#passwordEdit').attr('disabled', true);
        $('#mailEdit').attr('disabled', true);
        $('#accountDelet').attr('disabled', true);
    });


    //name註冊取消事件
    $('#nameClose').click(function () {
        $('#nameClose').css('display', 'none');
        $('#nameEntrt').css('display', 'none');
        $('#nameEdit').css('display', '');
        $('#nameText').css('display', '');
        $('#nameInput').css('display', 'none');
        $('#phoneNumberEdit').removeAttr('disabled');
        $('#passwordEdit').removeAttr('disabled');
        $('#mailEdit').removeAttr('disabled');
        $('#accountDelet').removeAttr('disabled');
    });


    //密碼預設事件
    var initpasswordBut = () => {
        $('#passwordAll').css('border-width', '0px');
        $('#passwordClose').css('display', 'none');
        $('#passwordEntrt').css('display', 'none');
        $('#passwordInput').css('display', 'none');
        $('.pwd-box').css('display', 'none');
        $('#passwordEdit').css('display', '');
        $('#passwordText').css('display', '');


    }

    //註冊密碼編輯事件
    $('#passwordEdit').click(function () {
        $('#passwordAll').css('border-width', '3px');
        $('#passwordClose').css('display', '');
        $('#passwordEntrt').css('display', '');
        $('#passwordEdit').css('display', 'none');
        $('#passwordText').css('display', 'none');
        $('#passwordInput').val($('#passwordText').text())
        $('#passwordInput').css('display', '');
        $('.pwd-box').css('display', '');
        $('#nameEdit').attr('disabled', true);
        $('#phoneNumberEdit').attr('disabled', true);
        $('#mailEdit').attr('disabled', true);
        $('#accountDelet').attr('disabled', true);
        $('#newPasswordInput').attr('disabled', true);
        $('#newDoublePasswordInput').attr('disabled', true);
    });


    $("#oldPasswordInput").keyup(function () {
        if ($("#oldPasswordInput").val() == undefined || $("#oldPasswordInput").val() == '') {
            $('#newPasswordInput').attr('disabled', true);
            $('#newDoublePasswordInput').attr('disabled', true);
        } else {
            $('#newPasswordInput').attr('disabled', false);
            $('#newDoublePasswordInput').attr('disabled', false);
        }

    });

    //註冊密碼取消事件
    $('#passwordClose').click(function () {
        $('#passwordAll').css('border-width', '0px');
        $('#passwordClose').css('display', 'none');
        $('#passwordEntrt').css('display', 'none');
        $('#passwordEdit').css('display', '');
        $('#passwordText').css('display', '');
        $('#passwordInput').css('display', 'none');
        $('#phoneNumberEdit').removeAttr('disabled');
        $('#nameEdit').removeAttr('disabled');
        $('#mailEdit').removeAttr('disabled');
        $('#accountDelet').removeAttr('disabled');
        $('.pwd-box').css('display', 'none');
    });

    //進頁面密碼手機預設事件
    var initphoneNumberBut = () => {
        $('#phoneNumberClose').css('display', 'none');
        $('#phoneNumberEntrt').css('display', 'none');
        $('#phoneNumberInput').css('display', 'none');
        $('#phoneNumberEdit').css('display', '');
        $('#phoneNumberText').css('display', '');
    }

    //註冊手機編輯事件
    $('#phoneNumberEdit').click(function () {
        $('#phoneNumberClose').css('display', '');
        $('#phoneNumberEntrt').css('display', '');
        $('#phoneNumberEdit').css('display', 'none');
        $('#phoneNumberText').css('display', 'none');
        $('#phoneNumberInput').val($('#phoneNumberText').text())
        $('#phoneNumberInput').css('display', '');
        $('#nameEdit').attr('disabled', true);
        $('#passwordEdit').attr('disabled', true);
        $('#mailEdit').attr('disabled', true);
        $('#accountDelet').attr('disabled', true);
    });
    //註冊手機取消事件
    $('#phoneNumberClose').click(function () {
        $('#phoneNumberClose').css('display', 'none');
        $('#phoneNumberEntrt').css('display', 'none');
        $('#phoneNumberEdit').css('display', '');
        $('#phoneNumberText').css('display', '');
        $('#phoneNumberInput').css('display', 'none');
        $('#nameEdit').removeAttr('disabled');
        $('#passwordEdit').removeAttr('disabled');
        $('#mailEdit').removeAttr('disabled');
        $('#accountDelet').removeAttr('disabled');
    });


    //進頁面預設事件
    var initBut = () => {
        $('#accountDelet').css('display', '');

    }

    //註冊編輯事件
        $('#accountDelet').click(function () {

            var accountDel = confirm('你確定要刪除帳號嗎？');

            if (accountDel) {
                alert('你已成功刪除此帳號');
                // 直接跳轉
                window.location.href = '../index.aspx';
            } 
    });

    //註冊取消事件
    //$('#accountClose').click(function () {
    //    $('#accountClose').css('display', 'none');
    //    $('#accountEntrt').css('display', 'none');
    //    $('#accountEdit').css('display', '');
    //    $('#accountText').css('display', '');
    //    $('#accountInput').css('display', 'none');
    //});




    //mail進頁面預設事件
    var initnewMailBut = () => {
        $('#mailClose').css('display', 'none');
        $('#mailEntrt').css('display', 'none');
        $('.ma-box').css('display', 'none');
        $('#mailEdit').css('display', '');
        $('#mailText').css('display', '');
    }

    //mail編輯事件
    $('#mailEdit').click(function () {
        $('#mailAll').css('border-width', '3px');
        $('#mailClose').css('display', '');
        $('#mailEntrt').css('display', '');
        $('#mailEdit').css('display', 'none');
        $('#mailText').css('display', '');
        $('#newMailInput').val($('#newMailText').text())
        $('.ma-box').css('display', '');
        $('#nameEdit').attr('disabled', true);
        $('#phoneNumberEdit').attr('disabled', true);
        $('#passwordEdit').attr('disabled', true);
        $('#accountDelet').attr('disabled', true);

    });

    //mail取消事件
    $('#mailClose').click(function () {
        $('#mailAll').css('border-width', '0px');
        $('#mailClose').css('display', 'none');
        $('#mailEntrt').css('display', 'none');
        $('#mailEdit').css('display', '');
        $('#mailText').css('display', '');
        $('#mailInput').css('display', 'none');
        $('.ma-box').css('display', 'none');
        $('#nameEdit').removeAttr('disabled');
        $('#phoneNumberEdit').removeAttr('disabled');
        $('#passwordEdit').removeAttr('disabled');
        $('#accountDelet').removeAttr('disabled');

    });
        initBut();
        initnameBut();
        initphoneNumberBut();
        initpasswordBut();
        initnewMailBut();




        //姓名確定紐

        //$('#nameEntrt').click(function () {

        //    if (IsName($('#nameInput').val())) {
        //        //OK
        //        console.log("OK");
        //        $('#nameClose').css('display', 'none');
        //        $('#nameEntrt').css('display', 'none');
        //        $('#nameInput').css('display', 'none');
        //        $('#nameEdit').css('display', '');
        //        $('#nameText').css('display', '');

        //    } else {
        //        //NOT OK
        //        //console.log("NOT OK");
        //        var nameDel = alert('您的名字格式有誤，\n請輸入中文或英文');
        //    }
        //});

        //密碼確定紐-等等再做
        $('#passwordEntrt').click(function () {
            if (IsPassword($('#oldPasswordInput').val())) {
                //OK
                console.log("OK");
            } else {
                //NOT OK
                var passwordDel = alert('您的舊密碼輸入錯誤');
            }

            if (IsPassword($('#newPasswordInput').val())) {
                if ($('#newPasswordInput').val() == $('#newDoublePasswordInput').val()) {
                    //OK
                    console.log("OK");
                } else {
                    //NOT OK
                    var newpasswordDel2 = alert('您的新密碼輸入不同，\n請再輸入一次');
                }
            } else {
                //NOT OK
                var newpasswordDel1 = alert('您的新密碼格式錯誤，\n請輸入英文+數字的組合');
            }


        });

        ////手機確定紐
        //$('#phoneNumberEntrt').click(function () {
        //    if (IsPhone($('#phoneNumberInput').val())) {
        //        //OK
        //        console.log("OK");
        //    } else {
        //        //NOT OK
        //        var phoneNumberDel = alert('您的手機格式錯誤，\n請輸正確的手機號碼');
        //    }
        //});

        //mail驗證碼 
        $('#passTestNumberEntrt').click(function () {
            if (IsTestNumbermail($('#newMailInput').val())) {
                //OK
                var passTestNumber1 = alert('已發驗證信至您的E-mail');
            } else {
                //NOT OK
                var passTestNumber2 = alert('您E-mail格式錯誤，\n請輸入正確的E-mail');
            }
        });
        ////mail確定紐
        //$('#mailEntrt').click(function () {
        //    if (IsEmail($('#testNumberMailInput').val())) {
        //        //OK
        //        console.log("OK");
        //    } else {
        //        //NOT OK
        //        var mail = alert('驗證碼輸入錯誤');
        //    }
        //});




    });
//});