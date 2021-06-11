<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Shopping.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:TemplateField headertext="image">
                    <ItemTemplate >
                       <asp:Image ID="img1" ImageUrl='<%#Eval("picture") %>' 
                                  runat="server"  Width="200" Height="200"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br>
        <asp:GridView ID="GridView2" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate >
                       <asp:Image ID="img1" ImageUrl='<%#Eval("img") %>' 
                                  runat="server"  Width="200" Height="200" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:GridView ID="GridView3" runat="server">
            <Columns>
                
          <asp:boundfield datafield="ID"
            readonly="true"      
            headertext="ID"/>
           
          <asp:boundfield datafield="productName"
            convertemptystringtonull="true"
            headertext="productName"/>
          <asp:imagefield dataimageurlfield="picture"
            convertemptystringtonull="true"
            headertext="picture">
              <ControlStyle Height="100px" Width="100px"/>
              </asp:imagefield>
          <asp:boundfield datafield="category"
            convertemptystringtonull="true"
            headertext="category"/>
          <asp:boundfield datafield="inventory"
            convertemptystringtonull="true"
            headertext="inventory"/>
          <asp:boundfield datafield="price"
            convertemptystringtonull="true"
            headertext="price"/>
           <asp:boundfield datafield="initdate"
            convertemptystringtonull="true"
            headertext="initdate"/>
        </Columns>
            
        </asp:GridView>
    </form>
</body>
</html>
