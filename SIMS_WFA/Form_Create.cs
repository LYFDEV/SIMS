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

namespace SIMS_WFA
{
    public partial class Form_Create : Form
    {
        public Form_Create()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (tb_StdNum.Text != "" && tb_Name.Text != "")
            {
                StdInfoBLL sib = new StdInfoBLL();
                int result = sib.AddInfo(tb_StdNum.Text, tb_Name.Text, tb_Sex.Text, tb_Nation.Text, tb_Email.Text, tb_PN.Text);
                MessageBox.Show($"已添加{result}条数据");
            }
            else
            {
                MessageBox.Show("请输入基本信息");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_PN.Text = tb_Email.Text = tb_Name.Text = tb_Nation.Text = tb_Sex.Text = tb_StdNum.Text = "";
        }
    }
}
