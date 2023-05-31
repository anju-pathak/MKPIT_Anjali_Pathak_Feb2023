<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Details1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            width: 118px;
        }
        .auto-style5 {
            width: 118px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Details</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">Country</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>Nepal</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">City</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                        <asp:ListItem>Nagpur</asp:ListItem>
                        <asp:ListItem Selected="True">mumbai</asp:ListItem>
                        <asp:ListItem>bharatpur</asp:ListItem>
                        <asp:ListItem>kathmandu</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">course</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem>java</asp:ListItem>
                        <asp:ListItem>c</asp:ListItem>
                        <asp:ListItem>c#</asp:ListItem>
                        <asp:ListItem>.net</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Center</td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server">
                        <asp:ListItem>Nagpur</asp:ListItem>
                        <asp:ListItem>mumbai</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
&nbsp;</p>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="data:image/jpeg;base64,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" />
    </form>
</body>
</html>
