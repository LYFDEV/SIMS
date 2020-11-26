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
    public partial class Form_Retrieve : Form
    {
        public Form_Retrieve()
        {
            InitializeComponent();
        }

        private void bt_Retrieve_Click(object sender, EventArgs e)
        {
            if (tb_StdNum.Text != "")
            {
                StdInfoBLL sib = new StdInfoBLL();
                StdInfoModel sim = sib.GetInfoByNum(tb_StdNum.Text);
                string result = $"{sim.StdNum}/{sim.Name}/{sim.Sex}/{sim.Nation}/{sim.E_Mail}/{sim.PhoneNumber}";
                listBox_Result.Items.Add(result);
                tb_StdNum.Text = "";
            }
            else
            {
                MessageBox.Show("请输入学号");
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            tb_StdNum.Text = "";
        }

        private void bt_ClearResult_Click(object sender, EventArgs e)
        {
            listBox_Result.Items.Clear();
        }
    }
}
