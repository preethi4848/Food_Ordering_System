<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Food_Order.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Enter the Name:
                <asp:TextBox runat="server" ID="txtName" />
                <asp:RequiredFieldValidator ErrorMessage="Please Enter the name" ControlToValidate="txtName" runat="server" ForeColor="IndianRed" />
            </p>
            <p>
                Enter the Password:
                <asp:TextBox runat="server" ID="txtPwd" TextMode="Password" />
                <asp:RequiredFieldValidator ErrorMessage="Please Enter the password" ControlToValidate="txtPwd" runat="server" ForeColor="IndianRed" />
            </p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="margin-left: 206px" Text="Login" Width="177px" />

        </div>


    </form>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
