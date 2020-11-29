using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIMS.BLL;
using SIMS.Model;

public partial class Login : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e) { }
    protected void btn_Login_Click(object sender, EventArgs e)
    {
        AdminInfoBLL aib = new AdminInfoBLL();
        List<AdminInfoModel> lAim = aib.GetAdminInfon();

        //用于判断用户名是否正确
        bool isAdminExit = false;
        //用于判断密码是否正确
        bool isPasswordRight = false;
        //用户名和密码不为空
        if (tb_AdminName.Text != "" && tb_Password.Text != "")
        {
            for (int i = 0; i < lAim.Count; i++)
            {   //判断用户名是否正确
                if (tb_AdminName.Text == lAim[i].AdminName)
                    isAdminExit = true;
            }
            if (isAdminExit)    //用户名存在（用户名填写正确）
            {
                for (int j = 0; j < lAim.Count; j++)
                {
                    if (tb_Password.Text == lAim[j].Password)   //判断密码是否正确
                        isPasswordRight = true;
                }
                if(isPasswordRight)//密码正确
                {
                    Response.Write(@"<script>location.href='Handler_ShowStdInfo.ashx';</script>");
                }
                else//密码错误
                {
                    Response.Write(@"<script>alert('密码错误');</script>");
                }
            }
            else                //用户名不存在（用户名填写错误）
            {
                Response.Write(@"<script>alert('该用户不存在，请检查用户名是否正确');</script>");
            }
        }
        else    //用户名或密码为空
        {
            Response.Write(@"<script>alert('请输入用户名或密码');</script>");
        }
    }

    protected void btn_Clear_Click(object sender, EventArgs e)
    {
        tb_AdminName.Text = tb_Password.Text = "";
    }

    protected void btn_Register_Click(object sender, EventArgs e)
    {
        Response.Write(@"<script>location.href='Register.aspx';</script>");
    }
}