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
    public partial class teacher : Form
    {
        main_code cmd = new main_code();
        database d = new database();
        public teacher()
        {
            InitializeComponent();
        }

        private void teacher_Load(object sender, EventArgs e)
        {
            
        }
        bool p = false;
        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_salary.Text = "";
            txt_spec.Text = "";
            txt_t_id.Text = "";
            txt_t_id.BackColor = Color.White;
            btn_add2.Visible = true;
            panelDel.Visible = false;
            panelShow.Visible = false;
            if (p == false)
            {
                panelADD.Visible = true;
                p = true;
            }
            else
            {
                cmd.animate_hight(panelADD, 0, 414);
                p = false;
            }
        }

        private void btn_del_teacher_Click(object sender, EventArgs e)
        {
            panelADD.Visible = false;
            panelShow.Visible = false;
            panelDel.Visible = true;
            panelDel.Visible = false;
            panelShow.Visible = false;
            if (p == false)
            {
                panelDel.Visible = true;
                p = true;
            }
            else
            {
                cmd.animate_hight(panelDel, 0, 414);
                p = false;
            }
        }

        private void btn_update_teacher_Click(object sender, EventArgs e)
        {
            btn_add2.Visible = false;
            txt_t_id.BackColor = Color.Green;
            panelDel.Visible = false;
            panelShow.Visible = false;
            if (p == false)
            {
                panelADD.Visible = true;
                p = true;
            }
            else
            {
                cmd.animate_hight(panelADD, 0, 414);
                p = false;
            }
           
        }

        private void btn_show_teacher_Click(object sender, EventArgs e)
        {
            panelADD.Visible = false;
            panelDel.Visible = false;
            panelShow.Visible = true;
           
            if (p == false)
            {
                panelShow.Visible = true;
                p = true;
            }
            else
            {
                cmd.animate_hight(panelShow, 0, 414);
                p = false;
            }
            d.select_all_teachers(dgv_teachers);
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            d.insert_teacher_data(txt_name.Text, Convert.ToInt32(txt_t_id.Text), txt_address.Text, Convert.ToInt32(txt_salary.Text), txt_spec.Text);
            txt_name.Text = "";
            txt_address.Text = "";
            txt_salary.Text = "";
            txt_spec.Text = "";
            txt_t_id.Text = "";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            d.delete_teacher(Convert.ToInt32(txt_t__del_id.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d.select_all_teachers(dgv_teachers);
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            if (txt_t_id.Text != "")
            {
                d.get_values_of_teacher_in_text_boxes(Convert.ToInt32(txt_t_id.Text), txt_name, txt_address, txt_salary, txt_spec);
                btn_update.Enabled = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            d.update_teacher(txt_name.Text, Convert.ToInt32(txt_t_id.Text), txt_address.Text, Convert.ToInt32(txt_salary.Text), txt_spec.Text);
        }

        private void pic_small_MouseHover(object sender, EventArgs e)
        {
            pic_big.Visible = true;
            pic_small.Visible = false;
        }

        private void pic_big_MouseLeave(object sender, EventArgs e)
        {
            pic_big.Visible = false;
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
