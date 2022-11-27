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
    public partial class user1312 : Form
    {
        public user1312()
        {
            InitializeComponent();
        }
        string TEAMID = "";
        public user1312(string teamid)
        {
            InitializeComponent();
            TEAMID = teamid;
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select teamid,teamname,lenderid,lendername,borrowerid,borrowername,money,[time],remarks,[sequence] from t_accounts where teamid='{ TEAMID}';";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(), dc[8].ToString(), dc[9].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void user1312_Load(object sender, EventArgs e)
        {
            Table();
            if (dataGridView1.Rows.Count != 0)
            {
                label1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                label2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                label3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                label4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                //用来在开始未点击列表行的时候就选中一行
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try//若是一行都没有选中，就会出现异常，还有索引超出范围这种也是
            {
                string sequence = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();//获取次序号
                //label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from t_accounts where sequence='{sequence}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("已删除该条记录！");
                    }
                    else
                    {
                        MessageBox.Show("删除记录失败" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先在表格选中要删除的记账记录！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        public void MoneyQuery()//用金额查询方法
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select teamid,teamname,lenderid,lendername,borrowerid,borrowername,money,[time],remarks,[sequence] from t_accounts where money='{textBox1.Text}' and teamid='{TEAMID}'";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(), dc[8].ToString(), dc[9].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            MoneyQuery();
            textBox1.Text = "";
        }
        public void RemarksQuery()//用备注查询方法
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select teamid,teamname,lenderid,lendername,borrowerid,borrowername,money,[time],remarks,[sequence] from t_accounts where remarks like '%{textBox2.Text}%'and teamid='{TEAMID}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(), dc[8].ToString(), dc[9].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RemarksQuery();
            textBox2.Text = "";
        }
        public void TimeQuery()//用时间查询方法
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select teamid,teamname,lenderid,lendername,borrowerid,borrowername,money,[time],remarks,[sequence] from t_accounts where [time] like '%{textBox3.Text}%' and teamid='{TEAMID}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(), dc[8].ToString(), dc[9].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            TimeQuery();
            textBox3.Text = "";
        }
        public void SequenceQuery()//用序号查询方法
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select teamid,teamname,lenderid,lendername,borrowerid,borrowername,money,[time],remarks,[sequence] from t_accounts where [sequence]='{textBox4.Text}' and teamid='{TEAMID}'";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(), dc[8].ToString(), dc[9].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SequenceQuery();
            textBox4.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            label2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            label3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            label4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string teamid = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                user13121 user = new user13121(id, teamid);
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
