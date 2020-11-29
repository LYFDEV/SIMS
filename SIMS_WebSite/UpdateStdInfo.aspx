<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateStdInfo.aspx.cs" Inherits="UpdateStdInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>更新学生信息</title>
    <link rel="shortcut icon" type="image/x-icon" href="images/icon/LYF_UB_64.ico" media="screen" />
        <style type="text/css">
        body {
            background-image: url(images/5791d8281f685.jpg);
            background-position: center center;
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
        }
        #UpdateStdInfo
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
    <form id="form_UpdateStdInfo" runat="server">
        <div align="center" id="UpdateStdInfo">
            <center>
                <h1>更新学生信息</h1>
            </center>

            <p>
                 <asp:Label ID="lb_OldName" runat="server">旧&nbsp; &emsp; 名：</asp:Label>
                 <asp:TextBox ID="tb_OldName" runat="server"></asp:TextBox>
            </p>

            <p>
                <asp:Label ID="lb_StdNum" runat="server">学&nbsp; &emsp; 号：</asp:Label>
                <asp:TextBox ID="tb_StdNum" runat="server"></asp:TextBox>
            </p>

            <p>
                 <asp:Label ID="lb_Name" runat="server">姓&nbsp; &emsp; 名：</asp:Label>
                 <asp:TextBox ID="tb_Name" runat="server"></asp:TextBox>
            </p>

            <p>
                 <asp:Label ID="lb_Email" runat="server">电子邮箱：</asp:Label>
                 <asp:TextBox ID="tb_Email" runat="server"></asp:TextBox>
            </p>

            <p>
                 <asp:Label ID="lb_PN" runat="server">联系方式：</asp:Label>
                 <asp:TextBox ID="tb_PN" runat="server"></asp:TextBox>
            </p>
            <p>
                 <asp:Button ID="btn_Update" runat="server" Text="更新信息" OnClick="btn_Update_Click" /> 
                 <asp:Button ID="btn_Clear" runat="server" Text="清空内容" OnClick="btn_Clear_Click" />
            </p>
        </div>
    </form>
</body>
</html>
