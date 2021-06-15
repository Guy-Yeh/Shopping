<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="ShoppingList.aspx.cs" Inherits="Shopping.Customer.ShoppingList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../js/customer/orderEdit.js"> </script>
    <div class="account">
        <div class="container">
            <h1>交易紀錄</h1>

            <div id="box-list">

      
            <div class="col-md-12" style="border-style: solid; border-color: #ddd; border-width: 1px; padding: 10px;">
                <div class="col-md-12" style="padding: 10px;">
                    <div class="col-md-12" style="border-bottom-style: solid; border-color: #ddd; border-width: 1px;">
                        <div id="serialNO" class="col-md-4" style="font-size: 20px;">
                            訂單號碼：12345678900
                        </div>
                        <div id="dateNO" class="col-md-4" style="font-size: 10px;height: 27px;display: flex;align-items: flex-end;">
                            <div>訂單日期：2020/6/6-04:53:55</div>
                        </div>

                        <div id="statusTest" class="col-md-4" style="display: flex;color: #52d0c4;font-size: 22px;justify-content: flex-end;">
                            配送中
                        </div>
                    </div>
                </div>
                <div class="col-md-12" style="display: flex; padding: 10px;">
                    <div class="col-md-12" style="border-bottom-style: solid; border-color: #ddd; border-width: 1px; padding: 0px 10px 10px 10px;">
                        <div class="col-md-1" style="padding: 0px">
                            <img id="prodPic" src="../images/1.jpg" style="width: 100%" />
                        </div>
                        <div class="col-md-9">
                            <div class="col-md-12" style="word-wrap: break-word">df15s1f65sd1f65sd1f65sd1f65sd1f6sd51f65sd1f6sd51f65sd1f6sd5f16sd1f69sdf98sd4g65sd1g6ds5g19ds51g456sd1g6sd5s98dg49s5dg195sd195sdg965sdg96d8g9sd4g89sd4g6165sd1g3s5dg136sgd</div>
                            <div class="col-md-12">2</div>

                        </div>
                        <div class="col-md-2" style="height: 100%; display: flex; align-items: center; justify-content: flex-end;">
                            $500
                        </div>
                    </div>
                </div>


                <div class="col-md-12" style="display: flex;">
                    <div class="col-md-9">
                        <div id="contName">姓名：小惠</div>
                        <div id="contPhone">電話：0912345678</div>
                        <div id="contAddress">地址：台中</div>   
                    </div>
                    <div class="col-md-3" style="display: flex; justify-content: flex-end;">
                        訂單金額: <span style="font-size: 20px; color: #52d0c4; padding: 0px 0px 0px 10px;">$123456</span>
                    </div>
                </div>


                <div class="col-md-12" style="display: flex;">
                    <div class="col-md-12" style="display: flex; justify-content: flex-end;">
                        <%--<button id="againBuy" type="button" class="btn btn-lg btn-info" style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                         </button>--%>
                    </div>
                </div>

            </div>
                      </div>

        </div>
    </div>
    <div>
<%--    <button id="btnSHClick" type="button" class="btn btn-lg btn-info"
                        style="border-radius: 0px; background: #52d0c4; padding: 5px 10px;">
                        驗證使用者</button>--%>
    </div>
    <%--            <div class="shopping_grid">

                <div>
                    <asp:GridView ID="ordersGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                            <asp:BoundField DataField="serial" HeaderText="serial" SortExpression="serial" />
                            <asp:BoundField DataField="customerAccount" HeaderText="customerAccount" SortExpression="customerAccount" />
                            <asp:BoundField DataField="productName" HeaderText="productName" SortExpression="productName" />
                            <asp:BoundField DataField="productColor" HeaderText="productColor" SortExpression="productColor" />
                            <asp:BoundField DataField="productPrice" HeaderText="productPrice" SortExpression="productPrice" />
                            <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
                            <asp:BoundField DataField="cart" HeaderText="cart" SortExpression="cart" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OrderDetailConnectionString %>" SelectCommand="SELECT * FROM [OrderDetail]"></asp:SqlDataSource>--%>
</asp:Content>

