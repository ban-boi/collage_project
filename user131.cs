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
    public partial class user131 : Form
    {
        public user131()
        {
            InitializeComponent();
        }

        string TEAMID = "";
        string TEAMNAME = "";
        public user131(string teamid,string teamname)
        {
            InitializeComponent();
            TEAMID = teamid;
            TEAMNAME = teamname;
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select id,[name],teamid,teamname,[time] from t_jointeam where teamid='{ TEAMID}'";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void user131_Load(object sender, EventArgs e)
        {
            Table();
            if (dataGridView1.Rows.Count != 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //用来在开始未点击列表行的时候就选中一行
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string teamid = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                user1311 user = new user1311(id, teamid);
                user.ShowDialog();

                Table();//刷新数据
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string teamid = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                user1312 user = new user1312(teamid);
                user.ShowDialog();

                Table();//刷新数据
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string borrowerid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string borrowername = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string lenderid = Data.UID;
                string lendername = Data.UName;
                string teamid = TEAMID;
                string teamname = TEAMNAME;

                user1313 user = new user1313(borrowerid,borrowername,lenderid,lendername,teamid,teamname);
                user.ShowDialog();

                Table();//刷新数据
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string teamid = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string teamname = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                user1314 user = new user1314(teamid,teamname);
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
