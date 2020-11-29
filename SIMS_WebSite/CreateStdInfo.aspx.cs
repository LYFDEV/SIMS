using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIMS.BLL;

public partial class CreateStdInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) { }

    protected void btn_Create_Click(object sender, EventArgs e)
    {
        if (tb_StdNum.Text != "" && tb_Name.Text != "" &&tb_Sex.Text!=""&&tb_Nation.Text != "" &&tb_Email.Text != "" &&tb_PN.Text != "" )
        {
            StdInfoBLL sib = new StdInfoBLL();
            sib.AddInfo(tb_StdNum.Text, tb_Name.Text, tb_Sex.Text, tb_Nation.Text, tb_Email.Text, tb_PN.Text);
            Response.Write(@"<script>alert('成功创建1条学生信息');</script>");
            Response.Write(@"<script>location.href='Handler_ShowStdInfo.ashx';</script>");
        }
        else
        {
            Response.Write(@"请输入基本信息");
        }
    }

    protected void btn_Clear_Click(object sender, EventArgs e)
    {
        tb_StdNum.Text = tb_Name.Text = tb_Sex.Text = tb_Nation.Text = tb_Email.Text = tb_PN.Text = "";
    }
}