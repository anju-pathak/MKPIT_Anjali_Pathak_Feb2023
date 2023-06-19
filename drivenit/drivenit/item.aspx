<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="item.aspx.cs" Inherits="drivenit.item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Item Master</p>
<p>
        itemid&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</p>
    <p>
        ItemDescr<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <br />
    BalQty<asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <br />
    createdon<asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
&nbsp;<br />
    <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="EDIT" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="DELETE" OnClick="Button3_Click" />
</asp:Content>
