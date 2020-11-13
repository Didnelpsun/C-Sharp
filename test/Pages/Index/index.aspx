<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="test.pages.index" EnableViewState="true" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            <div>
                <asp:TextBox ID="user" runat="server" Text="用户名" AutoPostBack="true" OnTextChanged="TextChange"/>
                <asp:Button ID="button1" Text="提交" runat="server" OnClick="Click" />
                <asp:Label ID="label" runat="server"></asp:Label>
            </div>
            <div>
                <asp:DropDownList ID="dropdown" runat="server" AutoPostBack="true" OnSelectedIndexChanged="SelectedChange"></asp:DropDownList>
                <asp:Label ID="label2" runat="server"></asp:Label>
            </div>
            <asp:DataList ID="DataList1" runat="server"></asp:DataList>
        </div>
    </form>
</body>
</html>
