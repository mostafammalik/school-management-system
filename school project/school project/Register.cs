using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;
namespace A7Aproject
{
    public partial class Register : Form
    {
        database d = new database();
        main_code cmd = new main_code();
        public Register() 
        {
            InitializeComponent();
        }

        private void pic_small_MouseHover(object sender, EventArgs e)
        {
            pic_small.Visible = false;
            pic_big.Visible = true;
        }

       

        private void Register_Load(object sender, EventArgs e)
        {
            d.fill_combobox_DEPARTMENT(cbx_dept);
        }

        private void pic_big_MouseLeave(object sender, EventArgs e)
        {
            pic_small.Visible = true;
            pic_big.Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            d.insert_login_data_into_manage_table(Convert.ToInt32(txt_id.Text),txt_fname.Text ,txt_lname.Text,Convert.ToInt32(cbx_dept.SelectedValue.ToString()),txt_user.Text ,txt_password.Text ,txt_re_pass.Text ,txt_phone.Text) ;
            d.insert_login_data_into_login_table(Convert.ToInt32(txt_id.Text), txt_user.Text, txt_password.Text);
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmd.methodSetInteger(e);
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_big_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }
    }
}
