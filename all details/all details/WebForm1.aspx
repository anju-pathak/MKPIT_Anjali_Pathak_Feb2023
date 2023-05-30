<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="all_details.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 118px;
        }
        .auto-style3 {
            width: 118px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Details<br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Address</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">password</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">city<br />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>nagpur</asp:ListItem>
                            <asp:ListItem>delhi</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Date of birth</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="DateTime"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">hobbies</td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="reading" />
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="music" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Gender</td>
                    <td>
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="female" />
                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="gender" Text="male" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">email</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ok" />
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">mobile_number</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
