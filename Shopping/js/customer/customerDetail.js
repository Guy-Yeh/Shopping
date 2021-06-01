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
                alert('你按了確定按鈕');
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
        $('#mailText').css('display', 'none');
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

        $('#nameEntrt').click(function () {
            if (IsName($('#nameInput').val())) {
                //OK
                console.log("OK");
            } else {
                //NOT OK
                console.log("NOT OK");
            }
        });
        //密碼確定紐-等等再做
        $('#passwordEntrt').click(function () {
            if (IsPassword($('#oldPasswordInput').val())) {
                //OK
                console.log("OK");
            } else {
                //NOT OK
                console.log("NOT OK");
            }

            if (IsPassword($('#newPasswordInput').val())) {
                if ($('#newPasswordInput').val() == $('#newDoublePasswordInput').val()) {
                    //OK
                    console.log("OK");
                } else {
                    //NOT OK
                    console.log("新密碼不同");
                }
            } else {
                //NOT OK
                console.log("新密碼格式錯誤");
            }


        });

        //手機確定紐
        $('#phoneNumberEntrt').click(function () {
            if (IsPhone($('#phoneNumberInput').val())) {
                //OK
                console.log("OK");
            } else {
                //NOT OK
                console.log("NOT OK");
            }
        });

        //mail驗證碼 +確定紐
        $('#passTestNumberEntrt').click(function () {
            if (IsTestNumbermail($('#newMailInput').val())) {
                //OK
                console.log("OK");
            } else {
                //NOT OK
                console.log("NOT OK");
            }
        });
        $('#mailEntrt').click(function () {
            if (IsEmail($('#testNumberMailInput').val())) {
                //OK
                console.log("OK");
            } else {
                //NOT OK
                console.log("NOT OK");
            }
        });




    });
//});