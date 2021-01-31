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
namespace 健身房winform2._0.Forms.use
{
    public partial class useincome : Form
    {
        public string account = "";
        incomeBLL ibl = new incomeBLL();
        public useincome()
        {
            InitializeComponent();
        }

        private void useincome_Load(object sender, EventArgs e)
        {
            xiansday();
            xiansincome();
            xianscardnum();
        }
        public void xiansday()// 显示会员天数
        {
            DataTable dt = ibl.xiansday(account);
            if (dt.Rows.Count > 0)
            {
                this.label12.Text = dt.Rows[0]["DaysRemaining"].ToString();
            }
            else
            {
                MessageBox.Show("显示失败");
            }
        }
        public void xiansincome()// 显示消费
        {
            DataTable dt = ibl.xiansincome(account);
            if (dt.Rows.Count > 0)
            {
                this.label10.Text = dt.Rows[0]["income"].ToString();
            }
            else
            {
                MessageBox.Show("显示失败");
            }
        }
        public void xianscardnum()// 显示会员购卡数量
        {
            DataTable dt = ibl.xianscardnum(account);
            if (dt.Rows.Count > 0)
            {
                this.label8.Text = dt.Rows[0]["cardnumber"].ToString();
            }
            else
            {
                MessageBox.Show("显示失败");
            }
        }
    }
}
