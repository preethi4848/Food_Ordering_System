<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminRegistration.aspx.cs" Inherits="Food_Order.AdminRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>New Admin Registration</h2>
            <p>
                Enter the Name:
                <asp:TextBox runat="server" ID="txtName" />
                <asp:RequiredFieldValidator ErrorMessage="Name is required" ControlToValidate="txtName" runat="server" ForeColor="IndianRed" />
            </p>
            <p>
                Enter the Email Address:
                <asp:TextBox runat="server" ID="txtAddress" />
                <asp:RegularExpressionValidator ErrorMessage="Email is not in a proper format" ForeColor="IndianRed" ControlToValidate="txtAddress" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is required" ForeColor="IndianRed" ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
            </p>
            <p>
                Enter the Password:
                <asp:TextBox runat="server" ID="txtPwd" TextMode="Password" />
           
                <asp:RequiredFieldValidator ErrorMessage="Password is a must" ControlToValidate="txtPwd" runat="server" ForeColor="IndianRed" />
            </p>
            <p>
                ReType the Password:
                <asp:TextBox runat="server" ID="txtRetype" TextMode="Password" />
                <asp:CompareValidator ErrorMessage="Password Mismatch" ControlToValidate="txtRetype" ControlToCompare="txtPwd" Type="String" runat="server" ForeColor="IndianRed" />

            </p>

            <p>
                <asp:Button Text="Register" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
            </p>
        </div>

    </form>
</body>
</html>
