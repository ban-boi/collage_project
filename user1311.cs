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
    public partial class user1311 : Form
    {
        public user1311()
        {
            InitializeComponent();
        }
        string ID = "";
        string TEAMID = "";
        public user1311(string id,string teamid)
        {
            InitializeComponent();
            TEAMID = teamid;
            ID = id;
        }

        public void Table()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select lenderid,lendername,borrowerid,borrowername,money,[time],remarks from t_accounts where lenderid='{ID}' and teamid='{ TEAMID}';";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();

            sql = $"select lenderid,lendername,borrowerid,borrowername,money,[time],remarks from t_accounts where borrowerid='{ID}' and teamid='{ TEAMID}';";
            IDataReader dc1 = dao.read(sql);
            while (dc1.Read())
            {
                dataGridView2.Rows.Add(dc1[0].ToString(), dc1[1].ToString(), dc1[2].ToString(), dc1[3].ToString(), dc1[4].ToString(), dc1[5].ToString(), dc1[6].ToString());
            }

            dc1.Close();
            dao.DaoClose();
        }

        private void user1311_Load(object sender, EventArgs e)
        {
            Table();
            label2.Text = ID;
            label4.Text = TEAMID;
            if (dataGridView1.Rows.Count != 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//用来在开始未点击列表行的时候就选中一行
            }
            Dao dao = new Dao();
            string sql2 = $"select sum(money) from t_accounts where borrowerid='{ID}' and teamid='{ TEAMID}'; ";
            IDataReader dc = dao.read(sql2);
            if (dc.Read())
            {
                label5.Text = dc[0].ToString();
            };//！！读取了一行数据

            string sql3 = $"select sum(money) from t_accounts where lenderid='{ID}' and teamid='{ TEAMID}'; ";
            IDataReader dc1 = dao.read(sql3);
            dc1.Read();//！！读取了一行数据
            label7.Text = dc1[0].ToString();
        }
    }
}
