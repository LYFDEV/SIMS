<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RetrieveStdInfo.aspx.cs" Inherits="RetrieveStdInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>查询学生信息</title>
    <link rel="shortcut icon" type="image/x-icon" href="images/icon/LYF_UB_64.ico" media="screen" />
    <style type="text/css">
        body {
            background-image: url(images/5791d8281f685.jpg);
            background-position: center center;
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
        }
        #RetrieveStdInfo
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
    <form id="form_RetrieveStdInfo" runat="server">
        <div align="center" id="RetrieveStdInfo">
            <centre>
                <h1>查询学生信息</h1>
            </centre>
            <p>
                <a>请输入超级管理员用户和密码以完成注册</a><br /><a>&emsp;</a><br />
                <asp:Label ID="lb_StdNum" runat="server">用 户 名：</asp:Label>
                <asp:TextBox ID="tb_StdNum" runat="server"></asp:TextBox><a>&emsp;</a><a>&emsp;</a>
                <asp:Button ID="btn_Retrieve" runat="server" Text="查询信息" OnClick="btn_Retrieve_Click"/><a>&emsp;</a>
                <asp:Button ID="btn_Clear" runat="server" Text="清空内容" OnClick="btn_Clear_Click"/>
            </p>
            <asp:ListBox ID="listBox_Result" runat="server"></asp:ListBox><br /><a>&emsp;</a><br />
            <asp:Button ID="btn_ClearResult" runat="server" Text="清空查询结果" OnClick="btn_ClearResult_Click"/>
            
        </div>
    </form>
</body>
</html>