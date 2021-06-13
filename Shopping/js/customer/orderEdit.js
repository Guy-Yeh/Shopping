var customer = {};

$(document).ready(function () {

    $("#btnSHClick").click(function () {
    $.ajax({
        type: "post",
        url: "ShoppingList.aspx/GetOrders",
        data: JSON.stringify({ str: "123456" }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (e) => {
            if (e.d.Status == 0) {
                let data = e.d.Data[0];
                $('#serialNO').text(data.serial);

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

    var getOrders = (isOk) => {
        $.ajax({
            type: "post",
            url: "ShoppingList.aspx/GetOrders",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: (e) => {
                if (e.d.Status == 0) {
                    let data = e.d.Data[0];
                    $('#serialNO').text(data.serial);


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
    // inti
    getOrders();//讀取

});