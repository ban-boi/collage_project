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
    public partial class admin121 : Form
    {
        string TEAMID = "";
        public admin121()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                Dao dao = new Dao();
                string sql1 = $"insert into t_team ([name]) values('{textBox1.Text}');select id from t_team where name='{textBox1.Text}'; ";
                int n = dao.Execute(sql1);
                if (n > 0)
                {
                    MessageBox.Show("添加成功!");
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }

                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("请完整输入各项信息！");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
