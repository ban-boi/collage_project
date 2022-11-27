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
    public partial class user12 : Form
    {
        string TEAMID = "";
        string TEAMNAME = "";
        public user12()
        {
            InitializeComponent();
        }

        private void user12_Load(object sender, EventArgs e)
        {
            Table();
            //label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//用来在开始未点击列表行的时候就选中一行
        }
        //从数据库读取数据显示在表格控件中(刷新的时候可以用)
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_team";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        public void TeamIdQuery()//用队号查询方法
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select * from t_team where id='{textBox1.Text}'";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        public void TeamNameQuery()//用队名查询方法
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select * from t_team where name like'%{textBox2.Text}%'";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeamIdQuery();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeamNameQuery();
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TEAMID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取队伍号
            TEAMNAME= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//获取队伍号
            Dao dao = new Dao();
            string sql = $"select id from t_jointeam where teamname='{TEAMNAME} and id={Data.UID}'";
            IDataReader dc1 = dao.read(sql);
            //dc1.Read();//！！读取了一行数据

            if (dc1.Read())
            {
                MessageBox.Show("已在队伍中！");
            }
            else
            {
                string sql5 = $"insert into t_jointeam (id,[name],teamid,teamname,[time],borrowmoney,lendmoney,finalmoney)values('{Data.UID}','{Data.UName}','{TEAMID}','{TEAMNAME}',getdate(),0,0,0);";
                int n = dao.Execute(sql5);
                if (n > 0)
                {
                    MessageBox.Show("已将自己加入队伍中!");
                }
                else
                {
                    MessageBox.Show("加入失败！");
                }
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

                user121 user = new user121(id);
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
