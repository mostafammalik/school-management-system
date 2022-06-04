using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace A7Aproject
{
    public partial class forget_password : Form
    {
        database d = new database();
        public forget_password()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            //d.select_manage_password(txt_email.Text, txt_show_pass);
            //pictureBox1.Visible = true;
            //pic1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.select_manage_password(txt_email.Text, txt_show);
        }
    }
}
