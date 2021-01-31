using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using 健身房winform2._0.Forms.use;
namespace 健身房winform2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AccountPasswordBLL APBL = new AccountPasswordBLL();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usename = this.textBox1.Text;
            string usepwd = this.textBox2.Text;
            DataTable b1 = APBL.Login1(usename, usepwd);
            if (b1.Rows.Count>0)
            {
                string test = b1.Rows[0]["iSRead"].ToString();  
                if (int.Parse(test)>0)
                {
                    From_zhu zhu = new From_zhu();
                    zhu.a = this.textBox1.Text;
                    zhu.Show();
                }
                else
                {
                    xguse yz = new xguse();
                    yz.ShowDialog();
                  
                 }
            }
            else
            {
                MessageBox.Show("密码错误");
            }          
        }
        private void label5_Click(object sender, EventArgs e)
        {
            using (register reg = new register())
            {
                reg.ShowDialog();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (register reg = new register())
            {
                reg.ShowDialog();
            }
        }
    }
}
