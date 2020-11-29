using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIMS.BLL;

public partial class UpdateStdInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) { }
    protected void btn_Update_Click(object sender, EventArgs e)
    {
        StdInfoBLL sib = new StdInfoBLL();
        if (tb_StdNum.Text != "" && tb_OldName.Text != "" && tb_Name.Text != "" && tb_Email.Text != "" && tb_PN.Text != "")
        {
            if (sib.UpdateInfo(tb_OldName.Text, tb_StdNum.Text, tb_Name.Text, tb_Email.Text, tb_PN.Text) > 0)
            {
                Response.Write("<script>alert('更新成功');location.href='Handler_ShowStdInfo.ashx';</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('请将信息填写完整');</script>");
        }
    }

    protected void btn_Clear_Click(object sender, EventArgs e)
    {
        tb_StdNum.Text = tb_OldName.Text = tb_Name.Text = tb_Email.Text = tb_PN.Text = "";
    }
}