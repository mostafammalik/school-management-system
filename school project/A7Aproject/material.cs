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
    public partial class material : Form
    {
        main_code cmd = new main_code();
        database d = new database();
        public material()
        {
            InitializeComponent();
        }

        private void btn_mat_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            btn_del_mat.Visible = false;
            btn_add_mat.Visible = true;
            cbx_class.Visible = true;
            cmd.animate_width(panel3, 0, 289);
        }

        private void material_Load(object sender, EventArgs e)
        {
            d.fill_combobox_class(cbx_class);
            d.fill_combobox_class(cbx_select_class);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            d.delete_material(txt_mat.Text);
        }

        private void btn_del_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            btn_del_mat.Visible = true ;
            btn_add_mat.Visible = false;
            cbx_class.Visible = false;
            cmd.animate_width(panel3, 0, 289);
        }

        private void btn_show_mat_Click(object sender, EventArgs e)
        {
            cmd.animate_hight(panel_show_mat, 0, 359);
            panel_show_mat.Visible = true;
            panel3.Visible = false;
            cbx_select_class.Visible = true;
            d.fill_combobox_class(cbx_select_class); 

        }

        private void cbx_select_mat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //d.select_all_materials(dgv_mat, Convert.ToInt32(cbx_select_class.SelectedValue.ToString()));
        }

        private void btn_add_mat_Click(object sender, EventArgs e)
        {
            d.insert_material(txt_mat.Text, Convert.ToInt32(cbx_class.SelectedValue.ToString()));
        }

        private void cbx_select_mat_SelectedValueChanged(object sender, EventArgs e)
        {
            //
        }

        private void show_in_dgv_Click(object sender, EventArgs e)
        {
            d.select_all_materials(dgv_mat, Convert.ToInt32(cbx_select_class.SelectedValue.ToString()));
        }

        private void btn_update_mat_Click(object sender, EventArgs e)
        {
            btn_add_mat.Visible = false;
            btn_del_mat.Visible = false;
           
            cbx_class.Visible = true;
           
        }

        private void pic_small_MouseHover(object sender, EventArgs e)
        {
            pic_big.Visible = true;
            pic_small.Visible = false;
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
