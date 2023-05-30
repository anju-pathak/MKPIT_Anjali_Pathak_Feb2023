<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 221px;
            text-align: left;
        }
        .auto-style3 {
            width: 221px;
            height: 26px;
            text-align: left;
        }
        .auto-style4 {
            height: 26px;
            text-align: left;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style5">
            <div class="auto-style6">
                MKPITS SERVICES<br />
                FORTUNE MALL<br />
                SITA BURDI NAGPUR<br />
            </div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">ENTER NUMBER1</td>
                    <td class="auto-style5">3</td>
                </tr>
                <tr>
                    <td class="auto-style3">ENTER NUMBER2</td>
                    <td class="auto-style4">4</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="SUB" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="MUL" />
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="DIv" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">RESULT</td>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
