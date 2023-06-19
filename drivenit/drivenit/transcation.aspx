<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="transcation.aspx.cs" Inherits="drivenit.transcation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Transcation details</p>
<p>
    ItemId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ItemDescr" DataValueField="ItemID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:drivenitConnectionString %>" ProviderName="<%$ ConnectionStrings:drivenitConnectionString.ProviderName %>" SelectCommand="SELECT [ItemID], [ItemDescr] FROM [ItemMaster]"></asp:SqlDataSource>
</p>
    <p>
        tranId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</p>
<p>
    transcation type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="mode" Text="Issue" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="mode" Text="received" />
</p>
<p>
    transcation qty&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
</p>
<p>
    transcation date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TransID" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="TransID" HeaderText="TransID" InsertVisible="False" ReadOnly="True" SortExpression="TransID" />
            <asp:BoundField DataField="ItemID" HeaderText="ItemID" SortExpression="ItemID" />
            <asp:BoundField DataField="TransType" HeaderText="TransType" SortExpression="TransType" />
            <asp:BoundField DataField="TransQty" HeaderText="TransQty" SortExpression="TransQty" />
            <asp:BoundField DataField="TransDate" HeaderText="TransDate" SortExpression="TransDate" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:drivenitConnectionString %>" DeleteCommand="DELETE FROM [Transactions] WHERE [TransID] = @TransID" InsertCommand="INSERT INTO [Transactions] ([ItemID], [TransType], [TransQty], [TransDate]) VALUES (@ItemID, @TransType, @TransQty, @TransDate)" SelectCommand="SELECT [TransID], [ItemID], [TransType], [TransQty], [TransDate] FROM [Transactions]" UpdateCommand="UPDATE [Transactions] SET [ItemID] = @ItemID, [TransType] = @TransType, [TransQty] = @TransQty, [TransDate] = @TransDate WHERE [TransID] = @TransID">
        <DeleteParameters>
            <asp:Parameter Name="TransID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ItemID" Type="Int32" />
            <asp:Parameter Name="TransType" Type="String" />
            <asp:Parameter Name="TransQty" Type="Int32" />
            <asp:Parameter Name="TransDate" Type="DateTime" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ItemID" Type="Int32" />
            <asp:Parameter Name="TransType" Type="String" />
            <asp:Parameter Name="TransQty" Type="Int32" />
            <asp:Parameter Name="TransDate" Type="DateTime" />
            <asp:Parameter Name="TransID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    </p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Edit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
</p>
</asp:Content>
