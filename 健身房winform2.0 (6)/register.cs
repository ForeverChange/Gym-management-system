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
  
    public partial class register : Form
    {
        AccountPasswordBLL APBL = new AccountPasswordBLL();
        public register()
        {
            InitializeComponent();
            timeTime.Start();
        }
        usezhu uz = new usezhu();
        private void register_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DataTable regname = APBL.cxname(this.textBox1.Text);
            if (regname.Rows.Count>0)
            {
                MessageBox.Show("此账号已有人注册");
            }
            else
            {
                int isr = 0;
                string usename = this.textBox1.Text;
                string usepwd = this.textBox2.Text;
                if (this.radioButton1.Checked)
                {
                    if (this.checkBox1.Checked)
                    {
                        //管理员
                        isr = 1;
                        bool b1 = APBL.zc1(usename, usepwd, isr);
                        if (b1)
                        {
                            MessageBox.Show("注册成功");
                        }
                        else
                        {
                            MessageBox.Show("注册失败");
                        }
                    }
                    else
                    {
                        isr = 0;
                        bool b1 = APBL.zc1(usename, usepwd, isr);
                        if (b1)
                        {
                            MessageBox.Show("注册成功");
                        }
                        else
                        {
                            MessageBox.Show("注册失败");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("你必须同意此条款才可以使用");
                }
            }
           
           
           
        }
    }
}
