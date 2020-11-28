using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_WFA
{
    public partial class Form_StdInfo : Form
    {
        public Form_StdInfo()
        {
            InitializeComponent();
        }

        private void Form_StdInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“stdInfoDataSet.T_StdInfo”中。您可以根据需要移动或删除它。
            this.t_StdInfoTableAdapter.Fill(this.stdInfoDataSet.T_StdInfo);
        }

        private void Menu_Create_Click(object sender, EventArgs e)
        {
            Form_Create fc = new Form_Create();
            fc.ShowDialog();
        }

        private void Menu_Retrieve_Click(object sender, EventArgs e)
        {
            Form_Retrieve fr = new Form_Retrieve();
            fr.ShowDialog();
        }

        private void Menu_Update_Click(object sender, EventArgs e)
        {
            Form_Update fu = new Form_Update();
            fu.ShowDialog();
        }

        private void Menu_Delete_Click(object sender, EventArgs e)
        {
            Form_Delete fd = new Form_Delete();
            fd.ShowDialog();
        }

        private void Menu_Refresh_Click(object sender, EventArgs e)
        {
            this.t_StdInfoTableAdapter.Fill(this.stdInfoDataSet.T_StdInfo);
        }
    }
}