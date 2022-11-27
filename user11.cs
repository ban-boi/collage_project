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
    public partial class user11 : Form
    {
        string TEAMID = "";
        public user11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Dao dao = new Dao();
                string sql1 = $"insert into t_team ([name]) values('{textBox1.Text}');select id from t_team where name='{textBox1.Text}'; ";
                //$"insert into t_lend ([uid],ISBN,[datetime]) values('{Data.UID}','{isbn}',getdate())
                int n = dao.Execute(sql1);
                if (n > 0)
                {
                    MessageBox.Show("创建成功!");
                }
                else
                {
                    MessageBox.Show("创建失败!");
                }

                string sql2 = $"select id from t_team where name='{textBox1.Text}'; ";
                IDataReader dc = dao.read(sql2);
                dc.Read();//！！读取了一行数据
                TEAMID = dc[0].ToString();

                //string sql3 = $"create table t_member_{TEAMID}(id varchar(20),[name] varchar(20),teamid varchar(20),jointime datetime,primary key(id));";
                //n = dao.Execute(sql3);
                //MessageBox.Show("队伍成员表生成!");

                string sql5 = $"insert into t_jointeam (id,[name],teamid,teamname,[time],borrowmoney,lendmoney,finalmoney)values('{Data.UID}','{Data.UName}','{TEAMID}','{textBox1.Text}',getdate(),0,0,0);";
                n = dao.Execute(sql5);
                if (n > 0)
                {
                    MessageBox.Show("已将自己加入队伍中!");
                }

                //string sql4 = $"create table t_accounts_{TEAMID}(sequence varchar(20),[time] varchar(20),borrower varchar(20),lender varchar (20) primary key(sequence));";
                //n = dao.Execute(sql4);
                //MessageBox.Show("队伍记账表生成!");

                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("请完整输入各项信息！");
            }
        }
    }
}
