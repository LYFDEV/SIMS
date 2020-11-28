<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>学生信息管理系统登录页面</title>
    <link rel="shortcut icon" type="image/x-icon" href="images/icon/LYF_UB_64.ico" media="screen" />
</head>
<body>
    <center>
        <h1>用户登录页面</h1>
    </center>
    <form id="form_Login" runat="server">
        <div align="center">
            <p>
                <asp:Label ID="lb_AdminNmae" runat="server">用户名：</asp:Label>
                <asp:TextBox ID="tb_AdminName" runat="server"></asp:TextBox>
            </p>
 
            <p>
                <asp:Label ID="lb_Password" runat="server">密&emsp;码：</asp:Label>
                <asp:TextBox ID="tb_Password" runat="server" TextMode="Password"></asp:TextBox>
            </p>

            <p>
                <asp:Button ID="btn_Login" runat="server" Text="登录" OnClick="btn_Login_Click" /> 
                <asp:Button ID="btn_Clear" runat="server" Text="清空" OnClick="btn_Clear_Click" />
                <asp:Button ID="btn_Register" runat="server" Text="注册" OnClick="btn_Register_Click" />
            </p>
        </div>
    </form>

</body>
</html>
