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
    public partial class Form_Delete : Form
    {
        public Form_Delete()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tb_StdNum.Text != "")
            {
                StdInfoBLL sib = new StdInfoBLL();
                int result = sib.DeleteInfoByNum(tb_StdNum.Text);
                MessageBox.Show($"已删除{result}条数据");
                tb_StdNum.Text = "";
            }
            else
            {
                MessageBox.Show($"请输入学号");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_StdNum.Text = "";
        }
    }
}
