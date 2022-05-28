namespace A7Aproject
{
    partial class student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_small = new System.Windows.Forms.PictureBox();
            this.pic_big = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelADD = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.f_id = new System.Windows.Forms.TextBox();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.f_job = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.f_address = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.f_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.panelDel = new System.Windows.Forms.Panel();
            this.btn_del = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_del_id = new System.Windows.Forms.TextBox();
            this.panelShow = new System.Windows.Forms.Panel();
            this.cbx_select_class = new System.Windows.Forms.ComboBox();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_get_std = new System.Windows.Forms.Button();
            this.btn_update_std = new System.Windows.Forms.Button();
            this.txt_std_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelADD.SuspendLayout();
            this.panelDel.SuspendLayout();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(151)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.pic_small);
            this.panel1.Controls.Add(this.pic_big);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 58);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pic_small
            // 
            this.pic_small.Image = ((System.Drawing.Image)(resources.GetObject("pic_small.Image")));
            this.pic_small.Location = new System.Drawing.Point(12, 13);
            this.pic_small.Name = "pic_small";
            this.pic_small.Size = new System.Drawing.Size(47, 38);
            this.pic_small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_small.TabIndex = 5;
            this.pic_small.TabStop = false;
            this.pic_small.Click += new System.EventHandler(this.pic_small_Click);
            this.pic_small.MouseHover += new System.EventHandler(this.pic_small_MouseHover);
            // 
            // pic_big
            // 
            this.pic_big.Image = ((System.Drawing.Image)(resources.GetObject("pic_big.Image")));
            this.pic_big.Location = new System.Drawing.Point(9, 8);
            this.pic_big.Name = "pic_big";
            this.pic_big.Size = new System.Drawing.Size(54, 45);
            this.pic_big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_big.TabIndex = 6;
            this.pic_big.TabStop = false;
            this.pic_big.Visible = false;
            this.pic_big.Click += new System.EventHandler(this.pic_big_Click);
            this.pic_big.MouseLeave += new System.EventHandler(this.pic_big_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.btn_show);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 517);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 39);
            this.button5.TabIndex = 6;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelADD
            // 
            this.panelADD.AutoScroll = true;
            this.panelADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelADD.Controls.Add(this.label5);
            this.panelADD.Controls.Add(this.txt_std_id);
            this.panelADD.Controls.Add(this.btn_update_std);
            this.panelADD.Controls.Add(this.btn_get_std);
            this.panelADD.Controls.Add(this.label1);
            this.panelADD.Controls.Add(this.f_id);
            this.panelADD.Controls.Add(this.btn_add2);
            this.panelADD.Controls.Add(this.label9);
            this.panelADD.Controls.Add(this.label8);
            this.panelADD.Controls.Add(this.cbx_class);
            this.panelADD.Controls.Add(this.label11);
            this.panelADD.Controls.Add(this.f_job);
            this.panelADD.Controls.Add(this.label12);
            this.panelADD.Controls.Add(this.f_address);
            this.panelADD.Controls.Add(this.label13);
            this.panelADD.Controls.Add(this.f_name);
            this.panelADD.Controls.Add(this.label4);
            this.panelADD.Controls.Add(this.label3);
            this.panelADD.Controls.Add(this.label2);
            this.panelADD.Controls.Add(this.txt_address);
            this.panelADD.Controls.Add(this.txt_name);
            this.panelADD.Location = new System.Drawing.Point(250, 86);
            this.panelADD.Name = "panelADD";
            this.panelADD.Size = new System.Drawing.Size(301, 414);
            this.panelADD.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "id";
            // 
            // f_id
            // 
            this.f_id.Location = new System.Drawing.Point(389, 102);
            this.f_id.Name = "f_id";
            this.f_id.Size = new System.Drawing.Size(170, 29);
            this.f_id.TabIndex = 34;
            this.f_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_id_KeyPress);
            // 
            // btn_add2
            // 
            this.btn_add2.Location = new System.Drawing.Point(10, 326);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(86, 39);
            this.btn_add2.TabIndex = 10;
            this.btn_add2.Text = "ADD";
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Father Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Student Data";
            // 
            // cbx_class
            // 
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Location = new System.Drawing.Point(115, 208);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(170, 32);
            this.cbx_class.TabIndex = 30;
            this.cbx_class.SelectedIndexChanged += new System.EventHandler(this.cbx_class_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "Job";
            // 
            // f_job
            // 
            this.f_job.Location = new System.Drawing.Point(389, 187);
            this.f_job.Name = "f_job";
            this.f_job.Size = new System.Drawing.Size(170, 29);
            this.f_job.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "Address";
            // 
            // f_address
            // 
            this.f_address.Location = new System.Drawing.Point(389, 142);
            this.f_address.Name = "f_address";
            this.f_address.Size = new System.Drawing.Size(170, 29);
            this.f_address.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 24);
            this.label13.TabIndex = 23;
            this.label13.Text = "fname";
            // 
            // f_name
            // 
            this.f_name.Location = new System.Drawing.Point(389, 56);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(170, 29);
            this.f_name.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "class ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "fname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(115, 163);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(170, 29);
            this.txt_address.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(115, 116);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(170, 29);
            this.txt_name.TabIndex = 0;
            // 
            // panelDel
            // 
            this.panelDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelDel.Controls.Add(this.btn_del);
            this.panelDel.Controls.Add(this.label7);
            this.panelDel.Controls.Add(this.txt_del_id);
            this.panelDel.Location = new System.Drawing.Point(583, 86);
            this.panelDel.Name = "panelDel";
            this.panelDel.Size = new System.Drawing.Size(273, 398);
            this.panelDel.TabIndex = 8;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(8, 356);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(143, 39);
            this.btn_del.TabIndex = 35;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Enter Student ID";
            // 
            // txt_del_id
            // 
            this.txt_del_id.Location = new System.Drawing.Point(9, 99);
            this.txt_del_id.Name = "txt_del_id";
            this.txt_del_id.Size = new System.Drawing.Size(240, 29);
            this.txt_del_id.TabIndex = 33;
            this.txt_del_id.TextChanged += new System.EventHandler(this.txt_del_id_TextChanged);
            this.txt_del_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_del_id_KeyPress);
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelShow.Controls.Add(this.cbx_select_class);
            this.panelShow.Controls.Add(this.dgv_student);
            this.panelShow.Controls.Add(this.button3);
            this.panelShow.Location = new System.Drawing.Point(862, 86);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(437, 398);
            this.panelShow.TabIndex = 9;
            this.panelShow.Visible = false;
            // 
            // cbx_select_class
            // 
            this.cbx_select_class.FormattingEnabled = true;
            this.cbx_select_class.Location = new System.Drawing.Point(0, 12);
            this.cbx_select_class.Name = "cbx_select_class";
            this.cbx_select_class.Size = new System.Drawing.Size(170, 32);
            this.cbx_select_class.TabIndex = 31;
            this.cbx_select_class.SelectedIndexChanged += new System.EventHandler(this.cbx_select_class_SelectedIndexChanged);
            this.cbx_select_class.SelectedValueChanged += new System.EventHandler(this.cbx_select_class_SelectedValueChanged);
            // 
            // dgv_student
            // 
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Location = new System.Drawing.Point(3, 59);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.Size = new System.Drawing.Size(431, 336);
            this.dgv_student.TabIndex = 0;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(12, 258);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(143, 39);
            this.btn_show.TabIndex = 7;
            this.btn_show.Text = "Show student";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_get_std
            // 
            this.btn_get_std.Location = new System.Drawing.Point(204, 259);
            this.btn_get_std.Name = "btn_get_std";
            this.btn_get_std.Size = new System.Drawing.Size(81, 35);
            this.btn_get_std.TabIndex = 36;
            this.btn_get_std.Text = "Get info";
            this.btn_get_std.UseVisualStyleBackColor = true;
            this.btn_get_std.Visible = false;
            this.btn_get_std.Click += new System.EventHandler(this.btn_get_std_Click);
            // 
            // btn_update_std
            // 
            this.btn_update_std.Location = new System.Drawing.Point(115, 259);
            this.btn_update_std.Name = "btn_update_std";
            this.btn_update_std.Size = new System.Drawing.Size(81, 35);
            this.btn_update_std.TabIndex = 37;
            this.btn_update_std.Text = "Update";
            this.btn_update_std.UseVisualStyleBackColor = true;
            this.btn_update_std.Visible = false;
            this.btn_update_std.Click += new System.EventHandler(this.btn_update_std_Click);
            // 
            // txt_std_id
            // 
            this.txt_std_id.Location = new System.Drawing.Point(115, 54);
            this.txt_std_id.Name = "txt_std_id";
            this.txt_std_id.Size = new System.Drawing.Size(170, 29);
            this.txt_std_id.TabIndex = 38;
            this.txt_std_id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "ID";
            this.label5.Visible = false;
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 575);
            this.Controls.Add(this.panelDel);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelADD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "student";
            this.Load += new System.EventHandler(this.student_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelADD.ResumeLayout(false);
            this.panelADD.PerformLayout();
            this.panelDel.ResumeLayout(false);
            this.panelDel.PerformLayout();
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_small;
        private System.Windows.Forms.PictureBox pic_big;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelADD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Panel panelDel;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.ComboBox cbx_class;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox f_job;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox f_address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.Button btn_add2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_del_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox f_id;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.ComboBox cbx_select_class;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_update_std;
        private System.Windows.Forms.Button btn_get_std;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_std_id;
    }
}