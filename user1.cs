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
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
        }

        private void 创建队伍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user11 user = new user11();
            user.ShowDialog();
        }

        private void 加入已有队伍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user12 user = new user12();
            user.ShowDialog();
        }

        private void 我的队伍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user13 user = new user13();
            user.ShowDialog();
        }

        private void user1_Load(object sender, EventArgs e)
        {
            label3.Text = Data.UName;
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user14 user = new user14();
            user.ShowDialog();
        }
    }
}
