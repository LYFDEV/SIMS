<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStdInfo.aspx.cs" Inherits="DeleteStdInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>删除学生信息</title>
    <link rel="shortcut icon" type="image/x-icon" href="images/icon/LYF_UB_64.ico" media="screen" />
    <style type="text/css">
        body {
            background-image: url(images/5791d8281f685.jpg);
            background-position: center center;
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
        }
        #DeleteStdInfo
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
    <form id="form_DeleteStdInfo" runat="server">
        <div align="center" id="DeleteStdInfo">
            <center>
                <h1>删除学生信息</h1>
            </center>
            <p>
                <a>仅支持通过学号删除学生信息</a><br /><a>&emsp;</a><br />
                <asp:Label ID="lb_StdNum" runat="server">学 &emsp; 号：</asp:Label>
                <asp:TextBox ID="tb_StdNum" runat="server"></asp:TextBox>
            </p>
            <p>
                <a>请输入超级管理员用户和密码以完成删除</a><br /><a>&emsp;</a><br />
                <asp:Label ID="lb_SAdminName" runat="server">用 户 名：</asp:Label>
                <asp:TextBox ID="tb_SAdminName" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="lb_SPassword" runat="server">密 &emsp; 码：</asp:Label>
                <asp:TextBox ID="tb_SPassword" runat="server" TextMode="Password"></asp:TextBox><br />
            </p>

            <p>                
                <asp:Button ID="btn_Delete" runat="server" Text="删除信息" OnClick="btn_Delete_Click"/>
                <asp:Button ID="btn_Clear" runat="server" Text="清空内容" OnClick="btn_Clear_Click"/>
            </p>
        </div>
    </form>
</body>
</html>
