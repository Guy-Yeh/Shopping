var order = {};
var strHtml = `<div class="col-md-3 col-md2">
                    <div class="col-md1 simpleCart_shelfItem">
                         <a href="product.aspx">
                             <img alt="" src="##picture##" height="100%" width="100%" /></a>
                                <div class="price">
                                    <label >##productName##  售價：##price##</label><br>
                                    <label >##category##</label>
                                    <input id="goproduct" type="button" value="查看更多" style="background: #52d0c4 ; color:white ; float: right; border-style:none"  />
                                </div>
                            </div>
                        </div>
                     </div>`;

$(document).ready(function ()
{
    var getProducts = (isOk) =>
    {
        $.ajax(
        {
            type: "post",
            url: "index.aspx/indexproduct",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: (e) =>
            {
                console.log(e);
                let str = "";
                if (e.d.Status == 0) {
                    for (var i = 0; i < e.d.Data.length; i++) {
                        let data = e.d.Data[i];
                        //新訂單
                        str = str + strHtml.replace("##picture##", data.picture).replace("##productName##", data.productName).replace("##price##", data.price).replace("##category##", data.category);

                    }                   
                }
                $('#box-list1').html(str);
                $("#goproduct").click(function () {
                    console.log("delete-but", $(this).attr("data-serial"));
                    $.ajax({
                        type: "post",
                        url: "index.aspx/DelOrders",
                        data: JSON.stringify({ status: '取消訂單', serial: $(this).attr("data-serial") }),
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: (e) => {
                            if (e.d.Status == 0) {
                                let data = e.d.Data[0];
                                $(this).attr("data-serial");
                                getOrders();
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
            }
        });
        return false;
    }
    getProducts();
});