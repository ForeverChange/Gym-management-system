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
    public partial class floatxg : Form
    {
        MemberBLL mbl = new MemberBLL();
        public int id = 0;
        public floatxg()
        {
            InitializeComponent();
        }

        private void floatxg_Load(object sender, EventArgs e)
        {
            xians();
            userCcom();
        }
        public void xians()  //修改赋值
        {
            DataTable dt = mbl.xg(id);          
            if (dt.Rows.Count > 0)
            {
                this.textBox1.Text = dt.Rows[0]["Membername"].ToString();
                this.textBox2.Text = dt.Rows[0]["MemberGender"].ToString();
                this.textBox3.Text = dt.Rows[0]["MemberAddress"].ToString();
                this.comboBox1.Text = dt.Rows[0]["curriculumTypeName"].ToString();
                this.textBox4.Text = dt.Rows[0]["DaysRemaining"].ToString();
                this.textBox5.Text = dt.Rows[0]["cardnumber"].ToString();
            }
            else
            {

            }

        }
        public void userCcom()//用户课程管理下拉框
        {
            DataTable dt = mbl.xianscomuser();
            this.comboBox1.DisplayMember = "curriculumTypeName";
            this.comboBox1.ValueMember = "curriculumTypeId";
            this.comboBox1.DataSource = dt;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            //收入=数量乘以价格
            int income = int.Parse(this.textBox5.Text) * 300;
            bool b1 = mbl.update(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, int.Parse(this.comboBox1.SelectedValue.ToString()), int.Parse(this.textBox4.Text.ToString()), int.Parse(this.textBox5.Text.ToString()),income,id);
            if (b1)
            {
                MessageBox.Show("修改数据成功");

            }
            else
            {
                MessageBox.Show("修改数据失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
        }

        
    }
    
}
