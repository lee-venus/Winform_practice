using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjt_240225_input_list
{
    public partial class Form1 : Form
    {

        string strName, strAge, strWork;

        bool TextCheck()
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요 ! ", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtAge.Text == "")
            {
                MessageBox.Show("나이를 압력하세요 ! ", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtWork.Text == "")
            {
                MessageBox.Show("직업을 입력하세요 ! ", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck() == true)
            {
                strName = this.txtName.Text;
                strAge = this.txtAge.Text;
                strWork = this.txtWork.Text;

                this.txtName.Text = "";
                this.txtAge.Text = "";
                this.txtWork.Text = "";
            }
            else return;
            ListViewItem lvi = new ListViewItem(new string[] { strName, strAge, strWork });
            this.lvView.Items.Add(lvi);
        }

        private void lvView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvView_Click(object sender, EventArgs e)
        {
            if (this.lvView.SelectedItems.Count == 0)
                MessageBox.Show("아이템을 선택하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("이름 : " + this.lvView.SelectedItems[0].SubItems[0].Text + "\n나이 : " + this.lvView.SelectedItems[0].SubItems[1].Text + "\n직업 : " + this.lvView.SelectedItems[0].SubItems[2].Text, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
