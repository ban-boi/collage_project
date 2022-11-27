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
    public partial class user1313 : Form
    {
        public user1313()
        {
            InitializeComponent();
        }
        string BORROWERID = "";
        string BORROWERNAME = "";
        string LENDERID = "";
        string LENDERNAME = "";
        string TEAMID = "";
        string TEAMNAME = "";

        public user1313(string borrowerid,string borrowname,string lenderid,string lendername,string teamid,string teamname)
        {
            InitializeComponent();
            BORROWERID = borrowerid;
            BORROWERNAME = borrowname;
            LENDERID = lenderid;
            LENDERNAME = lendername;
            TEAMID = teamid;
            TEAMNAME = teamname;
        }

        private void user1313_Load(object sender, EventArgs e)
        {
            label1.Text = BORROWERID + BORROWERNAME;
            label2.Text = LENDERID + LENDERNAME;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                Dao dao = new Dao();
                string sql = $"insert into t_accounts (teamid,teamname,borrowerid,borrowername,lenderid,lendername,[money],[time],remarks)values('{TEAMID}','{TEAMNAME}','{BORROWERID}','{BORROWERNAME}','{LENDERID}','{LENDERNAME}','{textBox1.Text}',getdate(),'{textBox2.Text}');update t_jointeam set borrowmoney = borrowmoney +'{textBox1.Text}' where id='{BORROWERID}' and teamid='{TEAMID}';update t_jointeam set finalmoney = finalmoney -'{textBox1.Text}' where id='{BORROWERID}' and teamid='{TEAMID}';update t_jointeam set lendmoney = lendmoney +'{textBox1.Text}' where id='{LENDERID}' and teamid='{TEAMID}';update t_jointeam set finalmoney = finalmoney +'{textBox1.Text}' where id='{LENDERID}' and teamid='{TEAMID}';";
                int n = dao.Execute(sql);
                if (n > 4)
                {
                    MessageBox.Show("记账成功!");
                }
                else
                {
                    MessageBox.Show("记账失败!");
                }

                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("请至少输入金额！");
            }
        }
    }
}
