using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using WindowsFormsApp1;
using System.Windows.Forms;
using A7Aproject;

namespace projectSE
{
    public partial class grade : Form
    {
        main_code cmd = new main_code();
        database d = new database();

        public grade()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grade_Load(object sender, EventArgs e)
        {
            d.fill_combobox_class(cbx_class);
         
        }

        private void cbx_class_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            d.all_grades_of_one_student(dgv_grade, txt_name.Text);
        }

        private void pic_small_MouseHover(object sender, EventArgs e)
        {
            pic_big.Visible = true;
            pic_small.Visible = false;
        }

        private void pic_big_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pic_big_MouseLeave(object sender, EventArgs e)
        {
            pic_big.Visible = false;
            pic_small.Visible = true ;
        }

        private void pic_big_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }

    }
}
