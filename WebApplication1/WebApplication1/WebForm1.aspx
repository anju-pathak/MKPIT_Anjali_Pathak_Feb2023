<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 147px;
        }
        .auto-style4 {
            width: 147px;
        }
    </style>
</head>
<body>
    <p style="font-weight: 700; color: #003300; text-align: center">
        &nbsp;</p>
    <p style="font-weight: 700; color: #003300; text-align: center">
        MKPITS SERVIES</p>
    <p style="font-weight: 700; color: #003300; text-align: center">
        &nbsp;</p>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Enter number 1</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Enter number 2</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Result</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <p style="font-weight: 700; color: #003300">
            &nbsp;</p>
        <div>
        </div>
    </form>
</body>
</html>
