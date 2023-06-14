<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="using_dll.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Enter number1
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter number2<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="width: 53px" Text="ADD" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="sub" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Mul" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Div" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;</form>
</body>
</html>
