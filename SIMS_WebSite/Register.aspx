<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>学生信息管理系统管理员用户注册页面</title>
    <link rel="shortcut icon" type="image/x-icon" href="images/icon/LYF_UB_64.ico" media="screen" />
    <style type="text/css">
        body
        {
            background-image: url(images/5791d8281f685.jpg);
            background-position:center center;
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
        }
        #Register 
        {
            border: 1px;
            width: 30%;
            text-align: center;
            margin: 0 auto;
            background: #00000080;
            padding: 20px 50px;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form_Register" runat="server">
        <div align="center" id="Register">
            <center>
                <h1>管理员注册页面</h1>
            </center>
            <p>
                <asp:Label ID="lb_AdminNmae" runat="server">用 户 名：</asp:Label>
                <asp:TextBox ID="tb_AdminName" runat="server"></asp:TextBox><br />
                <a>（用户名不能为空，长度小于24）</a>
            </p>

            <p>
                <asp:Label ID="lb_Password" runat="server">密 &emsp; 码：</asp:Label>
                <asp:TextBox ID="tb_Password" runat="server" TextMode="Password"></asp:TextBox><br />
                <a>（密码不能为空，长度小于20）</a>
                
            </p>

            <p>
                <asp:Label ID="lb_Confirm" runat="server">确认密码：</asp:Label>
                <asp:TextBox ID="tb_Confirm" runat="server" TextMode="Password"></asp:TextBox><br />
            </p>

            <p>
                <a>请输入超级管理员用户和密码以完成注册</a><br /><a>&emsp;</a><br />
                <asp:Label ID="lb_SAdminName" runat="server">用 户 名：</asp:Label>
                <asp:TextBox ID="tb_SAdminName" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="lb_SPassword" runat="server">密 &emsp; 码：</asp:Label>
                <asp:TextBox ID="tb_SPassword" runat="server" TextMode="Password"></asp:TextBox><br />
            </p>

            <p>                
                <asp:Button ID="btn_Register" runat="server" Text="注册" OnClick="btn_Register_Click"/>
                <asp:Button ID="btn_Clear" runat="server" Text="清空" OnClick="btn_Clear_Click"/>
            </p>
        </div>
    </form>
</body>
</html>
