<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="Shopping.Customer.Chat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--  <form id="formchat" runat="server">--%>

    <script src="../js/customer/customerDetail.js"> </script>


    <!-- 內容 -->
    <div class="account">
        <div class="container">
            <h1>留言訊息</h1>
            <div class="chat_grid">

                <div>


                    <asp:GridView ID="chatGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID">
                        <Columns>

                            <%--<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" InsertVisible="False" ReadOnly="True" />--%>
                            <%--<asp:BoundField DataField="account" HeaderText="account" SortExpression="account" />--%>
                            <asp:BoundField DataField="message" HeaderText="訊息" SortExpression="message" />       
                            <asp:BoundField DataField="initdate" HeaderText="留言時間" SortExpression="initdate" />
                            <asp:BoundField DataField="response" HeaderText="回覆" SortExpression="response" />
                            <asp:BoundField DataField="updateInitdate" HeaderText="回覆時間" SortExpression="updateInitdate" />
                        </Columns>
                    </asp:GridView>

                    <div style="font-size: 20px;color:#52d0c4;font-family:DFKai-sb;font-weight:bold;font-style:italic;">
                    <span>我要留言</span>
                        </div>
                    <div class="col-md-10 login-left">
                        <%--<asp:TextBox ID="costomerTextBox" placeholder="Response" name="costomerTextBox" style="resize: none;" runat="server" Width="100%" Height="100px" TextMode="MultiLine"></asp:TextBox>--%>
                         <textarea rows="5" id="costomerTextBox" style="width:100%;height:100px;" name="costomerTextBox" class="form-control" placeholder="留言..." ></textarea>
                    </div>
                    <div class="col-md-2 login-left">

                        <div style="display: flex;align-items: flex-end; Height:100px;color: white;">
                            <asp:Button ID="keyin" style="font-size: 16px;" runat="server" Text="留言" BackColor="#52D0C4" BorderColor="#52D0C4" CssClass="btn" OnClick="keyin_Click" />
                        </div>

                        
                    </div>



                </div>
            </div>
        </div>
    </div>


    <%--    </form>--%>

&nbsp;
</asp:Content>
