<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="CookieSession.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Button runat="server" Text="赋值" ID="btnSet" OnClick="btnSet_Click" />
     <asp:Button runat="server" ID="btnShow" Text="显示" OnClick="btnShow_Click" />
        <asp:Label runat="server" ID="labShow"></asp:Label>
    </div>
    </form>
</body>
</html>
