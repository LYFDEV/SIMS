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
    public partial class Form_Update : Form
    {
        public Form_Update()
        {
            InitializeComponent();
        }

        private void tb_Update_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "" && tb_PN.Text != "")
            {
                StdInfoBLL sib = new StdInfoBLL();
                int result = sib.UpdatePN(tb_PN.Text, tb_Name.Text);
                MessageBox.Show($"已更新{result}条数据");
                tb_Name.Text = tb_PN.Text = "";
            }
            else
            {
                MessageBox.Show($"请输入姓名与新手机号");
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            tb_Name.Text = tb_PN.Text = "";
        }
    }
}
