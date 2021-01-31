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
namespace 健身房winform2._0.Forms
{
    public partial class confirmzhu2 : UserControl
    {
        confirmBLL cbl = new confirmBLL();
        public confirmzhu2()
        {
            InitializeComponent();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            string a = this.textBox1.Text;
            string b = this.dateTimePicker1.Value.ToString();
            bool a1 = cbl.confirm(a,b);
            if (a1)
            {
                MessageBox.Show("发送成功");
                this.textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("发送失败");
            }
        }
    }
}
