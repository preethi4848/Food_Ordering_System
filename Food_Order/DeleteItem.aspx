<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteItem.aspx.cs" Inherits="Food_Order.DeleteItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            <asp:Label ID="Label4" runat="server" Text="Enter the Food Name:"></asp:Label>
            <br />
            <asp:TextBox ID="FoodName" runat="server" Width="304px"></asp:TextBox>
            <br />
            <br />
              <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" Width="197px" />
        </p>
        </div>

    </form>
</body>
</html>
