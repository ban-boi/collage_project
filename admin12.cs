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
    public partial class admin12 : Form
    {
        public admin12()
        {
            InitializeComponent();
        }
        private void admin12_Load_1(object sender, EventArgs e)
        {
            Table();
            if(dataGridView1.Rows.Count != 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//用来在开始未点击列表行的时候就选中一行
            }
            
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

        private void button6_Click(object sender, EventArgs e)
        {
            admin121 admin = new admin121();
            admin.ShowDialog();
            Table();
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

        


        private void button4_Click(object sender, EventArgs e)
        {
            try//若是一行都没有选中，就会出现异常，还有索引超出范围这种也是
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取队伍号
                label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from t_team where id='{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("已删除该队伍！");
                    }
                    else
                    {
                        MessageBox.Show("删除队伍失败" + sql);
                    }

                    sql = $"delete from t_jointeam where teamid='{id}'";
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("已删除该队伍成员的加入信息！");
                    }
                    else if(dao.Execute(sql) == 0)
                    {
                        MessageBox.Show("该组内没有可删除的成员信息！");
                    }
                    else
                    {
                        MessageBox.Show("删除队伍成员的加入信息失败" + sql);
                    }

                    sql = $"delete from t_accounts where teamid='{id}'";
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("已删除队伍成员在该队伍内的记账信息！");
                    }
                    else if (dao.Execute(sql) == 0)
                    {
                        MessageBox.Show("该组内没有可删除的记账信息！");
                    }
                    else
                    {
                        MessageBox.Show("删除队伍成员在该队伍内的记账信息失败" + sql);
                    }

                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先在表格选中要删除的学生信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Table();
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                admin122 admin = new admin122(id);
                admin.ShowDialog();

                Table();//刷新数据
            }
            catch
            {
                MessageBox.Show("error");
            }
        
        }
    }
}
