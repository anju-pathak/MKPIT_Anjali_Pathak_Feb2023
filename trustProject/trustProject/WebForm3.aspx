<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="trustProject.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        Transcation Details</p>
    <p>
        Transcation Date&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" TextMode="DateTime"></asp:TextBox>
        <br __designer:mapid="d" />
        <br __designer:mapid="e" />
        quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="modify" OnClick="Button2_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Delete" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Update" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Button" />
    </p>
<p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
<p>
        &nbsp;</p>
<p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
</asp:Content>
