<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateItems.aspx.cs" Inherits="Food_Order.UpdateItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Enter the Food Id:"></asp:Label>
            &nbsp;<asp:TextBox ID="FoodId" runat="server" Width="304px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Enter the Food name:"></asp:Label>
            &nbsp;<asp:TextBox ID="Name" runat="server" Width="304px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter the image url:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="image" runat="server" Width="308px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Enter the Price:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="price" runat="server" Width="308px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Enter the Count:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Count" runat="server" Width="308px"></asp:TextBox>
            <br />
            <br />
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button3_Click" Text="Update" Width="197px" />
            </p>
        </div>
    </form>
</body>
</html>
