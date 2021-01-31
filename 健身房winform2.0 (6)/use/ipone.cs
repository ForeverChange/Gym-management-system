using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 健身房winform2._0.Forms.use
{
    public partial class ipone : Form
    {
        int panelWidth;   //定义一个变量存储数据值
        bool isCollapsed;//定义一个bool类型 一开始是默认false
        public ipone()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");
        }

        private void ipone_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //定时器
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                //关闭的速度
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 10) //一直减 直到指定边框距离
                {
                    timer1.Stop(); //停止
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }
    }
}
