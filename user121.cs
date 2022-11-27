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
    public partial class user121 : Form
    {
        public user121()
        {
            InitializeComponent();
        }
        string TEAMID = "";
        public user121(string id)
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
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        

        private void user121_Load(object sender, EventArgs e)
        {
            Table();
        }
    }
}
