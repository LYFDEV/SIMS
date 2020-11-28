using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIMS.BLL;
using SIMS.Model;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) { }

    protected void btn_Register_Click(object sender, EventArgs e)
    {
        AdminInfoBLL aib = new AdminInfoBLL();
        SuperAdminInfoBLL saib = new SuperAdminInfoBLL();
        List<AdminInfoModel> lAim = aib.GetAdminInfon();
        List<SuperAdminInfoModel> lSaim = saib.GetSuperAdminInfo();
        //用于判断用户是否存在
        bool isRegistered = false;
        //信息不为空
        if (tb_AdminName.Text != "" && tb_Password.Text != "" && tb_Confirm.Text != "" && tb_SAdminName.Text != "" && tb_SPassword.Text != "")
        {
            //判断用户名是否存在
            for (int i = 0; i < lAim.Count; i++)
            {
                if (tb_AdminName.Text == lAim[i].AdminName)
                    isRegistered = true;
            }
            //用户不存在
            if (!isRegistered)
            {
                //两次密码一致
                if (tb_Password.Text == tb_Confirm.Text)
                {
                    for (int j = 0; j < lSaim.Count; j++)
                    {
                        //超级管理员用户和密码正确
                        if (tb_SAdminName.Text == lSaim[j].SAdminName && tb_SPassword.Text == lSaim[j].SPassword)
                        {
                            aib.AddAdmin(tb_AdminName.Text, tb_Password.Text);
                            Response.Write(@"<script>alert('注册成功');</script>");
                            Response.Write(@"<script>location.href='Login.aspx';</script>");
                        }
                        //超级管理员用户和密码错误
                        else
                        {
                            Response.Write(@"<script>alert('超级管理员用户或密码错误');</script>");
                        }
                    }
                }
                //两次密码不一致
                else
                {
                    Response.Write(@"<script>alert('两次输入的密码不一致');</script>");
                }
            }
            //用户存在
            else
            {
                Response.Write(@"<script>alert('该用户已存在');</script>");
            }
        }
        //信息为空
        else
        {
            Response.Write(@"<script>alert('请将输入完整信息');</script>");
        }
    }

    protected void btn_Clear_Click(object sender, EventArgs e)
    {
        tb_AdminName.Text = tb_Password.Text = tb_Confirm.Text = tb_SAdminName.Text = tb_SPassword.Text = "";
    }
}