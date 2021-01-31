using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 健身房winform2._0.Forms;

namespace 健身房winform2._0
{
    public partial class From_zhu : Form
    {
        int panelWidth;   //定义一个变量存储数据值
        bool isCollapsed;//定义一个bool类型 一开始是默认false
        public string a = "";
        public From_zhu()
        {
            InitializeComponent();
            timerTime.Start();
            panelWidth = panelLeft.Width;   //左界面的宽给他
            isCollapsed = false;
            showdata data = new showdata();
            AddControlsToPanel(data);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //主界面的关闭
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //定时器
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10 ;
                if (panelLeft.Width>= panelWidth)
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
                if (panelLeft.Width<=51) //一直减 直到指定边框距离
                {    
                    timer1.Stop(); //停止
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void From_zhu_Load(object sender, EventArgs e)
        {
            this.label5.Text = a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
              timer1.Start(); 
        }
        private void movesidePane1(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btncard_Click(object sender, EventArgs e)
        {
            useradd add = new useradd();
            AddControlsToPanel(add);
            movesidePane1(btncard);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
             showdata data = new showdata();   //将要打开的窗口
            AddControlsToPanel(data);
            movesidePane1(btnSale);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();    //显示在要打开的窗口名
            panelControls.Controls.Add(c);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            confirmzhu2 confirm = new confirmzhu2();
            AddControlsToPanel(confirm);
            movesidePane1(btndata);        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usermanager usem = new usermanager();
            AddControlsToPanel(usem);
            movesidePane1(btnusemanger);
        }

    }
}
