<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="webAppAspNet.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Homepage</title>
</head>
<body style="height: 114px">
    <form id="mainForm" runat="server">
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Clicked_Btn"/>
        </p>
        <p>
            <asp:Label ID="name" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="surname" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
