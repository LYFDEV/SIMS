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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            tb_Password.PasswordChar = '*';
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            AdminInfoBLL aib = new AdminInfoBLL();
            List<AdminInfoModel> lAim = aib.GetAdminInfon();
            
            //用于判断用户名是否正确
            bool isAdminExit = false;
            //用于判断密码是否正确
            bool isPasswordRight = false;
            //用户名和密码不为空
            if (tb_AdminName.Text!=""&&tb_Password.Text!="")
            {
                for (int i= 0; i<lAim.Count; i++)
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
                    if (isPasswordRight)//密码正确
                    {
                        this.Hide();
                        new Form_StdInfo().ShowDialog();
                        Application.ExitThread();
                    }
                    else//密码错误
                    {
                        MessageBox.Show("密码错误");
                    }
                }
                else                //用户名不存在（用户名填写错误）
                {
                    MessageBox.Show("该用户不存在，请检查用户名是否正确");
                }
            }
            else    //用户名或密码为空
            {
                MessageBox.Show("请输入用户名或密码");
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Register().ShowDialog();
            Application.ExitThread();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_AdminName.Text = tb_Password.Text = "";
        }
    }
}