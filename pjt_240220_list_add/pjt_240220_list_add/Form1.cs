using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjt_240220_list_add
{

    public partial class Form1 : Form
    {

        string OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtList.Text != "")
            {
                this.lblView.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
            }

            else
            {
                MessageBox.Show("아이템을 입력하세요", "알림", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtList.Focus();
            }
        }

        private void lblView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = OrgStr + this.lblView.SelectedItem.ToString();
        }
    }
}
