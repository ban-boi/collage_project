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
    public partial class user13 : Form
    {
        public user13()
        {
            InitializeComponent();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select teamid,teamname from t_jointeam where id='{Data.UID}';";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void user13_Load(object sender, EventArgs e)
        {
            Table();
            //label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//用来在开始未点击列表行的时候就选中一行
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string teamid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string teamname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                user131 user = new user131(teamid,teamname);
                user.ShowDialog();

                Table();//刷新数据
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
