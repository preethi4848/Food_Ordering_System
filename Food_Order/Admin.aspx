<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Food_Order.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin page</title>
</head>
<body>


    <form id="form1" runat="server">


        <div>
        </div>

        <p>
            &nbsp;
        </p>
        <p>
            &nbsp;
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="215px" />
            &nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" Width="200px" />
            &nbsp;
                <asp:Button ID="Button3" runat="server" Text="Update" Width="197px" OnClick="Button3_Click" />
            &nbsp;
                <asp:Button ID="Button4" runat="server" Text="View" Width="245px" OnClick="Button4_Click" />
        </p>
    </form>

    <p>
        &nbsp;
    </p>

</body>
</html>
