using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIMS.BLL;
using SIMS.Model;

public partial class DeleteStdInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btn_Delete_Click(object sender, EventArgs e)
    {
        StdInfoBLL sib = new StdInfoBLL();
        List<StdInfoModel> lSib = sib.GetAllInformation();
        SuperAdminInfoBLL saib = new SuperAdminInfoBLL();
        List<SuperAdminInfoModel> lSaim = saib.GetSuperAdminInfo();
        bool isSAdminExit = false;
        if (tb_StdNum.Text != "" && tb_SAdminName.Text != "" && tb_SPassword.Text != "")//信息完整
        {
            for (int i = 0; i < lSaim.Count; i++)
            {
                if (tb_SAdminName.Text == lSaim[i].SAdminName && tb_SPassword.Text == lSaim[i].SPassword)
                    isSAdminExit = true;
            }
            if (isSAdminExit)
            {
                sib.DeleteInfoByNum(tb_StdNum.Text);
                Response.Write(@"<script>alert('删除成功');</script>");
                Response.Write(@"<script>location.href='Handler_ShowStdInfo.ashx';</script>");
            }
            else
            {
                Response.Write(@"<script>alert('超级管理员用户或密码错误');</script>");
            }
        }
        else//信息不完整
        {
            Response.Write(@"<script>alert('请输入信息');</script>");
        }
    }

    protected void btn_Clear_Click(object sender, EventArgs e)
    {
        tb_StdNum.Text = tb_SAdminName.Text = tb_SPassword.Text = "";
    }
}