using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepingAccounts
{
    public partial class admin1 : Form
    {
        public admin1()
        {
            InitializeComponent();
        }


        private void 查看学生列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin11 admin = new admin11();
            admin.ShowDialog();
        }

        private void 查看队伍列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin12 admin = new admin12();
            admin.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin13 admin = new admin13();
            admin.ShowDialog();
        }
    }
}
