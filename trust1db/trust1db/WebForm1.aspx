<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="trust1db.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Transaction Details</p>
    <p>
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="mode" Text="Issue" OnCheckedChanged="RadioButton1_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="mode" Text="Purchase" OnCheckedChanged="RadioButton2_CheckedChanged" />
    </p>
    <p>
        Item name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="item_name" DataValueField="item_id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Trust1ConnectionString %>" SelectCommand="SELECT [item_id], [item_name] FROM [item_master]"></asp:SqlDataSource>
    </p>
    <p>
        Trancation Date&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <asp:Panel ID="Panel1" runat="server">
        Department Name<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="department_Name" DataValueField="department_id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Trust1ConnectionString %>" ProviderName="<%$ ConnectionStrings:Trust1ConnectionString.ProviderName %>" SelectCommand="SELECT [department_id], [department_Name] FROM [department_mast]"></asp:SqlDataSource>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        vendor Name&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="vender_name" DataValueField="vendor_id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Trust1ConnectionString %>" SelectCommand="SELECT [vendor_id], [vender_name] FROM [vendor_mast]"></asp:SqlDataSource>
    </asp:Panel>
    <br />
    <br />
    quantity
<asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
</asp:Content>
