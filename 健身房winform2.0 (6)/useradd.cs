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
    public partial class useradd : UserControl
    {
        MemberBLL MBL = new MemberBLL();
         public useradd()
        {
            InitializeComponent();
        }

        private void useradd_Load(object sender, EventArgs e)
        {
            userCcom();
        }
        public void userCcom()//用户课程管理下拉框
        {
            DataTable dt = MBL.xianscomuser();
            this.comboBox1.DisplayMember = "curriculumTypeName";
            this.comboBox1.ValueMember = "curriculumTypeId";
            this.comboBox1.DataSource = dt;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            //收入=数量乘以价格
            int income = int.Parse(this.textBox5.Text) * 300;
            bool b1 = MBL.useradd(this.textBox1.Text,this.textBox2.Text,this.textBox3.Text,int.Parse(this.comboBox1.SelectedValue.ToString()),int.Parse(this.textBox4.Text.ToString()),int.Parse(this.textBox5.Text.ToString()),income);
            if (b1)
            {
                MessageBox.Show("新增数据成功");
                               
            }
            else
            {
                MessageBox.Show("新增数据失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
        }
    }
}
