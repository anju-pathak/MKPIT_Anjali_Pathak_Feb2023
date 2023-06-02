<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="image.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Image<br />
        </div>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/adv.xml" OnAdCreated="AdRotator1_AdCreated" />
    </form>
</body>
</html>
