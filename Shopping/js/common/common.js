function IsName(name) {
    if (name == '' || name == undefined) {
        return false;
    }
    var regex = /^[\u4e00-\u9fa5_A-Za-z]{2,10}$/;//^[\u4e00-\u9fa5_a-zA-Z0-9]+$/;
    return regex.test(name);
}

function IsPassword(password) {
    if (password == '' || password == undefined) {
        return false;
    }
    var regex = /^(?![0-9]+$)(?![a-zA-Z]+$)[0-9A-Za-z]{7,20}$/;
    return regex.test(password);
}

function IsPhone(phone) {
    if (phone == '' || phone == undefined) {
        return false;
    }
    var regex = /^09[0-9]{8}$/;
    return regex.test(phone);
}


//mail的正規表達式
function IsTestNumbermail(email) {
    if (email == '' || email == undefined) {
        return false;
    }
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email);
}

//確認mail的驗證碼
//function IsEmail(testNumbe) {
//    if (testNumbe == '' || testNumbe == undefined) {
//        return false;
//    }
//    var regex = /^[0-9]*$/;
//    return regex.test(testNumbe);
/*}*/

//確認地址的正規表達式

function IsAddress(address) {
    if (address == '' || address == undefined) {
        return false;
    }
    var regex = /^[\u4e00-\u9fa5_a-zA-Z0-9]+$/;
    return regex.test(address);
}




/*
            (?=.{10,})：密碼長度10個以上
            (?=.*\d)：至少要有一個0-9的數字
            (?=.*[a-z])：至少要有一個小寫的英文字母(a-z)
            (?=.*[A-Z]])：至少要有一個大寫的英文字母(A-Z)
            (?=.*[@#$%^&+=])：至少要有清單中的一個特殊符號(@#$%^&+=)
        */