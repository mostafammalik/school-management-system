using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace A7Aproject
{
    public partial class login : Form
    {
        database d = new database();
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            database dt = new database();
            //dt.authentication(txtuser.Text ,txtpass.Text);
     
        }

        private void pic_unshow_Click(object sender, EventArgs e)
        {
            pic_show.Visible = true;
            pic_unshow.Visible = false;
            txt_password.UseSystemPasswordChar = true;
            
        }

        private void pic_show_Click(object sender, EventArgs e)
        {
            pic_show.Visible = false;
            pic_unshow.Visible = true;
            txt_password.UseSystemPasswordChar = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            d.authentication(txt_username.Text, txt_password.Text);
            
        }
    }
}
