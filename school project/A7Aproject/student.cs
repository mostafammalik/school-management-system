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
    public partial class student : Form
    {
        database d = new database();
        main_code cmd = new main_code();
       
        public student()
        {
            InitializeComponent();
        }

        private void pic_small_Click(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {
            panelADD.Visible = false;
            panelDel.Visible = false;
            panelShow.Visible = false;
          //panelUpdate.Visible = false;
            d.fill_combobox_class(cbx_class);
            d.fill_combobox_class(cbx_select_class );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txt_address.Text = "";
            txt_name.Text = "";
            f_address.Text = "";
            f_name.Text = "";
            f_id.Text = "";
            f_job.Text = "";
   

            txt_std_id.BackColor = Color.White;
            panelADD.Visible = true;
            panelDel.Visible = false;
            panelShow.Visible = false;
            txt_std_id.Visible = false;
            label5.Visible = false;
            //panelUpdate.Visible = false;
            cmd.animate_hight(panelADD, 0, 414);
        }

        private void cbx_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.animate_width(panelADD, 305, 568);
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            try
            {
                d.insert_father_data(f_name.Text, f_address.Text, f_job.Text, Convert.ToInt32(f_id.Text));
                d.insert_student_data(txt_name.Text, txt_address.Text, Convert.ToInt32(cbx_class.SelectedValue.ToString()), Convert.ToInt32(f_id.Text));
            
            }
            catch
            {

            }
           
           
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelADD.Visible = false;
            panelDel.Visible = true;
            panelShow.Visible = false;
            //panelUpdate.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_std_id.BackColor = Color.Tomato;
            panelADD.Visible = true;
            panelDel.Visible = false;
            panelShow.Visible = false;
            btn_add2.Visible = false;
            btn_get_std.Visible = true;
            btn_update_std.Visible = false;
            btn_update_std.Enabled = false;
            txt_std_id.Visible = true;
            label5.Visible = true;
            cmd.animate_hight(panelADD, 0, 414);
            
            //panelUpdate.Visible = true; 
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelADD.Visible = false;
            panelDel.Visible = false;
            panelShow.Visible = true;
            //panelUpdate.Visible = false;
            d.select_all_student_in_the_same_class(dgv_student, Convert.ToInt32(cbx_select_class.SelectedValue.ToString())); ////////////////////////////////////////// ;
        }

        private void try1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            d.delete_student(Convert.ToInt32(txt_del_id.Text));
        }

        private void txt_del_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_del_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmd.methodSetInteger(e);
        }

        private void f_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmd.methodSetInteger(e);
        }

        private void cbx_select_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            //d.select_all_student_in_the_same_class(dgv_student,Convert.ToInt32(cbx_select_class.SelectedValue));
            //d.select_all_student_in_the_same_class(dgv_student, Convert.ToInt32(cbx_select_class.SelectedValue.ToString()));
        }

        private void cbx_select_class_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_get_std_Click(object sender, EventArgs e)
        {
            
            d.get_values_of_student_in_text_boxes(Convert.ToInt32(txt_std_id.Text), txt_name, txt_address);
            btn_update_std.Enabled = true;
            btn_update_std.Visible = true;
        }

        private void btn_update_std_Click(object sender, EventArgs e)
        {
            if (txt_std_id.Text != "")
            {
                d.update_student(Convert.ToInt32(txt_std_id.Text), txt_name.Text, txt_address.Text, Convert.ToInt32(cbx_class.SelectedValue.ToString()));
            }
            else
            {
                MessageBox.Show("Enter Valid ID ,Please");
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            panelShow.Visible = true;
            panelDel.Visible = false;
            panelADD.Visible = false;
            cmd.animate_hight(panelShow, 0, 414);
        }

        private void pic_big_MouseLeave(object sender, EventArgs e)
        {
            pic_big.Visible = false;
            pic_small.Visible = true;
        }

        private void pic_small_MouseHover(object sender, EventArgs e)
        {
            pic_big.Visible = true;
            pic_small.Visible = false;
        }

        private void pic_big_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();

        }
    }
}
