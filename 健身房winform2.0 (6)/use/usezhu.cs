using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BLL;
namespace 健身房winform2._0.Forms.use
{
    public partial class usezhu : Form
    {
       // Thread th;
        public   string account = "" ;
        public string a = "";
        incomeBLL ibl = new incomeBLL();
        confirmBLL conf = new confirmBLL();
        public usezhu()
        {
            InitializeComponent();
            timerTime.Start();
        }

        //private void ChangeImage(Image img, int millisecondsTimeOut)
        //{
        //    this.Invoke(new Action(() =>
        //    {
        //        pictureBox1.Image = img;
        //    })
        //        );
        //    Thread.Sleep(millisecondsTimeOut);
        //}

        //private void usezhu_Load(object sender, EventArgs e)
        //{
        //    //timer1.Enabled = true;
        //    th = new Thread
        //        (
        //            delegate ()
        //            {
        //                // 3就是要循环轮数了
        //                for (int i = 0; i < 99; i++)
        //                {
        //                    //调用方法

        //                    ChangeImage(Image.FromFile(@"C:\Users\linyixin\Desktop\健身房轮播图片\1.jpg"), 2000);
        //                    ChangeImage(Image.FromFile(@"C:\Users\linyixin\Desktop\健身房轮播图片\2.jpg"), 2000);
        //                }
        //            }
        //        );
        //    th.IsBackground = true;
        //    th.Start();
        //}

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString();
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
        private void usezhu_Load(object sender, EventArgs e)
        {
            this.label5.Text = a;
            xiansday();
            xiansincome();
            xianscardnum();
            DataTable dt= conf.cxconfirm();
            this.textBox1.Text = dt.Rows[0]["confirm"].ToString();
        }

        //private void btnSale_Click(object sender, EventArgs e)
        //{
        //    userincome uzincome = new userincome();           
        //    AddControlsToPanel(uzincome);
        //}
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();    //显示在要打开的窗口名
            panelControls.Controls.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btncard_Click(object sender, EventArgs e)
        //{
        //    confirmuse confirm = new confirmuse();
        //    confirm.TopLevel = false;
        //    AddControlsToPanel(confirm);
        //}
    }
}
