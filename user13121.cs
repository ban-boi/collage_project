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
    public partial class user13121 : Form
    {
        public user13121()
        {
            InitializeComponent();
        }
        string TEAMID = "";
        string TEAMNAME = "";
        public user13121(string teamid, string teamname)
        {
            InitializeComponent();
            TEAMID = teamid;
            TEAMNAME = teamname;
        }

        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select id,[name],borrowmoney,lendmoney,finalmoney from t_jointeam where teamid='{ TEAMID}'";

            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void user13121_Load(object sender, EventArgs e)
        {
            Table();
        }
    }

}
