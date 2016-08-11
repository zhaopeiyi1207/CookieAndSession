<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="CookieSession.Cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:Button runat="server" ID="btnSet" Text="设置" OnClick="btnSet_Click"/>
      <asp:Button runat="server" ID="btnGet" Text="取值" OnClick="btnGet_Click"/>
    </div>
    </form>
</body>
</html>
