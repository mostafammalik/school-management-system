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
    public partial class payment : Form
    {
        main_code cmd = new main_code();
        database d = new database();
        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            cmd.animate_hight(panel_pay, 0, 192);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.animate_hight(panel_show, 0, 192);
            d.select_all_paid_student(dgv_paid_std);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.animate_hight(panel_show, 0, 192);
            d.select_all_Not_paid_student(dgv_paid_std);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                d.pay_fees(txt_std_name.Text, Convert.ToInt32(txt_money.Text));
            }
            catch
            {
                MessageBox.Show("enter Valid name ");
            }
        }

        private void pic_small_MouseHover(object sender, EventArgs e)
        {
            pic_big.Visible = true;
            pic_small.Visible = false;
        }

        private void pic_big_MouseLeave(object sender, EventArgs e)
        {
            pic_big.Visible = false ;
            pic_small.Visible = true;
        }

        private void pic_big_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }
    }
}
