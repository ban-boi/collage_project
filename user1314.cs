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
    public partial class user1314 : Form
    {
        public user1314()
        {
            InitializeComponent();
        }
        string TEAMID = "";
        string TEAMNAME = "";

        public user1314(string teamid,string teamname)
        {
            InitializeComponent();
            TEAMID = teamid;
            TEAMNAME = teamname;
        }

        private void user1314_Load(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        //从数据库读取数据显示在表格控件中(刷新的时候可以用)
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_user";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        public void idQuery()//用学号查询
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select * from t_user where id='{textBox1.Text}'";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        public void roomQuery()//用寝室号查询
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select * from t_user where room like '%{textBox2.Text}%'";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            roomQuery();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取队伍号
            string NAME = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//获取队伍号
            Dao dao = new Dao();
            string sql = $"select id from t_jointeam where teamname='{TEAMNAME} and id={ID}'";
            IDataReader dc1 = dao.read(sql);
            //dc1.Read();//！！读取了一行数据
            if (dc1.Read())
            {
                MessageBox.Show("该同学已在队伍中！");
            }
            else
            {
                string sql5 = $"insert into t_jointeam (id,[name],teamid,teamname,[time],borrowmoney,lendmoney,finalmoney)values('{ID}','{NAME}','{TEAMID}','{TEAMNAME}',getdate(),0,0,0);";
                int n = dao.Execute(sql5);
                if (n > 0)
                {
                    MessageBox.Show("已将同学拉进队伍中!");
                }
                else
                {
                    MessageBox.Show("加入失败！");
                }
            }
        }
    }
}
