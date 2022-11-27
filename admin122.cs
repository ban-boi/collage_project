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
    public partial class admin122 : Form
    {
        string TEAMID="";
        public admin122()
        {
            InitializeComponent();
        }
        public admin122(string id)
        {
            InitializeComponent();
            TEAMID = id;
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select id,[name],teamid,teamname,[time] from t_jointeam where teamid='{ TEAMID}'";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(),dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void admin122_Load(object sender, EventArgs e)
        {
            Table();
            //label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//用来在开始未点击列表行的时候就选中一行
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try//若是一行都没有选中，就会出现异常，还有索引超出范围这种也是
            {
                string userid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取学号
                label2.Text = userid + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from t_jointeam where teamid='{ TEAMID}' and id='{userid}';";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功！");

                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先在表格选中要删除的学生信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
