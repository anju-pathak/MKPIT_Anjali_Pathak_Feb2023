<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="shopping.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="Panel1" runat="server">


        <span style="color: rgb(53, 53, 67); font-family: &quot;Mier bold&quot;; font-size: 20px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 700; letter-spacing: 0.5px; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"><br />
        <br />
            <html>
  
<head>
   
  
    <style>
        #Geek_p {
            font-size: 30px;
            color: green;
        }
  
        h1,
        h2 {
            font-family: impact;
        }
    </style>
</head>
  
<body>
    <center>
   
    <h2>
        Sign Up to save your order
    </h2>
  
    <form>
        Phone No.:
        <input type="tel" 
            placeholder="Enter phone number" maxlength="10" />
        <br />
        <br />
           <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
           <a style="border=1;color:white;text-decoration:none; padding:10px;border-
radius:15px;background-color:rebeccapurple; " href="check.aspx" >Get OTP</a>
      
        </center>
    </form>
</body>
               
        </span>
    </asp:Panel>

</asp:Content>
