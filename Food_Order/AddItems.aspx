<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddItems.aspx.cs" Inherits="Food_Order.AddItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Enter the Food name:"></asp:Label>
        &nbsp;<asp:TextBox ID="Name" runat="server" Width="304px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter the image url:"></asp:Label>
        <%--&nbsp;&nbsp;&nbsp;--%>
        <%--<br />
        <br />--%>
        <asp:TextBox ID="image" runat="server" Width="308px"></asp:TextBox>
        <%--<asp:FileUpload ID="FileUpload1" runat="server" Width="439px" />
        <br/>--%>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Enter the Price:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="price" runat="server" Width="308px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Enter the Count:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Count" runat="server" Width="308px"></asp:TextBox>
        <br />
        <br />
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="197px" />
        </p>
    </form>
</body>
</html>
