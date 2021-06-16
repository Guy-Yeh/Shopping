var order = {};
var strTitleHtml = `<div class="col-md-12" style="border-style: solid; border-color: #ddd; border-width: 1px; padding: 10px;">
                <div class="col-md-12" style="padding: 10px;">
                    <div class="col-md-12" style="border-bottom-style: solid; border-color: #ddd; border-width: 1px;">
                        <div id="serialNO" class="col-md-4" style="font-size: 20px;">
                            訂單號碼：##serial##
                        </div>
                        <div id="dateNO" class="col-md-4" style="font-size: 10px;height: 27px;display: flex;align-items: flex-end;">
                            <div>訂單日期：##initdate##</div>
                        </div>
                        <div id="statusTest" class="col-md-4" style="display: flex;color: #52d0c4;font-size: 22px;justify-content: flex-end;">
                            ##status##
                        </div>
                    </div>
                </div>`;
var strListHtml = `<div class="col-md-12" style="display: flex; padding: 10px;">
                    <div class="col-md-12" style="border-bottom-style: solid; border-color: #ddd; border-width: 1px; padding: 0px 10px 10px 10px;">
                        <div class="col-md-1" style="padding: 0px">
                            <img id="prodPic" src="../##productPicture##" style="width: 100%" />
                        </div>
                        <div class="col-md-9">
                            <div class="col-md-12" style="word-wrap: break-word">##productName##</div>
                            <div class="col-md-12">##qty##</div>

                        </div>
                        <div class="col-md-2" style="height: 100%; display: flex; align-items: center; justify-content: flex-end;">
                            $##productPrice##
                        </div>
                    </div>
                </div>`;
var strEndHtml = ` <div class="col-md-12" style="display: flex;">
                    <div class="col-md-9">
                        <div id="contName">姓名：##name##</div>
                        <div id="contPhone">電話：##phone##</div>
                        <div id="contAddress">地址：##address##</div>   
                    </div>
                    <div class="col-md-3" style="display: flex; justify-content: flex-end;">
                        訂單金額: <span style="font-size: 20px; color: #52d0c4; padding: 0px 0px 0px 10px;">$##totalPrice##</span>
                    </div>
                </div>


                <div id="delete-but-##serial##" class="col-md-12" style="display: flex;">
                   <div class="col-md-12" style="display: flex; justify-content: flex-end;">
                        <button id="delete-but" data-serial="##serial##" type="button" class="btn btn-lg btn-info" style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                            取消訂單</button>
                    </div>
                </div>

            </div>

            <div class="col-md-12" style="padding: 10px;"></div>`;

//var strHtml = `<div class="col-md-12" style="border-style: solid; border-color: #ddd; border-width: 1px; padding: 10px;">
//                <div class="col-md-12" style="padding: 10px;">
//                    <div class="col-md-12" style="border-bottom-style: solid; border-color: #ddd; border-width: 1px;">
//                        <div id="serialNO" class="col-md-6">
//                            訂單號碼：12345678900
//                        </div>
//                        <div id="statusTest" class="col-md-6">
//                            賣方處理中
//                        </div>
//                    </div>
//                </div>
//                <div class="col-md-12" style="display: flex; padding: 10px;">
//                    <div class="col-md-12" style="border-bottom-style: solid; border-color: #ddd; border-width: 1px; padding: 0px 10px 10px 10px;">
//                        <div class="col-md-1" style="padding: 0px">
//                            <img src="../images/1.jpg" style="width: 100%" />
//                        </div>
//                        <div class="col-md-9">
//                            <div class="col-md-12" style="word-wrap: break-word">df15s1f65sd1f65sd1f65sd1f65sd1f6sd51f65sd1f6sd51f65sd1f6sd5f16sd1f69sdf98sd4g65sd1g6ds5g19ds51g456sd1g6sd5s98dg49s5dg195sd195sdg965sdg96d8g9sd4g89sd4g6165sd1g3s5dg136sgd</div>
//                            <div class="col-md-12">2</div>

//                        </div>
//                        <div class="col-md-2" style="height: 100%; display: flex; align-items: center; justify-content: flex-end;">
//                            $500
//                        </div>
//                    </div>
//                </div>


//                <div class="col-md-12" style="display: flex;">
//                    <div class="col-md-9">
//                    </div>
//                    <div class="col-md-3" style="display: flex; justify-content: flex-end;">
//                        訂單金額: <span style="font-size: 20px; color: #52d0c4; padding: 0px 0px 0px 10px;">$123456</span>
//                    </div>
//                </div>


//                <div class="col-md-12" style="display: flex;">
//                    <div class="col-md-12" style="display: flex; justify-content: flex-end;">
//                        <button id="againBuy" type="button" class="btn btn-lg btn-info" style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
//                            再買一次</button>
//                    </div>
//                </div>

//            </div>

//            <div class="col-md-12" style="padding: 10px;"></div>`;


$(document).ready(function () {



    var getOrders = (isOk) => {

        $.ajax({
            type: "post",
            url: "ShoppingList.aspx/GetOrders",
            data: JSON.stringify({ str: "123456" }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: (e) => {
                console.log(e);
                if (e.d.Status == 0) {
                    //let data = e.d.Data[0];
                    //getOrders(true);
                    //$('#statusTest').text(data.status);
                    let str = "";
                    for (var i = 0; i < e.d.Data.length; i++) {
                        let data = e.d.Data[i];
                        if (i == 0) {
                            //新訂單
                            let initdate = parseInt(data.initdate.replace("/Date(", "").replace(")/", ""));
                            let d = new Date(initdate).getFullYear() + "/" + (new Date(initdate).getMonth() + 1) + "/" + new Date(initdate).getDate() + " - " + new Date(initdate).getHours() + ":" + new Date(initdate).getMinutes() + ":" + new Date(initdate).getSeconds();
                            str = str + strTitleHtml.replace("##serial##", data.serial).replace("##status##", data.status).replace("##initdate##", d);
                            str = str + strListHtml.replace("##productName##", data.productName).replace("##productPrice##", data.productPrice * data.qty).replace("##qty##", data.qty).replace("##productPicture##", data.productPicture);
                        } else {
                            if (data.serial == e.d.Data[i - 1].serial) {
                                str = str + strListHtml.replace("##productName##", data.productName).replace("##productPrice##", data.productPrice * data.qty).replace("##qty##", data.qty).replace("##productPicture##", data.productPicture);
                            } else {
                                str = str + strEndHtml.replace("##totalPrice##", e.d.Data[i - 1].totalPrice).replaceAll("##serial##", e.d.Data[i - 1].serial).replace("##name##", e.d.Data[i - 1].name).replace("##phone##", e.d.Data[i - 1].phone).replace("##address##", e.d.Data[i - 1].address);

                                //新訂單
                                let initdate = parseInt(data.initdate.replace("/Date(", "").replace(")/", ""));
                                let d = new Date(initdate).getFullYear() + "/" + (new Date(initdate).getMonth() + 1) + "/" + new Date(initdate).getDate() + " - " + new Date(initdate).getHours() + ":" + new Date(initdate).getMinutes() + ":" + new Date(initdate).getSeconds();
                                str = str + strTitleHtml.replace("##serial##", data.serial).replace("##status##", data.status).replace("##initdate##", d);
                                str = str + strListHtml.replace("##productName##", data.productName).replace("##productPrice##", data.productPrice * data.qty).replace("##qty##", data.qty).replace("##productPicture##", data.productPicture);
                            }
                        }

                        if (i == e.d.Data.length - 1) {

                            str = str + strEndHtml.replace("##totalPrice##", data.totalPrice).replaceAll("##serial##", data.serial).replace("##name##", data.name).replace("##phone##", data.phone).replace("##address##", data.address);
                        }
                    }

                    $('#box-list').html(str);

                    for (var i = 0; i < e.d.Data.length; i++) {
                        let data = e.d.Data[i];
                        if (data.status != "賣方處理中") {
                            $('#delete-but-' + data.serial).css("display", "none");
                        }
                    }

                    // 取消
                    $("#delete-but").click(function () {
                        console.log("delete-but", $(this).attr("data-serial"));
                        $.ajax({
                            type: "post",
                            url: "ShoppingList.aspx/DelOrders",
                            data: JSON.stringify({ serial: $(this).attr("data-serial") }),
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: (e) => {
                                if (e.d.Status == 0) {
                                    let data = e.d.Data[0];
                                    $(this).attr("data-serial");

                                    //to do
                                    //customer = data;
                                    //if (isOk == true) {
                                    //    setTimeout(() => {
                                    //        alert("OK")
                                    //    }, 200)

                                    //}

                                } else {
                                    alert(e.d.Message);
                                }
                            },
                            error: (e) => {
                                console.log("ERROR");

                                alert(e.d.Message);
                            }

                        });
                    });

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

    }


    getOrders();

    //$("#btnSHClick").click(function () {
    //    $.ajax({
    //        type: "post",
    //        url: "ShoppingList.aspx/GetOrders",
    //        data: JSON.stringify({ str: "123456" }),
    //        contentType: "application/json; charset=utf-8",
    //        dataType: "json",
    //        success: (e) => {
    //            console.log(e);
    //            if (e.d.Status == 0) {
    //                //let data = e.d.Data[0];
    //                //getOrders(true);
    //                //$('#statusTest').text(data.status);
    //                let str = "";
    //                for (var i = 0; i < e.d.Data.length; i++) {
    //                    let data = e.d.Data[i];
    //                    if (i == 0) {
    //                        //新訂單
    //                        let initdate = parseInt(data.initdate.replace("/Date(", "").replace(")/", ""));
    //                        let d = new Date(initdate).getFullYear() + "/" + (new Date(initdate).getMonth() + 1) + "/" + new Date(initdate).getDate() + " - " + new Date(initdate).getHours() + ":" + new Date(initdate).getMinutes() + ":" + new Date(initdate).getSeconds();
    //                        str = str + strTitleHtml.replace("##serial##", data.serial).replace("##status##", data.status).replace("##initdate##", d);
    //                        str = str + strListHtml.replace("##productName##", data.productName).replace("##productPrice##", data.productPrice * data.qty).replace("##qty##", data.qty).replace("##productPicture##", data.productPicture);
    //                    } else {
    //                        if (data.serial == e.d.Data[i - 1].serial) {
    //                            str = str + strListHtml.replace("##productName##", data.productName).replace("##productPrice##", data.productPrice * data.qty).replace("##qty##", data.qty).replace("##productPicture##", data.productPicture);
    //                        } else {
    //                            str = str + strEndHtml.replace("##totalPrice##", e.d.Data[i - 1].totalPrice).replaceAll("##serial##", e.d.Data[i - 1].serial).replace("##name##", e.d.Data[i - 1].name).replace("##phone##", e.d.Data[i - 1].phone).replace("##address##", e.d.Data[i - 1].address);

    //                            //新訂單
    //                            let initdate = parseInt(data.initdate.replace("/Date(", "").replace(")/", ""));
    //                            let d = new Date(initdate).getFullYear() + "/" + (new Date(initdate).getMonth() + 1) + "/" + new Date(initdate).getDate() + " - " + new Date(initdate).getHours() + ":" + new Date(initdate).getMinutes() + ":" + new Date(initdate).getSeconds();
    //                            str = str + strTitleHtml.replace("##serial##", data.serial).replace("##status##", data.status).replace("##initdate##", d);
    //                            str = str + strListHtml.replace("##productName##", data.productName).replace("##productPrice##", data.productPrice * data.qty).replace("##qty##", data.qty).replace("##productPicture##", data.productPicture);
    //                        }
    //                    }

    //                    if (i == e.d.Data.length - 1) {

    //                        str = str + strEndHtml.replace("##totalPrice##", data.totalPrice).replaceAll("##serial##", data.serial).replace("##name##", data.name).replace("##phone##", data.phone).replace("##address##", data.address);
    //                    }
    //                }

    //                $('#box-list').html(str);

    //                for (var i = 0; i < e.d.Data.length; i++) {
    //                    let data = e.d.Data[i];
    //                    if (data.status != "賣方處理中") {
    //                        $('#delete-but-' + data.serial).css("display", "none");
    //                    }
    //                }

    //                // 取消
    //                $("#delete-but").click(function () {
    //                    console.log("delete-but", $(this).attr("data-serial"));
    //                    $.ajax({
    //                        type: "post",
    //                        url: "ShoppingList.aspx/DelOrders",
    //                        data: JSON.stringify({ serial: $(this).attr("data-serial") }),
    //                        contentType: "application/json; charset=utf-8",
    //                        dataType: "json",
    //                        success: (e) => {
    //                            if (e.d.Status == 0) {
    //                                let data = e.d.Data[0];
    //                                $(this).attr("data-serial");

    //                                //to do
    //                                //customer = data;
    //                                //if (isOk == true) {
    //                                //    setTimeout(() => {
    //                                //        alert("OK")
    //                                //    }, 200)

    //                                //}

    //                            } else {
    //                                alert(e.d.Message);
    //                            }
    //                        },
    //                        error: (e) => {
    //                            console.log("ERROR");

    //                            alert(e.d.Message);
    //                        }

    //                    });
    //                });

    //            } else {
    //                alert(e.d.Message);
    //            }
    //        },
    //        error: (e) => {
    //            console.log("ERROR");

    //            alert(e.d.Message);
    //        }

    //    });
    //    return false;


    //});

    //var getOrders = (isOk) => {
    //    $.ajax({
    //        type: "post",
    //        url: "ShoppingList.aspx/GetOrders",
    //        contentType: "application/json; charset=utf-8",
    //        dataType: "json",
    //        success: (e) => {
    //            if (e.d.Status == 0) {
    //                let data = e.d.Data[0];
    //                $('#statusTest').text(data.status);



    //                //to do
    //                order = data;
    //                if (isOk == true) {
    //                    setTimeout(() => {
    //                        alert("OK")
    //                    }, 200)

    //                }

    //            } else {
    //                alert(e.d.Message);
    //            }
    //        },
    //        error: (e) => {
    //            console.log("ERROR");

    //            alert(e.d.Message);
    //        }

    //    });
    //};
    //// inti
    /*getOrders();*///讀取

});