using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using A7Aproject;
using projectSE;

namespace A7Aproject
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        database d = new database();

        private void home_Load(object sender, EventArgs e)
        {
            lbl_std.Text = d.count_students().ToString();
            lbl_teacher.Text = d.count_teachers().ToString();
            lbl_class.Text = d.count_class().ToString();
        }

        private void pic_small_MouseHover(object sender, EventArgs e)
        {
            pic_small.Visible = false;
            pic_big.Visible = true;
        }

        private void pic_big_MouseLeave(object sender, EventArgs e)
        {
            pic_big.Visible = false;
            pic_small.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pic_home_s_MouseHover(object sender, EventArgs e)
        {
            pic_home_s.Visible = false;
            pic_home_c.Visible = true;
        }

        private void pic_home_c_MouseLeave(object sender, EventArgs e)
        {

            pic_home_s.Visible = true;
            pic_home_c.Visible = false;
        }

        private void pic_teacher_s_MouseHover(object sender, EventArgs e)
        {
            pic_teacher_s.Visible = false;
            pic_teacher_c.Visible = true;
        }

        private void pic_teacher_c_MouseLeave(object sender, EventArgs e)
        {
            pic_teacher_s.Visible = true;
            pic_teacher_c.Visible = false;
        }

        private void pic_class_s_MouseHover(object sender, EventArgs e)
        {
            pic_class_s.Visible = false;
            pic_class_c.Visible = true;
        }

        private void pic_class_c_MouseLeave(object sender, EventArgs e)
        {
            pic_class_s.Visible = true;
            pic_class_c.Visible = false;
        }

        private void pic_mat_s_MouseHover(object sender, EventArgs e)
        {
            pic_mat_c.Visible = true;
            pic_mat_s.Visible = false;
        }

        private void pic_pay_s_MouseHover(object sender, EventArgs e)
        {
            pic_pay_c.Visible = true;
            pic_pay_s.Visible = false;
        }

        private void pic_pay_c_MouseLeave(object sender, EventArgs e)
        {

            pic_pay_c.Visible = false;
            pic_pay_s.Visible = true;
        }

        private void pic_grade_s_MouseHover(object sender, EventArgs e)
        {
            pic_grade_c.Visible = true;
            pic_grade_s.Visible = false;
        }

        private void pic_grade_c_MouseLeave(object sender, EventArgs e)
        {
            pic_grade_c.Visible = false;
            pic_grade_s.Visible = true;
        }

        private void pic_cont_s_MouseHover(object sender, EventArgs e)
        {
            pic_cont_c.Visible = true;
            pic_cont_s.Visible = false;
        }

        private void pic_cont_c_MouseLeave(object sender, EventArgs e)
        {
            pic_cont_c.Visible = false;
            pic_cont_s.Visible = true;
        }

        private void pic_mat_c_MouseLeave(object sender, EventArgs e)
        {
            pic_mat_c.Visible = false;
            pic_mat_s.Visible = true;
        }

        private void pic_home_c_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.Show();
            this.Hide();
         
        }

        private void pic_class_c_Click(object sender, EventArgs e)
        {
            classes c = new classes();
            c.Show();
            this.Hide();
        }

        private void pic_mat_c_Click(object sender, EventArgs e)
        {
            material m = new material();
            m.Show();
            this.Hide();
        }

        private void pic_pay_c_Click(object sender, EventArgs e)
        {
            payment p = new payment();
            p.Show();
            this.Hide();
        }

        private void pic_grade_c_Click(object sender, EventArgs e)
        {
            grade g = new grade();
            g.Show();
            this.Hide();
        }

        private void pic_teacher_c_Click(object sender, EventArgs e)
        {
            teacher t = new teacher();
            t.Show();
            this.Hide();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
