<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="shopping._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            
            <hr />
           

              <div class="container">  
            <div class="row">  
            <div class="col-md-6" style="background-color:#EBF5F8;padding:50px";><h2><b></b>Lowest Prices<br />
                Best Quality Shopping</h2>
              
                <div class="row">
  <div class="column" style="background-color:white; text-align:center";>
    <table>
      <tr>
        <td>
            <center>
            <img src="https://images.meesho.com/images/pow/freeDelivery_jamun.svg" /><b>Free Delivery&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp|
                </center>
        </td>
        <td>  <img src="https://images.meesho.com/images/pow/cod_jamun.svg" /><b>Cash On Delivery</b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</td>
        <td> <img src="https://images.meesho.com/images/pow/easyReturns_jamun.svg" /><b>Easy Return</b></td>
      </tr>
    </table>
  </div>
</div>



<%--                 <div class="well text-center">
            <a href="#"><img src="logo2.png" class="img-responsive"/></a>
                     <img src="logo2.png" class="img-responsive"/>
         <a href="#" ><img src="logo2.png" class="img-responsive"  /></a>
    </div>--%>
                <br>
                    <img src="applogo.png" />
                    </div>
                
                     
            <div class="col-md-6"><img src="https://images.meesho.com/images/marketing/1687149525469_512.webp"/></div>  
    </div>     
            </div> 
                  

            <hr />
             <p class="lead">              
          <h2 style="text-align:center">------------------Top Categories to choose from------------------</h2></p>
          
        </section>
        <hr />
                    <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" Width="100%" BorderStyle="None">
                        <ItemTemplate>
<table cellpadding="2" cellspacing="0" border="1" style="width: 300px; height: 200px;
border: dashed 0px #04AFEF; background-color: #FFFFFF">
<tr>
<td align="center">
    <a href='<%# Eval("prodid","productdetails.aspx?prodid={0}") %>'>
<asp:Image ID="Image1" ImageUrl='<%# Bind("imgname", "~/images/{0}") %>' runat="server"

Height="100"

Width="100" />
        </a>

</td>
</tr>

<tr>
<td align="center">
<span > <%# Eval("prodname") %></span><br />
<span > <%# Eval("poddes") %></span><br />
<span ><b>Rs. <%# Eval("prodrice") %> </b>onwards</span><br />

</td>
</tr>
</table>
</ItemTemplate>
                    </asp:DataList>
                
                    
        </div>
    </main>

    </div>

</asp:Content>
