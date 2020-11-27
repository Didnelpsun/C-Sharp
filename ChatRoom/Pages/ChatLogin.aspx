<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChatLogin.aspx.cs" Inherits="ChatRoom.Pages.ChatLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span>我的聊天室</span>
            <span>用户名：</span><asp:TextBox ID="username" runat="server"></asp:TextBox>
            <%--<asp:RegularExpressionValidator ID="userValid" runat="server" ControlToValidate="username" ValidationExpression=""></asp:RegularExpressionValidator>--%>
            <span>密码：</span><asp:TextBox ID="password" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="passValid" runat="server" ControlToValidate="password" ValidationExpression="[A-Z a-z 0-9]+"></asp:RegularExpressionValidator>
            <asp:Button ID="login" runat="server" OnClick="Login_Click" Text="登录" />
            <asp:Label runat="server" ID="label"></asp:Label>
        </div>
    </form>
</body>
</html>
