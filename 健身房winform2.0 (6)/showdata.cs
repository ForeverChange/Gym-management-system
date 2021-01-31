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
namespace 健身房winform2._0.Forms
{
    public partial class showdata : UserControl
    {
        incomeBLL ibl = new incomeBLL();
        public showdata()
        {
            InitializeComponent();
        }

        private void 显示数据_Load(object sender, EventArgs e)
        {
            xiansyh();
            xiansyhcard();
            xiansyhincome();
        }
        public void xiansyh()
        {
            DataTable dt = ibl.xianshy();
            this.label7.Text = dt.Rows.Count.ToString();
        }
        public void xiansyhcard()
        {
            DataTable dt = ibl.xianshycard();
            this.label4.Text = dt.Rows[0]["xx"].ToString();
            
        }
        public void xiansyhincome()
        {
            DataTable dt = ibl.xiansincome();
            this.label5.Text = dt.Rows[0]["xx"].ToString();

        }

    }
}
