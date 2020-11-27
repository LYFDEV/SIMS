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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_StdInfo().ShowDialog();
            //Application.ExitThread();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Register().ShowDialog();
            //Application.ExitThread();
        }
    }
}
