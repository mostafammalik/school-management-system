//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using MySql.Data.MySqlClient;
//using System.Windows.Forms;
//using System.Data;
//using System.IO;
//using System.Drawing;


//namespace ClinicApplication
//{
//    class DataBase_code
//    {
//        private static String server = "localhost";
//        private static String server = "192.168.1.11";
//        private static String database = "clinic_v02";
//        private static String UID = "root";
//        private static String password = "";
//        private static String SslMode = "none";
//        MySqlConnection con = new MySqlConnection("Server=" + server +
//            ";database=" + database +
//            ";UID=" + UID +
//            ";password=" + password +
//            ";SslMode=" + SslMode +
//            "");
//        MySqlCommand cmd;


//        public void openconnection()
//        {
//            try
//            {
//                con.Open();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message + "error in open connection with my sql");

//            }
//        }

//        public void closeconnection()
//        {
//            try
//            {
//                con.Close();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message + "error in clossing connection with my sql");
//            }
//        }


//        public Boolean login_validity_user(String username, String password)
//        {
//            int i = 0;
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("SELECT * from user_login where user_name='" + username + "' and password='" + password + "'", con);
//                cmd.ExecuteNonQuery();
//                DataTable dt = new DataTable();
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                da.Fill(dt);
//                i = Convert.ToInt32(dt.Rows.Count.ToString());
//                closeconnection();
//                if (i == 0)
//                {
//                    MessageBox.Show("please enter an invalid user name or password ");
//                    return false;
//                }
//                else
//                {
//                    MessageBox.Show("successful login");

//                    return true;
//                }
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message + "error in login with my sql");
//                closeconnection();
//                return false;
//            }


//        }
//        public Boolean login_validity_clinic(String username, String password)
//        {
//            int i = 0;
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("SELECT * from clinic_login where user_name='" + username + "' and password='" + password + "'", con);
//                cmd.ExecuteNonQuery();
//                DataTable dt = new DataTable();
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                da.Fill(dt);
//                i = Convert.ToInt32(dt.Rows.Count.ToString());
//                closeconnection();
//                if (i == 0)
//                {
//                    MessageBox.Show("please enter an invalid user name or password ");
//                    return false;
//                }
//                else
//                {
//                    MessageBox.Show("successful login");

//                    return true;
//                }
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message + "error in login with my sql");
//                closeconnection();
//                return false;
//            }


//        }
//        public Boolean login_validity_manager(String username, String password)
//        {
//            int i = 0;
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("SELECT * from manager_login where user_name='" + username + "' and password='" + password + "'", con);
//                cmd.ExecuteNonQuery();
//                DataTable dt = new DataTable();
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                da.Fill(dt);
//                i = Convert.ToInt32(dt.Rows.Count.ToString());
//                closeconnection();
//                if (i == 0)
//                {
//                    MessageBox.Show("please enter an invalid user name or password ");
//                    return false;
//                }
//                else
//                {
//                    MessageBox.Show("successful login");

//                    return true;
//                }
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message + "error in login with my sql");
//                closeconnection();
//                return false;
//            }


//        }

//        public void add_user_email(String user_name)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("insert into user_login (user_name) values ('" + user_name + "') ;", con);
//                cmd.ExecuteNonQuery();
//                closeconnection();
//                MessageBox.Show("clinic added to the system");
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + " error in add_user_email");
//                closeconnection();
//            }
//        }
//        public void add_clinic_email(String user_name)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("insert into clinic_login (user_name) values ('" + user_name + "') ;", con);
//                cmd.ExecuteNonQuery();
//                closeconnection();
//                MessageBox.Show("clinic added to the system");

//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + " error in add_clinic_email");
//                closeconnection();
//            }
//        }

//        update with user name and password
//        public void update_user_email(String user_name, String password)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("update  user_login set  user_name='" + user_name + "',password ='" + password + "' where user_name='" + user_class.get_user_name() + "';", con);
//                cmd.ExecuteNonQuery();
//                closeconnection();
//                MessageBox.Show("clinic added to the system");
//                user_class.set_user_user_name(user_name);
//                user_class.set_user_id(getting_id_of_a_specific_user_name(user_name));
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + " error in updatin  the user name and password of the user");
//                closeconnection();
//            }
//        }
//        public void update_clinic_email(String user_name, String password)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("update  clinic_login set  user_name='" + user_name + "',password ='" + password + "' where user_name='" + clinic_class.get_user_name() + "';", con);
//                cmd.ExecuteNonQuery();
//                closeconnection();
//                MessageBox.Show("clinic added to the system");
//                clinic_class.set_user_name(user_name);
//                clinic_class.set_clinic_id(getting_id_of_a_specific_clinic_name(user_name));
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + " error in updating the user name and password of clinic");
//                closeconnection();
//            }
//        }

//        update with user name only

//        public void update_user_email(String user_name)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("update  user_login set  user_name='" + user_name + "' where user_name='" + user_class.get_user_name() + "';", con);
//                cmd.ExecuteNonQuery();
//                closeconnection();
//                MessageBox.Show("clinic added to the system");
//                user_class.set_user_user_name(user_name);
//                user_class.set_user_id(getting_id_of_a_specific_user_name(user_name));
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + " error in updatin the user name of user");
//                closeconnection();
//            }
//        }
//        public void update_clinic_email(String user_name)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("update  clinic_login set  user_name='" + user_name + "' where user_name='" + clinic_class.get_user_name() + "';", con);
//                cmd.ExecuteNonQuery();
//                closeconnection();
//                MessageBox.Show("clinic ");
//                clinic_class.set_user_name(user_name);
//                clinic_class.set_clinic_id(getting_id_of_a_specific_clinic_name(user_name));
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + " error in updating user name of clinic");
//                closeconnection();
//            }
//        }


//        public Boolean is_this_user_name_found_for_clinic(String user_name)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("SELECT * from clinic_login where user_name='" + user_name + "' ;", con);
//                cmd.ExecuteNonQuery();
//                DataTable dt = new DataTable();
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                da.Fill(dt);
//                int i = Convert.ToInt32(dt.Rows.Count.ToString());
//                closeconnection();
//                if (i == 0)
//                {
//                    MessageBox.Show("please enter an invalid user name or password ");
//                    return false;
//                }
//                else
//                {
//                    MessageBox.Show("successful login");

//                    return true;
//                }
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message + "error in login with my sql");
//                closeconnection();
//                return false;
//            }
//        }

//        public Boolean is_this_user_name_found_for_user(String user_name)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("SELECT * from user_login where user_name='" + user_name + "' ;", con);
//                cmd.ExecuteNonQuery();
//                DataTable dt = new DataTable();
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                da.Fill(dt);
//                int i = Convert.ToInt32(dt.Rows.Count.ToString());
//                closeconnection();
//                if (i == 0)
//                {
//                    MessageBox.Show("please enter an invalid user name or password ");
//                    return false;
//                }
//                else
//                {
//                    MessageBox.Show("successful login");

//                    return true;
//                }
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message + "error in login with my sql");
//                closeconnection();
//                return false;
//            }
//        }

//        public void add_clinic(String clinic_name, String clinic_address, string days_of_work, String clinic_worker_name, String clinic_username,
//        String clinic_region, int clinic_start_time, int clinic_end_time, int clinic_hours, String doctor_first_name, String doctor_middle_name,
//         String doctor_last_name, String doctor_specialization)
//        {

//            /*
//             * INSERT into clinic (name,address, days_of_work,hours_per_day,start_time,end_time,region_name,
//                   worker_name,user_name,doctor_first_name,doctor_middle_name,doctor_last_name,
//                   doctor_specialization,availability) VALUES ('alhaya clinic','naghammady , 30march street,nearby sporting',
//                   'friday suterday mnday',12,8,14,'naghammady','mohamed mahmoud hassan' , 'alhayaclinic77' , 'ahmed' , 'amir' , 'mamdoh' , 'stomac',1);
//        */
//            try
//            {
//                int hours_per_day = clinic_end_time - clinic_start_time;
//                add_clinic_email(clinic_username);
//                openconnection();
//                cmd = new MySqlCommand("INSERT into clinic (name,address, days_of_work,hours_per_day,start_time,end_time,region_name,worker_name," +
//                    " user_name, doctor_first_name, doctor_middle_name, doctor_last_name, doctor_specialization, availability) VALUES " +
//                    "('" + clinic_name + "','" + clinic_address + "','" + days_of_work + "'," + clinic_hours + "," + clinic_start_time + "," + clinic_end_time +
//                    ",'" + clinic_region + "','" + clinic_worker_name + "','" + clinic_username + "','" + doctor_first_name + "','" + doctor_middle_name
//                    + "','" + doctor_last_name + "','" + doctor_specialization + "'," + 0 + ");", con);
//                cmd.ExecuteNonQuery();
//                closeconnection();
//                MessageBox.Show("clinic added to the system");
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + " error in adding a clinic");
//                closeconnection();
//            }
//        }


//        public void view_all_clinics(DataGridView dgv)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select * from clinic", con);
//                MySqlCommand cmd1 = new MySqlCommand("select * from doctor", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                 DataTable table1 = new DataTable();
//                da.Fill(table);


//                 trying to delete

//                table.Load(cmd.ExecuteReader());
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is now data to show");
//                    dgv.DataSource = table;
//                }
//                else
//                    dgv.DataSource = table;
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in view all clinics");
//                closeconnection();
//            }
//        }

//        ===================================================================

//        public void clinic_profile(int ID, Label name, Label name2, Label address, Label lbl_clinic_specialization_2,
//            Label lbl_contact1, Label lbl_contact2, Label lbl_contact_whats, Label lbl_clinic_days, Label lbl_clinic_start_time,
//            Label lbl_end, Label lbl_clinic_availability, Label lbl_doctor_name, Label lbl_doctor_age,
//            Label lbl_doctor_specialization, Label lbl_year_of_graduation)
//        {

//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select * from clinic where id = " + ID + ";", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                da.Fill(table);
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is now data to show");
//                    name.Text = "";
//                    name2.Text = "";
//                    address.Text = "";
//                    lbl_clinic_specialization_2.Text = "";

//                    lbl_contact1.Text = "";
//                    lbl_contact2.Text = "";
//                    lbl_contact_whats.Text = "";
//                    lbl_clinic_days.Text = "";
//                    lbl_clinic_start_time.Text = "";
//                    lbl_end.Text = "";
//                    lbl_clinic_availability.Text = "";
//                    lbl_doctor_name.Text = "";
//                    lbl_doctor_age.Text = "";
//                    lbl_doctor_specialization.Text = "";
//                    lbl_year_of_graduation.Text = "";
//                }
//                else
//                {
//                    decleare vars
//                    int id = Convert.ToInt32(table.Rows[0][0]);
//                    String clinic_name = table.Rows[0][1].ToString();
//                    String clinic_address = table.Rows[0][2].ToString();
//                    String days_of_work = table.Rows[0][3].ToString();
//                    int hours_per_day = Convert.ToInt32(table.Rows[0][4]);
//                    int start_time = Convert.ToInt32(table.Rows[0][5]);
//                    int end_time = Convert.ToInt32(table.Rows[0][6]);
//                    int availability = Convert.ToInt32(table.Rows[0][7]);
//                    String region_name = table.Rows[0][8].ToString();
//                    String worker_name = table.Rows[0][9].ToString();
//                    String username = table.Rows[0][10].ToString();
//                    String doctor_name = table.Rows[0][11].ToString() + " " + table.Rows[0][12].ToString() + " " + table.Rows[0][13].ToString();
//                    String Specialization = table.Rows[0][14].ToString();

//                    name.Text = clinic_name;
//                    name2.Text = clinic_name;
//                    address.Text = clinic_address;
//                    lbl_clinic_specialization_2.Text = Specialization;

//                    lbl_contact1.Text = "";
//                    lbl_contact2.Text = "";
//                    lbl_contact_whats.Text = "";
//                    lbl_clinic_days.Text = days_of_work;
//                    lbl_clinic_start_time.Text = start_time.ToString();
//                    lbl_end.Text = end_time.ToString();
//                    lbl_clinic_availability.Text = availability.ToString();
//                    lbl_doctor_name.Text = doctor_name;
//                    lbl_doctor_age.Text = "";
//                    lbl_doctor_specialization.Text = Specialization;
//                    lbl_year_of_graduation.Text = "";

//                }

//                decleare vars



//                /*days.Text = days_of_work;
//                start.Text = start_time.ToString();
//                end.Text = end_time.ToString();
//                available.Text = availability.ToString();
//                region.Text = region_name;
//                doctor.Text = doctor_name;
//                specialize.Text = Specialization;
//                specialize_clinic1.Text = Specialization;
//                specialize_clinic2.Text = Specialization;
//                */
//                da.Dispose();
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in clinic profile");
//                closeconnection();
//            }
//        }


//        public void delete_clinic(int id)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("delete from clinic where id=" + id, con);
//                if (cmd.ExecuteNonQuery() == 1)
//                {
//                    MessageBox.Show("deleted");
//                }
//                else MessageBox.Show("something is wrong in deletinig the clinic");
//                closeconnection();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex + "error in deleting clinic handeled exception");
//                closeconnection();
//            }
//        }


//        public void user_profile(int ID, Label lbl_name, Label lbl_national_id, Label lbl_phone, Label lbl_email, Label lbl_user_name)
//        {

//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select * from user where id = " + ID + ";", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                da.Fill(table);
//                decleare vars
//                int id = Convert.ToInt32(table.Rows[0][0]);
//                String clinic_name = table.Rows[0][1].ToString();
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is now data to show");
//                    lbl_name.Text = "";
//                    lbl_email.Text = "";
//                    lbl_phone.Text = "";
//                    lbl_national_id.Text = "";
//                    lbl_user_name.Text = "";
//                }
//                else
//                {
//                    String name = table.Rows[0][2].ToString() + " " + table.Rows[0][3].ToString() + " " + table.Rows[0][4].ToString();
//                    String national_id = table.Rows[0][5].ToString();
//                    String phone_number = table.Rows[0][1].ToString();
//                    String email = table.Rows[0][6].ToString();
//                    int id = Convert.ToInt32(table.Rows[0][0].ToString());
//                    String user_name = table.Rows[0][8].ToString();


//                    lbl_name.Text = name;
//                    lbl_email.Text = email;
//                    lbl_phone.Text = phone_number;
//                    lbl_national_id.Text = national_id;
//                    lbl_user_name.Text = user_name;
//                }
//                da.Dispose();
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in user profile");
//                closeconnection();
//            }
//        }

//        public Boolean check_user_name_sign_up(String user_name)
//        {
//            int i = 0;
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("SELECT * from login where user_name='" + user_name + "'", con);
//                cmd.ExecuteNonQuery();
//                DataTable dt = new DataTable();
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                da.Fill(dt);
//                i = Convert.ToInt32(dt.Rows.Count.ToString());
//                closeconnection();
//                if (i == 0)
//                {
//                    MessageBox.Show("this user name is not in the system u can shose it");
//                    return true;
//                }
//                else
//                {
//                    MessageBox.Show(" u can not use this user name because it is already used");

//                    return false;
//                }
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message + "error in login with my sql");
//                closeconnection();
//                return false;
//            }
//        }

//        /*
//         * 
//         * number in queue should idea to handle is 
//         * getting the last number of the queue in our day and increment it by 1
//         * if day now is different as the day in the last record in database it will be 1
//         * we can get the last record in this way 
//         * SELECT * FROM "table name" ORDER BY "id" DESC LIMIT 1
//         * getting the date time in c#
//         * DateTime dateTime = DateTime.UtcNow.Date;
//         * Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
//         */



//        public String string_to_date(String d)
//        {
//            MessageBox.Show(d);
//            String date="";

//            if (d[1] == '/')
//                d = '0' + d;
//            for (int i = 0; i < 10; i++)
//            {

//                 date += d[i];
//            }
//            return date;


//        }

//        public int insert_in_queue(int clinic_id_gui)
//        {
//            DateTime dateTime = DateTime.UtcNow.Date;
//            String today_date = dateTime.ToString("yyyy-MM-dd");
//            String date_in_database = "0000-00-00";

//            int i;
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("SELECT date_of_reservation from reservation where clinic_id=" + clinic_id_gui + " ORDER BY reservation_id DESC LIMIT 1 ;", con);
//                cmd.ExecuteNonQuery();
//                DataTable dt = new DataTable();
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                da.Fill(dt);
//                i = Convert.ToInt32(dt.Rows.Count.ToString());
//                DateTime d = new DateTime();

                
//                 DateTime d = (DateTime)date_in_database ;

//                && 
//                da.Dispose();
//                closeconnection();
//                if (i != 0)
//                {
//                    d = (DateTime)dt.Rows[0][0];
//                    date_in_database = d.ToString("yyyy-MM-dd");
//                    MessageBox.Show("date_in_database" + date_in_database);
//                    if (!date_in_database.Equals(today_date))
//                        return -1;
//                    else
//                    {
//                        MessageBox.Show("this user name is not in the system u can shose it");
//                        openconnection();
//                        cmd = new MySqlCommand("SELECT number_in_queue from reservation where clinic_id = " + clinic_id_gui + " and date_of_reservation = '" + date_in_database + "' ORDER BY reservation_id DESC LIMIT 1", con);
//                        cmd.ExecuteNonQuery();
//                        DataTable dt1 = new DataTable();
//                        MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
//                        da1.Fill(dt1);
//                        int previous_number_in_queue;
//                        int y = Convert.ToInt32(dt1.Rows.Count.ToString());
//                        if (y != 0)
//                            previous_number_in_queue = Convert.ToInt32(dt1.Rows[0][0].ToString());
//                        else
//                            previous_number_in_queue = 0;

//                        MessageBox.Show(previous_number_in_queue.ToString());
//                        da1.Dispose();
//                        closeconnection();
//                        return previous_number_in_queue;
//                    }

//                }
//                else
//                {
//                    MessageBox.Show(" u can not use this user name because it is already used");
//                    return -1;
//                }
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show("error in insert in queue");
//                closeconnection();
//                return -1;
//            }
//        }

//        public void add_a_reservation(int user_id, int clinic_id, String reservation_user_name, String reservation_phone_number,
//            int number_in_queue)
//        {
//            DateTime dateTime = DateTime.UtcNow.Date;
//            String today_date = dateTime.ToString("yyyy-MM-dd");
//            try
//            {
//                int hours_per_day = clinic_end_time - clinic_start_time;
//                openconnection();
//                cmd = new MySqlCommand("INSERT into reservation (user_id,clinic_id,reservation_user_name,reservation_phone_number,number_in_queue,date_of_reservation) VALUES " +
//                    "(" + user_id + "," + clinic_id + ",'" + reservation_user_name + "','" + reservation_phone_number + "'," + number_in_queue + ",'" + today_date + "')", con);
//                cmd.ExecuteNonQuery();
//                closeconnection();
//                MessageBox.Show("reservation added to the system");
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + " error in adding a reservation");
//                closeconnection();
//            }
//        }

//        public int getting_id_of_a_specific_user_name(String user_name)
//        {
//            int id = 0;
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select id from user where user_name = '" + user_name + "';", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                da.Fill(table);
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is no data to show no user_name in data base");
//                    id = 0;
//                }
//                else
//                    id = Convert.ToInt32(table.Rows[0][0].ToString());

//                da.Dispose();
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in user profile");
//                closeconnection();
//            }
//            return id;
//        }

//        public int getting_id_of_a_specific_clinic_name(String clinic_name)
//        {
//            int id = 0;
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select id from clinc where name = '" + clinic_name + "';", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                da.Fill(table);
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is no data to show no clinic_name in data base");
//                    id = 0;
//                }
//                else
//                    id = Convert.ToInt32(table.Rows[0][0].ToString());

//                da.Dispose();
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in user profile");
//                closeconnection();
//            }
//            return id;
//        }

//        public void view_all_clinics(DataGridView dgv, String specialization)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select * from clinic where doctor_specialization = '" + specialization + "'", con);
//                MySqlCommand cmd1 = new MySqlCommand("select * from doctor", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                DataTable table1 = new DataTable();
//                da.Fill(table);
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is no data to show no user_name in data base");
//                    dgv.DataSource = table;
//                }
//                else
//                {

//                    dgv.DataSource = table;
//                }
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in view all clinics");
//                closeconnection();
//            }
//        }

//        public void informe_a_reservation(String national_id, int clinic_id, Label lbl_reservation_name, Label lbl_phone, Label lbl_doctor_name, Label lbl_number_in_queue,
//            Label lbl_date, Label lbl_specialization, Label lbl_region)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select * from reservation where national_id = '" + national_id + "' and clinic_id = " + clinic_id + ";", con);
//                MySqlCommand cmd1 = new MySqlCommand("select * from doctor", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                DataTable table1 = new DataTable();
//                da.Fill(table);
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is no data to show in inform a resrvation");
//                    lbl_date.Text = "";
//                    lbl_doctor_name.Text = "";
//                    lbl_number_in_queue.Text = "";
//                    lbl_phone.Text = "";
//                    lbl_region.Text = "";
//                    lbl_specialization.Text = "";
//                    lbl_reservation_name.Text = "";

//                }
//                else
//                {
//                     variables  and its values

//                    int clinic_id2 = Convert.ToInt32(table.Rows[0][2].ToString());
//                    String name = table.Rows[0][3].ToString();
//                    String reservation_phone_number = table.Rows[0][4].ToString();
//                    int number_in_queue = Convert.ToInt32(table.Rows[0][5].ToString());
//                    String date = table.Rows[0][6].ToString();
//                    String Doctor_name = getting_data_from_clinic_to_inform(clinic_id, "doctor_first_name") +
//                        " " + getting_data_from_clinic_to_inform(clinic_id, "doctor_middle_name") + " " +
//                        getting_data_from_clinic_to_inform(clinic_id, "doctor_last_name");
//                    String spectialization = getting_data_from_clinic_to_inform(clinic_id, "doctor_specialization");
//                    String clinic_region = getting_data_from_clinic_to_inform(clinic_id, "region_name");

//                    table.Load(cmd.ExecuteReader());
//                    dgv.DataSource = table;


//                     insert values into there labels
//                    lbl_date.Text = date;
//                    lbl_doctor_name.Text = Doctor_name;
//                    lbl_number_in_queue.Text = number_in_queue.ToString();
//                    lbl_phone.Text = reservation_phone_number;
//                    lbl_region.Text = clinic_region;
//                    lbl_specialization.Text = spectialization;
//                    lbl_reservation_name.Text = name;
//                }
//                da.Dispose();
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in view all clinics");
//                closeconnection();
//            }
//        }

//        public String getting_data_from_clinic_to_inform(int clinic_id, String demanded)
//        {
//            String the_return;
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select " + demanded + " from clinc where id = '" + clinic_id + "';", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                da.Fill(table);
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is no data to demand");
//                    the_return = "";
//                }

//                else
//                    the_return = table.Rows[0][0].ToString();


//                da.Dispose();
//                closeconnection();
//                return the_return;
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in user profile");
//                closeconnection();
//                return null;
//            }
//        }

//        public void make_clinic_holiday(int clinic_id, int value)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("update clinic set availability = " + value + ";", con);
//                if (cmd.ExecuteNonQuery() == 1)
//                {
//                    MessageBox.Show("updated");
//                }
//                else MessageBox.Show("something is wrong in updating holiday in the clinic");
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in updating a clinics");
//                closeconnection();
//            }
//        }

//        public void fill_specialization_combo(ComboBox combo)
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select * from specialization ", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                da.Fill(table);
//                combo.Items.Clear();
//                for (int i = 0; i < Convert.ToInt32(table.Rows.Count.ToString()); i++)
//                {
//                    combo.Items.Add(table.Rows[0][i].ToString());
//                }

//                da.Dispose();
//                closeconnection();

//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in adding in the combo");
//                closeconnection();
//            }
//        }

//        public void update_clinic_data(int clinic_id, String name, String address, String days_of_work, int hours_per_day,
//            int start_time, int end_time, Boolean availability, String region_name, String worker_name,
//            String user_name, String doctor_first_name, String doctor_middle_name, String doctor_last_name,
//            String doctor_specialization)
//        {
//            id name address days_of_work hours_per_day start_time end_time availability region_name worker_name user_name doctor_first_name doctor_middle_name doctor_last_name doctor_specialization
//            try
//            {
//                update_clinic_email(user_name);
//                openconnection();
//                cmd = new MySqlCommand("update clinic set name = '" + name + "' , address='" + address + "' , " +
//                    "days_of_work = '" + days_of_work + "' , hours_per_day = " + hours_per_day + " , start_time = " +
//                    start_time + " , end_time=" + end_time + " , availability=" + availability + " , region_name = '" +
//                    region_name + "' , worker_name= ' " + worker_name + "' , user_name = '" + user_name + "' , doctor_first_name='" +
//                    doctor_first_name + "' ,doctor_middle_name='" + doctor_middle_name + "' , doctor_last_name='" +
//                    doctor_last_name + "' , doctor_specialization='" + doctor_specialization + "' where id = " + clinic_id + ";", con);
//                if (cmd.ExecuteNonQuery() == 1)
//                {
//                    MessageBox.Show("updated");
//                }
//                else MessageBox.Show("something is wrong in updating holiday in the clinic");
//                closeconnection();
//                clinic_class.set_user_name(user_name);
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in updating a clinics");
//                closeconnection();
//            }
//        }

//        public void view_reservations_today(int clinic_id, DataGridView dgv)
//        {
//            DateTime dateTime = DateTime.UtcNow.Date;
//            String today_date = dateTime.ToString("yyyy-MM-dd");
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select * from reservation where clinic_id = " + clinic_id + " and " +
//                    "date_of_reservation = '" + today_date + "' ORDER by number_in_queue", con);
//                MySqlCommand cmd1 = new MySqlCommand("select * from doctor", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                DataTable table1 = new DataTable();
//                da.Fill(table);
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is no reservation today");
//                    dgv.DataSource = table;
//                }
//                table.Load(cmd.ExecuteReader());
//                else
//                    dgv.DataSource = table;
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in view all reservation_today");
//                closeconnection();
//            }
//        }

//        public void view_clinic_data_to_update(int ID, GunaTextBox name, GunaTextBox address,
//            Guna.UI.WinForms.GunaTextBox worker_name,
//            Guna.UI.WinForms.GunaTextBox region, Guna.UI.WinForms.GunaTextBox hours_per_day,
//            Guna.UI.WinForms.GunaTextBox start_time, Guna.UI.WinForms.GunaTextBox end_time, Guna.UI.WinForms.GunaTextBox user_name,
//            CheckBox availability, Guna.UI.WinForms.GunaTextBox f_name, Guna.UI.WinForms.GunaTextBox m_name,
//            Guna.UI.WinForms.GunaTextBox l_name, ComboBox specialization)
//        {

//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select * from clinic where id = " + ID + " ;", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                da.Fill(table);
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is no clinics with this id");
//                    name.Text = "";
//                    address.Text = "";
//                    worker_name.Text = "";
//                    region.Text = "";
//                    hours_per_day.Text = "".ToString();
//                    start_time.Text = "".ToString();
//                    end_time.Text = "".ToString();
//                    user_name.Text = "";
//                    availability.Checked = false;
//                    f_name.Text = "";
//                    m_name.Text = "";
//                    l_name.Text = "";
//                    specialization.Text = "";
//                }
//                decleare vars
//                else
//                {
//                    int id = Convert.ToInt32(table.Rows[0][0]);
//                    String clinic_name = table.Rows[0][1].ToString();
//                    String clinic_address = table.Rows[0][2].ToString();
//                    String clinic_days_of_work = table.Rows[0][3].ToString();
//                    int clinic_hours_per_day = Convert.ToInt32(table.Rows[0][4]);
//                    int clinic_start_time = Convert.ToInt32(table.Rows[0][5]);
//                    int clinic_end_time = Convert.ToInt32(table.Rows[0][6]);
//                    int clinic_availability = Convert.ToInt32(table.Rows[0][7]);
//                    String clinic_region_name = table.Rows[0][8].ToString();
//                    String clinic_worker_name = table.Rows[0][9].ToString();
//                    String clinic_username = table.Rows[0][10].ToString();
//                    String clinic_doctor_name = table.Rows[0][11].ToString() + " " + table.Rows[0][12].ToString() + " " + table.Rows[0][13].ToString();
//                    String clinic_Specialization = table.Rows[0][14].ToString();


//                    name.Text = clinic_name;
//                    address.Text = clinic_address;
//                    worker_name.Text = clinic_worker_name;
//                    region.Text = clinic_region_name;
//                    hours_per_day.Text = clinic_hours_per_day.ToString();
//                    start_time.Text = clinic_start_time.ToString();
//                    end_time.Text = clinic_end_time.ToString();
//                    user_name.Text = clinic_username;
//                    availability.Checked = false ? clinic_availability == 0 : true;
//                    f_name.Text = table.Rows[0][11].ToString();
//                    m_name.Text = table.Rows[0][12].ToString();
//                    l_name.Text = table.Rows[0][12].ToString();
//                    specialization.Text = clinic_Specialization;
//                }
//                decleare vars



//                /*days.Text = days_of_work;
//                start.Text = start_time.ToString();
//                end.Text = end_time.ToString();
//                available.Text = availability.ToString();
//                region.Text = region_name;
//                doctor.Text = doctor_name;
//                specialize.Text = Specialization;
//                specialize_clinic1.Text = Specialization;
//                specialize_clinic2.Text = Specialization;
//                */
//                da.Dispose();
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in clinic profile");
//                closeconnection();
//            }
//        }

//        public void who_is_next(int clinic_id, Label lbl_name, Label lbl_phone, Label lbl_queue_number)
//        {
//            DateTime dateTime = DateTime.UtcNow.Date;
//            String today_date = dateTime.ToString("yyyy-MM-dd");
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select * from reservation where clinic_id = " + clinic_id + " and end_reservation = 0 and " +
//                    "date_of_reservation='" + today_date + "' ORDER by reservation_id limit 1;", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                da.Fill(table);
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                {
//                    MessageBox.Show("there is no rservation now (the reservation has ended)");
//                    lbl_name.Text = "";
//                    lbl_phone.Text = "";
//                    lbl_queue_number.Text = "";

//                }
//                else
//                {
//                    String resrvation_name = table.Rows[0][3].ToString();
//                    String phone_number = table.Rows[0][4].ToString();
//                    String number_in_queue = table.Rows[0][5].ToString();
//                    Clinic.reservation_id = Convert.ToInt32(table.Rows[0][0].ToString());


//                    lbl_name.Text = resrvation_name;
//                    lbl_phone.Text = phone_number;
//                    lbl_queue_number.Text = number_in_queue;
//                }
//                da.Dispose();
//                closeconnection();

//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in user profile");
//                closeconnection();
//            }
//        }

//        public void end_reservation()
//        {
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("update reservation set end_reservation = " + 1 + " where reservation_id = " + Clinic.reservation_id + " ;", con);
//                if (cmd.ExecuteNonQuery() == 1)
//                {
//                    MessageBox.Show("updated");
//                }
//                else MessageBox.Show("something is wrong in updating holiday in the clinic");
//                closeconnection();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in updating a clinics");
//                closeconnection();
//            }
//        }

//        public void add_new_user(String phone_number, String first_name, String middle_name, String last_name, String national_id, String region,
//            String email, String user_name)
//        {
//            try
//            {
//                int hours_per_day = clinic_end_time - clinic_start_time;
//                add_user_email(user_name);
//                openconnection();
//                cmd = new MySqlCommand("INSERT into user (phone_number,first_name,middle_name,last_name,national_id,region,email,user_name) " +
//                    "VALUES ('" + phone_number + "','" + first_name + "','" + middle_name + "','" + last_name + "','" + national_id + "','" + region + "','" +
//                    email + "','" + user_name + "');", con);
//                cmd.ExecuteNonQuery();
//                closeconnection();
//                MessageBox.Show("user added to the system");
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + " error in adding a user");
//                closeconnection();
//            }
//        }

//        public void add_contact_to_clinic(int clinic_id, String phone_number, Boolean whats)
//        {
//            try
//            {
//                int hours_per_day = clinic_end_time - clinic_start_time;
//                openconnection();
//                cmd = new MySqlCommand("INSERT into clinics_phone_numbers( clinic_id,clinic_number,whats_app) " +
//                    "VALUES (" + clinic_id + ",'" + phone_number + "'," + whats + ");", con);
//                cmd.ExecuteNonQuery();
//                closeconnection();
//                MessageBox.Show("contact added to the system");
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + " error in adding a user");
//                closeconnection();
//            }
//        }

//        public void view_clinic_with_user_national_id(String national_id, DataGridView dgv)
//        {
//            DateTime dateTime = DateTime.UtcNow.Date;
//            String today_date = dateTime.ToString("yyyy-MM-dd");
//            try
//            {
//                openconnection();
//                cmd = new MySqlCommand("select * from reservation where national_id = '" + national_id + " and date_of_reservation =  " +
//                    today_date + "' ;", con);
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//                DataTable table = new DataTable();
//                da.Fill(table);
//                int i = Convert.ToInt32(table.Rows.Count.ToString());
//                if (i == 0)
//                    MessageBox.Show("there is no rservation now (the reservation has ended)");
//                dgv.DataSource = table;



//                da.Dispose();
//                closeconnection();

//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e + "error in user profile");
//                closeconnection();
//            }
//        }

//        public void add_phone_numbers_of_the_clinic(int clinic_id, String phone_number, String whats)
//        {

//        }
//    }
//}
