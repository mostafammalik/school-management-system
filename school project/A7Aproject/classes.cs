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
    public partial class classes : Form
    {
        main_code cmd = new main_code();
        database d = new database();
        public classes()
        {
            InitializeComponent();
        }

        private void @class_Load(object sender, EventArgs e)
        {
            d.fill_combobox_teacher(cbx_teacher);
        }

        private void btn_addclass_Click(object sender, EventArgs e)
        {
            cbx_teacher.Visible = true;
            
            d.select_all_classes(dgv_class);
            d.insert_class_data(Convert.ToInt32(txt_cls_id.Text), txt_cls_name.Text, Convert.ToInt32(cbx_teacher.SelectedValue.ToString()));
        }

        private void btn_del_class_Click(object sender, EventArgs e)
        {
            cmd.animate_width(panel3, 0, 289);
            cbx_teacher.Visible = false;
            btn_del.Visible = true;
            btn_addclass.Visible = false;
            //d.fill_combobox_class(cbx_teacher);
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.delete_classes(txt_cls_name.Text);
            //d.fill_combobox_class(cbx_teacher); 
            d.select_all_classes(dgv_class);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cbx_teacher.Visible = true;
            btn_del.Visible = false;
            btn_addclass.Visible = true;
            cmd.animate_width(panel3,0, 289 );
            
        }

        private void btn_showclass_Click(object sender, EventArgs e)
        {
            panel_show_class.Visible = true;
            cmd.animate_hight(panel_show_class, 0, 359);
            d.select_all_classes(dgv_class);
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

        private void pic_big_MouseLeave(object sender, EventArgs e)
        {
            pic_small.Visible = true;
            pic_big.Visible = false;
        }
    }
}
