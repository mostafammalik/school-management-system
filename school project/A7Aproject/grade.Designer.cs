namespace projectSE
{
    partial class grade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grade));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_small = new System.Windows.Forms.PictureBox();
            this.pic_big = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_add = new System.Windows.Forms.Panel();
            this.btn_up = new System.Windows.Forms.Button();
            this.txt_std = new System.Windows.Forms.TextBox();
            this.txt_mat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_grade = new System.Windows.Forms.Panel();
            this.btn_show = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dgv_grade = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_add.SuspendLayout();
            this.panel_grade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(151)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.pic_small);
            this.panel1.Controls.Add(this.pic_big);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 52);
            this.panel1.TabIndex = 0;
            // 
            // pic_small
            // 
            this.pic_small.Image = ((System.Drawing.Image)(resources.GetObject("pic_small.Image")));
            this.pic_small.Location = new System.Drawing.Point(33, 4);
            this.pic_small.Name = "pic_small";
            this.pic_small.Size = new System.Drawing.Size(47, 38);
            this.pic_small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_small.TabIndex = 5;
            this.pic_small.TabStop = false;
            this.pic_small.MouseHover += new System.EventHandler(this.pic_small_MouseHover);
            // 
            // pic_big
            // 
            this.pic_big.Image = ((System.Drawing.Image)(resources.GetObject("pic_big.Image")));
            this.pic_big.Location = new System.Drawing.Point(29, 3);
            this.pic_big.Name = "pic_big";
            this.pic_big.Size = new System.Drawing.Size(54, 45);
            this.pic_big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_big.TabIndex = 6;
            this.pic_big.TabStop = false;
            this.pic_big.Visible = false;
            this.pic_big.Click += new System.EventHandler(this.pic_big_Click);
            this.pic_big.MouseLeave += new System.EventHandler(this.pic_big_MouseLeave);
            this.pic_big.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_big_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 697);
            this.panel3.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(17, 280);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Show ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 204);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_add
            // 
            this.panel_add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_add.Controls.Add(this.btn_up);
            this.panel_add.Controls.Add(this.txt_std);
            this.panel_add.Controls.Add(this.txt_mat);
            this.panel_add.Controls.Add(this.label4);
            this.panel_add.Controls.Add(this.button5);
            this.panel_add.Controls.Add(this.txt_grade);
            this.panel_add.Controls.Add(this.label3);
            this.panel_add.Controls.Add(this.label2);
            this.panel_add.Controls.Add(this.label1);
            this.panel_add.Controls.Add(this.cbx_class);
            this.panel_add.Location = new System.Drawing.Point(286, 107);
            this.panel_add.Margin = new System.Windows.Forms.Padding(4);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(408, 471);
            this.panel_add.TabIndex = 2;
            // 
            // btn_up
            // 
            this.btn_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_up.Location = new System.Drawing.Point(150, 373);
            this.btn_up.Margin = new System.Windows.Forms.Padding(4);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(242, 44);
            this.btn_up.TabIndex = 13;
            this.btn_up.Text = "update";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // txt_std
            // 
            this.txt_std.Location = new System.Drawing.Point(150, 167);
            this.txt_std.Margin = new System.Windows.Forms.Padding(4);
            this.txt_std.Name = "txt_std";
            this.txt_std.Size = new System.Drawing.Size(242, 29);
            this.txt_std.TabIndex = 12;
            // 
            // txt_mat
            // 
            this.txt_mat.Location = new System.Drawing.Point(150, 105);
            this.txt_mat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mat.Name = "txt_mat";
            this.txt_mat.Size = new System.Drawing.Size(242, 29);
            this.txt_mat.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Student name ";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(150, 308);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_grade
            // 
            this.txt_grade.Location = new System.Drawing.Point(150, 225);
            this.txt_grade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(242, 29);
            this.txt_grade.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "grade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Material ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class";
            // 
            // cbx_class
            // 
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Location = new System.Drawing.Point(150, 48);
            this.cbx_class.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(242, 32);
            this.cbx_class.TabIndex = 3;
            this.cbx_class.SelectedIndexChanged += new System.EventHandler(this.cbx_class_SelectedIndexChanged);
            // 
            // panel_grade
            // 
            this.panel_grade.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_grade.Controls.Add(this.btn_show);
            this.panel_grade.Controls.Add(this.label5);
            this.panel_grade.Controls.Add(this.txt_name);
            this.panel_grade.Controls.Add(this.dgv_grade);
            this.panel_grade.Location = new System.Drawing.Point(725, 107);
            this.panel_grade.Margin = new System.Windows.Forms.Padding(4);
            this.panel_grade.Name = "panel_grade";
            this.panel_grade.Size = new System.Drawing.Size(390, 471);
            this.panel_grade.TabIndex = 3;
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(16, 353);
            this.btn_show.Margin = new System.Windows.Forms.Padding(4);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(124, 32);
            this.btn_show.TabIndex = 13;
            this.btn_show.Text = "SHow ";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enter name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(130, 42);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(242, 29);
            this.txt_name.TabIndex = 13;
            // 
            // dgv_grade
            // 
            this.dgv_grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grade.Location = new System.Drawing.Point(16, 92);
            this.dgv_grade.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_grade.Name = "dgv_grade";
            this.dgv_grade.RowTemplate.Height = 24;
            this.dgv_grade.Size = new System.Drawing.Size(356, 241);
            this.dgv_grade.TabIndex = 0;
            // 
            // grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel_grade);
            this.Controls.Add(this.panel_add);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "grade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.grade_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            this.panel_grade.ResumeLayout(false);
            this.panel_grade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_class;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_grade;
        private System.Windows.Forms.DataGridView dgv_grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_std;
        private System.Windows.Forms.TextBox txt_mat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.PictureBox pic_small;
        private System.Windows.Forms.PictureBox pic_big;
        private System.Windows.Forms.Button btn_up;
    }
}

