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
    public partial class admin112 : Form
    {
        string ID = "";
        public admin112()
        {
            InitializeComponent();
        }
        public admin112(string id, string name, string password, string room)
        {
            InitializeComponent();
            ID = textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = password;
            textBox4.Text = room;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update t_user set id='{textBox1.Text}',[name]='{textBox2.Text}',password='{textBox3.Text}',room='{textBox4.Text}' where id={ID}";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
        }
    }
}
