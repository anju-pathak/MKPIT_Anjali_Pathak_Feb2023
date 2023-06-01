<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="customervalidation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            custome validation<br />
            <br />
            <br />
            Date of birth<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="CustomValidator" OnServerValidate="CustomValidator1_ServerValidate">Enter correct date</asp:CustomValidator>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="ok" OnClick="Button1_Click" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
