<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="ShoppingList.aspx.cs" Inherits="Shopping.Customer.ShoppingList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Sopping4
    <asp:GridView ID="ordersGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="serial" HeaderText="serial" SortExpression="serial" />
            <asp:BoundField DataField="customerID" HeaderText="customerID" SortExpression="customerID" />
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="cellphone" HeaderText="cellphone" SortExpression="cellphone" />
            <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
            <asp:BoundField DataField="initade" HeaderText="initade" SortExpression="initade" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OrdersConnectionString %>" SelectCommand="SELECT * FROM [Orders]"></asp:SqlDataSource>
</asp:Content>

