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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")//判断文本框内输入是否为空
            {
                Login();
            }
            else
            {
                MessageBox.Show("输入不得为空！");
            }
        }
        public void Login()
        {
            //用户
            if (radioButtonUser.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from t_user where id='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    Data.UID = dc["id"].ToString();
                    Data.UName = dc["name"].ToString();

                    MessageBox.Show("登录成功！");

                    user1 user = new user1();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
                dao.DaoClose();
            }
            //管理员
            if (radioButtonAdmin.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from t_admin where id='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("登录成功！");

                    admin1 admin = new admin1();
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
                dao.DaoClose();
            }
        }
    }
}
