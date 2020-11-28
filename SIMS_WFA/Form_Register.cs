using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMS.BLL;
using SIMS.Model;

namespace SIMS_WFA
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            tb_Password.PasswordChar = tb_Confirm.PasswordChar = tb_SPassword.PasswordChar = '*';
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            AdminInfoBLL aib = new AdminInfoBLL();
            SuperAdminInfoBLL saib = new SuperAdminInfoBLL();
            List<AdminInfoModel> lAim = aib.GetAdminInfon();
            List<SuperAdminInfoModel> lSaim = saib.GetSuperAdminInfo();
            //用于判断用户是否存在
            bool isRegistered = false;
            //信息不为空
            if (tb_AdminName.Text!=""&&tb_Password.Text != "" &&tb_Confirm.Text != "" &&tb_SAdminName.Text != "" &&tb_SPassword.Text != "" )
            {
                //判断用户名是否存在
                for(int i = 0; i<lAim.Count; i++)
                {
                    if (tb_AdminName.Text == lAim[i].AdminName)
                        isRegistered = true;
                }
                //用户不存在
                if(!isRegistered)
                {
                    //两次密码一致
                    if (tb_Password.Text == tb_Confirm.Text)
                    {
                        for(int j = 0; j<lSaim.Count; j++)
                        {
                            //超级管理员用户和密码正确
                            if (tb_SAdminName.Text == lSaim[j].SAdminName && tb_SPassword.Text == lSaim[j].SPassword)
                            {
                                aib.AddAdmin(tb_AdminName.Text, tb_Password.Text);
                                MessageBox.Show("注册成功");
                                this.Hide();
                                new Form_Login().ShowDialog();
                                Application.ExitThread();
                            }
                            //超级管理员用户和密码错误
                            else
                            {
                                MessageBox.Show("超级管理员用户或密码错误");
                            }
                        }
                    }
                    //两次密码不一致
                    else
                    {
                        MessageBox.Show("两次输入的密码不一致");
                    }
                }
                //用户存在
                else
                {
                    MessageBox.Show("该用户已存在");
                }
            }
            //信息为空
            else
            {
                MessageBox.Show("请将输入完整信息");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_AdminName.Text = tb_Password.Text = tb_Confirm.Text = tb_SAdminName.Text = tb_SPassword.Text = "";
        }
    }
}