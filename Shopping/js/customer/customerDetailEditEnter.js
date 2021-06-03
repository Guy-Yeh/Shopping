﻿$(document).ready(function () {

/*

    $("#btnClick").click(function () {
        $.ajax({
            type: "post",
            url: "CustomerDetail.aspx/GetCustomers",
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
    */

    //修改姓名
    $("#nameEntrt").click(function () {
        if (IsName($('#nameInput').val())) {
            //OK
            console.log("OK");
            $.ajax({
                type: "post",
                url: "CustomerDetail.aspx/GetCustomers",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: (e) => {
                    if (e.d.Status == 0) {
                        let data = e.d.Data[0];
                        $('#nameText').text(data.name);
                    } else {
                        alert(e.d.Message);
                    }
                },
                error: (e) => {
                    console.log("ERROR");

                    alert(e.d.Message);
                }

            });
            $('#nameClose').css('display', 'none');
            $('#nameEntrt').css('display', 'none');
            $('#nameInput').css('display', 'none');
            $('#nameEdit').css('display', '');
            $('#nameText').css('display', '');
            $('#phoneNumberEdit').removeAttr('disabled');
            $('#passwordEdit').removeAttr('disabled');
            $('#mailEdit').removeAttr('disabled');
            $('#accountDelet').removeAttr('disabled');

        } else {
            //NOT OK
            //console.log("NOT OK");
            var nameDel = alert('您的名字格式有誤，\n請輸入中文或英文');
        }

        return false;

    });


    //修改手機
    $("#phoneNumberEntrt").click(function () {
        if (IsPhone($('#phoneNumberInput').val())) {
            //OK
            console.log("OK");
            $.ajax({
                type: "post",
                url: "CustomerDetail.aspx/GetCustomers",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: (e) => {
                    if (e.d.Status == 0) {
                        let data = e.d.Data[0];
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
            $('#phoneNumberClose').css('display', 'none');
            $('#phoneNumberEntrt').css('display', 'none');
            $('#phoneNumberInput').css('display', 'none');
            $('#phoneNumberEdit').css('display', '');
            $('#phoneNumberText').css('display', '');
            $('#nameEdit').removeAttr('disabled');
            $('#passwordEdit').removeAttr('disabled');
            $('#mailEdit').removeAttr('disabled');
            $('#accountDelet').removeAttr('disabled');
        } else {
            //NOT OK
            var phoneNumberDel = alert('您的手機格式錯誤，\n請輸正確的手機號碼');
        }

        return false ;

    });


    //修改mail
    $("#mailEntrt").click(function () {
        if (IsEmail($('#testNumberMailInput').val())) {
            //OK
            console.log("OK");
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

            $.ajax({
                type: "post",
                url: "CustomerDetail.aspx/GetCustomers",
                data: JSON.stringify({ str: "123456" }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: (e) => {
                    if (e.d.Status == 0) {
                        let data = e.d.Data[0];
                        $('#mailText').text(data.email);

                    } else {
                        alert(e.d.Message);
                    }
                },
                error: (e) => {
                    console.log("ERROR");

                    alert(e.d.Message);
                }

            });
        } else {
            //NOT OK
            var mail = alert('驗證碼輸入錯誤');
        }

        return false;

    });


});