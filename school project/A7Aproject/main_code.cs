
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public class main_code
    {
        //database_code database = new database_code();
        Form form;
        private int id;
        private String user_name;
      /*  public void login_validity(String username, String password, Form name_of_closing_form)
        {
            if (database.login_validity(username, password))
            {
                MessageBox.Show("sucessful login");
                //form = new newform();
                name_of_closing_form.Hide();
                form.Show();

            }
            else
            {
                MessageBox.Show("please enter a valid username and password");
            }
        }
        */
        // GUI 
        // all codes of gui we will need in our project in methods 
        public void animate_width(Panel panel, int start, int end)
        {
            if (panel.Width == start)
            {
                while (panel.Width < end)
                    panel.Width += 10;
            }
            else
            {

                while (panel.Width > start)
                    panel.Width -= 10;
            }
        }

        public void animate_hight(Panel panel, int start, int end)
        {
            if (panel.Height == start)
           {
                while (panel.Height < end)
                    panel.Height += 10;
            }
            else
            {

                while (panel.Height > start)
                    panel.Height -= 10;
            }
        }
        public void ShowPanel(Panel panel, int start)
        {
            if (panel.Height != start)
            {
                while (panel.Height < start)
                    panel.Height += 1;
            }
          
        }
        public void methodSetForm(Panel p, Form f)
        {
            p.Controls.Clear();


            f.FormBorderStyle = FormBorderStyle.None;
            p.Controls.Add(f);
            f.Show();

        }
        public void methodSetInteger(KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            if (!char.IsDigit(c) )
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void methodSetLatter(KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // users needed codes
        public void set_user_id(int id)
        {
            this.id = id;
        }
        public int get_id()
        {
            return id;
        }
        public String get_user_name()
        {
            return user_name;
        }
        public void set_user_name(String user_name)
        {
            this.user_name = user_name;
        }

    }
}
