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
    public partial class usermanager : UserControl
    {
        MemberBLL mbl = new MemberBLL();
        public usermanager()
        {
            InitializeComponent();
        }

        private void usermanager_Load(object sender, EventArgs e)
        {
            yhgl();
            userCcom();
        }
        public void yhgl() //用户管理
        {
            this.skinDataGridView3.AutoGenerateColumns = false;
            DataTable dt = mbl.xians();
            this.skinDataGridView3.DataSource = dt;
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
            int a = int.Parse(this.skinDataGridView3.CurrentRow.Cells["ID"].Value.ToString());
            bool b1 = mbl.del(a);
            if (b1)
            {
                MessageBox.Show("删除成功");
                yhgl();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
        private void AddControlsTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelxg.Controls.Clear();
            panelxg.Controls.Add(c);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.skinDataGridView3.CurrentRow.Cells["ID"].Value.ToString());
            floatxg xg = new floatxg();
            xg.id = a;
            xg.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {
           string kc= this.comboBox1.SelectedValue.ToString();
            string name = this.textBox1.Text;
            DataTable dt = mbl.select(kc,name);
            this.skinDataGridView3.DataSource = dt;
        }
    }
}
