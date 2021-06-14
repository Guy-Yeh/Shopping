var customer = {};

$(document).ready(function () {

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
                url: "CustomerDetail.aspx/EditName",
                data: JSON.stringify({ id: customer.ID, name: $('#nameInput').val() }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: (e) => {
                    if (e.d.Status == 0) {
                        let data = e.d.Data[0];
                        getCustomers(true);
                    /*    alert("OK");*/

                        $('#nameInput').css('display', 'none');
                        $('#nameText').css('display', '');
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
            /*$('#nameInput').css('display', 'none');*/
            $('#nameEdit').css('display', '');
            /*$('#nameText').css('display', '');*/
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
                url: "CustomerDetail.aspx/EditPhoneNumber",
                data: JSON.stringify({ id: customer.ID, phone: $('#phoneNumberInput').val() }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: (e) => {
                    if (e.d.Status == 0) {
                        let data = e.d.Data[0];
                        getCustomers(true);
                        
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

        return false;

    });

    var getCustomers = (isOk) => {
        $.ajax({
            type: "post",
            url: "CustomerDetail.aspx/GetCustomers",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: (e) => {
                if (e.d.Status == 0) {
                    let data = e.d.Data[0];
                    $('#nameText').text(data.name);
                    $('#accountText').text(data.account);
                    $('#phoneNumberText').text(data.phone);
                    $('#mailText').text(data.email);
                    $('#addressText').text(data.address);
                    $('#accountImg').attr('src', data.picture);

                    //to do
                    customer = data;
                    if (isOk == true) {
                        setTimeout(() => {
                            alert("OK")
                        }, 200)
                    
                    }

                } else {
                    alert(e.d.Message);
                }
            },
            error: (e) => {
                console.log("ERROR");

                alert(e.d.Message);
            }

        });
    };


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
    //修改address
    $("#addressEntrt").click(function () {
        if (IsAddress($('#addressInput').val())) {
            //OK
            console.log("OK");
            $.ajax({
                type: "post",
                url: "CustomerDetail.aspx/EditAddress",
                data: JSON.stringify({ id: customer.ID, address: $('#addressInput').val() }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: (e) => {
                    if (e.d.Status == 0) {
                        let data = e.d.Data[0];
                        getCustomers(true);
                        /*    alert("OK");*/

                        $('#addressInput').css('display', 'none');
                        $('#addressText').css('display', '');
                    } else {我
                        alert(e.d.Message);
                    }
                },
                error: (e) => {
                    console.log("ERROR");

                    alert(e.d.Message);
                }

            });
            $('#addressClose').css('display', 'none');
            $('#addressEntrt').css('display', 'none');
            /*$('#nameInput').css('display', 'none');*/
            $('#addressEdit').css('display', '');
        /*$('#nameText').css('display', '');*/
            $('#nameEdit').removeAttr('disabled');
            $('#phoneNumberEdit').removeAttr('disabled');
            $('#passwordEdit').removeAttr('disabled');
            $('#mailEdit').removeAttr('disabled');
            $('#accountDelet').removeAttr('disabled');

        } else {
            //NOT OK
            //console.log("NOT OK");
            var addressDel = alert('您的地址格式有誤，\n請輸入正確地址');
        }

        return false;

    });


    // inti
    getCustomers();//讀取

});