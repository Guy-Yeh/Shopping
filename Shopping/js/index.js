var order = {};
var strHtml = `<div class="col-md-3 col-md2">
                    <div class="col-md1 simpleCart_shelfItem">
                             <img alt="" src="##picture##" height="100%" width="100%" />
                                <div class="price">
                                    <label name="productName" id="productName" >##productName##</label>
                                    <label >售價：##price##</label><br>
                                    <label >##category##</label> 
                                    <a href="#" class="home_btn" onclick="location.reload();location.href='product.aspx?productName=##productName##'">查看更多</a>                                    
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
                        str = str + strHtml.replace("##picture##", data.picture).replaceAll("##productName##", data.productName).replace("##price##", data.price).replace("##category##", data.category);

                    }                   
                }
                $('#box-list1').html(str);               
            }
        });
        return false;
    }
    getProducts();
});
