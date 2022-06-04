using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace A7Aproject
{
    class database
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QGSDVTU;Initial Catalog=school2;Integrated Security=True");
        SqlCommand cmd;
                                                         /*insert functions*/
        public void open_connection()
        {
            try
            {
                con.Open();
            }
            catch
            {
             
            }
        }
        public void close_connection()
        {
            try
            {
                con.Close();
            }
            catch
            {
               
            }
        }
        public void select_manage_password(string username , TextBox tv)
        {
            try
            {
                open_connection();

                cmd = new SqlCommand("select password from manage where username = '" + username + "' ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tv.Text = dr.GetValue(0).ToString();
                }

                close_connection();
            }
            catch
            {

            }
        }
        public bool authentication(string username, string passw)
        {
            int i=0;
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from login where username = '"+username+"' and password ='"+passw+"'  ;", con); 
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("Enter correct username and password" ,"Message" ,MessageBoxButtons.OK ,MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("successfull login", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    return true;
                }


                close_connection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
            
        }
        public void insert_login_data_into_manage_table(int id ,string name ,string lname, int dept_id ,string username ,string password ,string re_password,string phone)
        {
            if (password == re_password)
            {
                try
                {
                    open_connection();
                    cmd = new SqlCommand("insert into manage values ('" + id + "','" + name + "','" + lname + "','" + dept_id + "','" + username + "','" + password + "','" + phone + "') ;", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    MessageBox.Show("login data Added successfully to manage table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("the passwords are not identical !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public void insert_teacher_data(string name, int id, string address,int salary, string special_at)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("insert into teacher values ('" + name + "','" + id + "','" + address + "' ,'"+salary+"',1,'" + special_at + "') ;", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Teacher Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert_student_data(string name,string address ,int class_id  ,int father_id )
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("insert into student(name ,address ,class_id,father_id ,date ,fees_state) values ('" + name + "','" + address + "' ,'" + class_id + "' ,'" + father_id + "','" + DateTime.Now + "' ,0 );", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Student Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert_father_data(string name,  string address, string job ,int id )
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("insert into father(name ,address ,job ,id) values('" + name + "'   ,'" + address + "' ,'" + job + "' ,'"+id+"' ) ;", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Father Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch 
            {
                //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert_class_data( int id ,string name ,int teacher_id)
        {
            //try
            //{
                open_connection();
                cmd = new SqlCommand("insert into class(id,cname,teacher_id) values('"+id+"' ,'" + name + "' ,'" + teacher_id + "' ) ;", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Class Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch
            //{
            //    MessageBox.Show("Class '" + name + "'already exists ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        public void insert_login_data_into_login_table(int manage_id, string username, string password)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("insert into login values('" + manage_id + "' ,'" + username + "' ,'" + password + "' );" ,con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Registeration Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void insert_material(string name, int  class_id)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("insert into material  (mtname ,class_id) values('" + name + "' ,'" + class_id + "' );" ,con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Mareial Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Material already exists in this class ","Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert_report(int id, int price, string title ,int manage_id)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("insert into report values('" + id + "' ,'" + price + "' ,'" + title + "'  ,'"+manage_id+"') ;" ,con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Report Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert_worker(int id, string name, int salary, int dept_id)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("insert into workers values('" + id + "' ,'" + name + "' ,'" + salary + "'  ,'" + dept_id + "');", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Worker Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert_grade(string name, string mtname, int grade)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("insert into grade values((select id from student where name='"+name+"'),(select id from material where mtname ='"+mtname+"'),'"+grade+"');", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("grade Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert_manage(int id, string name, int salary, int dept_id)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("insert into workers values('" + id + "' ,'" + name + "' ,'" + salary + "'  ,'" + dept_id + "');", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Manager Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                                              /*End insert functions*/
        public void delete_classes(string name)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("delete from class where name = '"+name+"'   ;" , con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("class deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void delete_student(int id)
        {
            try
            {
                if (count_students_id(id) != 0)
                {
                    open_connection();
                    cmd = new SqlCommand("delete from student where id ='" + id + "' ;", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    MessageBox.Show("student  deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("There is not student with this ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void delete_teacher(int id)
        {
            try
            {
                if (is_exists(id))
                {
                    open_connection();
                    cmd = new SqlCommand("delete from teacher where id ='" + id + "' ;", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    MessageBox.Show("teacher  deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("There is not teacher with this ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void delete_material(string s)
        {
            try
            {
                if (count_material(s) != 0)
                {
                    open_connection();
                    cmd = new SqlCommand("delete from material where mtname ='" + s + "' ;", con);
                    cmd.ExecuteNonQuery();
                    close_connection();
                    MessageBox.Show("Material deleted successfully  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("There is not material with this name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void select_all_student_in_the_same_class(DataGridView dgv ,int id){
            try
            {
                open_connection();
                cmd = new SqlCommand("select name,id,class_id from student where class_id = '"+id+"' ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void select_all_teachers(DataGridView dgv)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from teacher ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void select_all_materials(DataGridView dgv, int class_id)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from material where class_id = '"+class_id+"'  ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void select_all_classes(DataGridView dgv)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from class ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void select_all_paid_student(DataGridView dgv)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from student where fees_state = 1 ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void select_all_Not_paid_student(DataGridView dgv)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from student where fees_state = 0;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public int count_material(string s)
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from material where mtname ='"+s+"' ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i;
        }
        public int count_students()
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from student ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                 i = Convert.ToInt32(dt.Rows.Count.ToString());
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i;
        }
        public int count_class()
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from class ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i;
        }
        public int count_students_id(int id)
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from student where id = '"+id+"' ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i;
        }
        public int count_teachers()
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from teacher ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i;
        }
        public bool is_exists(int id)
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from teacher where id ='"+id+"'   ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i != 0;
        } 
        public int count_workers()
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from workers ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i;
        }
        public void fill_combobox_class(ComboBox cbx )
        {

            //try
            //{
                open_connection();
                cmd = new SqlCommand("select * from class ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "cname";
                cbx.ValueMember = "id";
                
               
                close_connection();
            //}
            //catch (Exception ex)
            //{
     
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
        public void fill_combobox_material(ComboBox cbx)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select * from material  ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "name";
                cbx.ValueMember = "id";
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_combobox_material_of_specific_class(ComboBox cbx ,string s)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select * from material where class_id =(select id from class where name = '"+s+"' )  ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "name";
                cbx.ValueMember = "id";
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_combobox_material_in_the_same_class(ComboBox cbx ,string s)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select * from material where class_id =( select class_id from material where name ='"+s+"')  ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "name";
                cbx.ValueMember = "id";
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_combobox_student_in_the_same_class(ComboBox cbx ,int id)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select * from student where class_id = '"+id+"' ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "name";
                cbx.ValueMember = "id";
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_combobox_student(ComboBox cbx)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select * from student;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "name";
                cbx.ValueMember = "id";
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_combobox_teacher(ComboBox cbx)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select * from teacher;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "name";
                cbx.ValueMember = "id";
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void fill_combobox_DEPARTMENT(ComboBox cbx)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select * from dept;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbx.DataSource = dt;
                cbx.ValueMember = "id";
                cbx.DisplayMember = "name";
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void update_student(string fname ,string mname ,string lname ,string address ,int class_id , int student_id)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("update student set fname='" + fname + ", mname ='" + mname + ", lname='" + lname + ", address='" + address + ",class_id='" + class_id + "' where id= '"+student_id+"' ;", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Student updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void get_values_of_teacher_in_text_boxes(int id,TextBox name ,TextBox address ,TextBox salary,TextBox specialization)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from teacher where id = '" + id + "' ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
                int count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count == 0)
                {
                    name.Text = "";
                    address.Text = "";
                    salary.Text = "";
                    specialization.Text = "";
               
                }
                else
                {

                    string tname = dt.Rows[0][0].ToString();
                    string t_addr = dt.Rows[0][2].ToString();
                    string t_salary = dt.Rows[0][3].ToString();
                    string spec = dt.Rows[0][5].ToString();


                    name.Text = tname;
                    address.Text = t_addr;
                    salary.Text = t_salary;
                    specialization.Text = spec;


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void get_values_of_student_in_text_boxes(int id, TextBox name, TextBox address)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from student where id = '" + id + "' ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
                int count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count == 0)
                {
                    name.Text = "";
                    address.Text = "";

                }
                else
                {

                    string std_name = dt.Rows[0][0].ToString();
                    string std_addr = dt.Rows[0][2].ToString();
                    
                    //string fess = dt.Rows[0][6].ToString();

                    name.Text = std_name;
                    address.Text = std_addr;
                    
       


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void update_teacher(string name, int id ,string  address, int salary , string special_at)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("update teacher set name='"+name+"' ,address ='"+address+"' ,salary ='"+salary+"' ,special_at ='"+special_at+"' where id='"+id+"'  ;", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Teacher updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void update_student(int std_id ,string name, string address ,int  class_id)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("update student set name='" + name + "' ,address ='" + address + "' , class_id ='"+class_id+"'  where id='" + std_id + "'  ;", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("student updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void update_class(string name, int id, int teacher_id)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("update class set name ='"+name+"',teacher_id ='"+teacher_id+"' where id ='"+id+"' ;", con);
                cmd.ExecuteNonQuery();
                close_connection();
                MessageBox.Show("Class updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void update_material(string name, int id, int class_id)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("update material set name ='" + name + "',class_id ='" + class_id + "' where id ='"+id+"'  ;", con);
                cmd.ExecuteNonQuery();

                close_connection();
                MessageBox.Show("Class updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void update_grade(string name ,string mtname ,int grade)
        {
            try
            {
                open_connection();
                cmd = new SqlCommand("update grade set grade ='" + grade + "' where std_id =(select id from student where name ='"+name+"' )and mat_id = (select id from material where mtname ='"+mtname+"') ;", con);
                cmd.ExecuteNonQuery();

                close_connection();
                MessageBox.Show("grade updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool is_this_student_exists(string name)
        {
            int i = 0;
            try
            {
                open_connection();
                cmd = new SqlCommand("select * from student where name ='"+name+"'  ;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i != 0;
        }
        public void pay_fees(string name, int money)
        {
            try
            {
                if (!is_this_student_exists(name))
                {
                    MessageBox.Show("there is not student with this name !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    open_connection();
                    cmd = new SqlCommand("update student set fees_state =1 where name ='" + name + "'  ;", con);
                    cmd.ExecuteNonQuery();

                    close_connection();
                }
                MessageBox.Show("Fees paid successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void all_grades_of_one_student(DataGridView dgv, string name)
        {

            try
            {
                open_connection();
                cmd = new SqlCommand("select name , mtname , grade from student s inner join material mt on s.id =(select id from student where name='"+name+"') inner join  grade g on g.mat_id =mt.id;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                close_connection();
                MessageBox.Show("done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }








    }
}
