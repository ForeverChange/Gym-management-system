using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BLL;
namespace 健身房winform2._0.Forms.use
{
    public partial class xguse : Form
    {
        MemberBLL mbl = new MemberBLL(); 
        public xguse()
        {
            InitializeComponent();
        }

        private void xguse_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = mbl.yzyh(this.textBox1.Text);
            if (dt.Rows.Count>0)
            {
                usezhu uz = new usezhu();
                uz.account = this.textBox1.Text;
                uz.a = this.textBox1.Text;
                uz.Show();

            }
            else
            {
                MessageBox.Show("没有该会员信息");
            }
             
        }
    }
}
