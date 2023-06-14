<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="trustProject.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <br />
        Transcation Details</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" Checked="True" GroupName="mode" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Issue" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="mode" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Purchase" />
    </p>
    <p>
        Item Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </p>
    <p>
        Transcation Date&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Department_Name "></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="department_Name" DataValueField="department_id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Trust1ConnectionString %>" ProviderName="<%$ ConnectionStrings:Trust1ConnectionString.ProviderName %>" SelectCommand="SELECT [department_id], [department_Name] FROM [department_mast]"></asp:SqlDataSource>
    </p>
    <asp:Panel ID="Panel1" runat="server">
        vendor Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="vender_name" DataValueField="vendor_id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Trust1ConnectionString %>" SelectCommand="SELECT [vendor_id], [vender_name] FROM [vendor_mast]"></asp:SqlDataSource>
    </asp:Panel>
    <p>
        <br __designer:mapid="d" />
        <br __designer:mapid="e" />
        quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Button" />
    </p>
<p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
</asp:Content>
