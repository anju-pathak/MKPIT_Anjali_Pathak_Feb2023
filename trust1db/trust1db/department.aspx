<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="trust1db.department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Department&nbsp; Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Department Id
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="update" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="search" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
