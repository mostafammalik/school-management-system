namespace A7Aproject
{
    partial class classes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(classes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_small = new System.Windows.Forms.PictureBox();
            this.pic_big = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_showclass = new System.Windows.Forms.Button();
            this.btn_del_class = new System.Windows.Forms.Button();
            this.btn_addclass = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cls_id = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cls_name = new System.Windows.Forms.TextBox();
            this.cbx_teacher = new System.Windows.Forms.ComboBox();
            this.dgv_class = new System.Windows.Forms.DataGridView();
            this.panel_show_class = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).BeginInit();
            this.panel_show_class.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1203, 68);
            this.panel1.TabIndex = 0;
            // 
            // pic_small
            // 
            this.pic_small.Image = ((System.Drawing.Image)(resources.GetObject("pic_small.Image")));
            this.pic_small.Location = new System.Drawing.Point(34, 12);
            this.pic_small.Name = "pic_small";
            this.pic_small.Size = new System.Drawing.Size(47, 38);
            this.pic_small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_small.TabIndex = 7;
            this.pic_small.TabStop = false;
            this.pic_small.MouseHover += new System.EventHandler(this.pic_small_MouseHover);
            // 
            // pic_big
            // 
            this.pic_big.Image = ((System.Drawing.Image)(resources.GetObject("pic_big.Image")));
            this.pic_big.Location = new System.Drawing.Point(30, 8);
            this.pic_big.Name = "pic_big";
            this.pic_big.Size = new System.Drawing.Size(54, 45);
            this.pic_big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_big.TabIndex = 8;
            this.pic_big.TabStop = false;
            this.pic_big.Visible = false;
            this.pic_big.Click += new System.EventHandler(this.pic_big_Click);
            this.pic_big.MouseLeave += new System.EventHandler(this.pic_big_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_showclass);
            this.panel2.Controls.Add(this.btn_del_class);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 497);
            this.panel2.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(12, 56);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(151, 36);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "ADD class";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_showclass
            // 
            this.btn_showclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showclass.Location = new System.Drawing.Point(12, 190);
            this.btn_showclass.Name = "btn_showclass";
            this.btn_showclass.Size = new System.Drawing.Size(151, 36);
            this.btn_showclass.TabIndex = 3;
            this.btn_showclass.Text = "show classes";
            this.btn_showclass.UseVisualStyleBackColor = true;
            this.btn_showclass.Click += new System.EventHandler(this.btn_showclass_Click);
            // 
            // btn_del_class
            // 
            this.btn_del_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_class.Location = new System.Drawing.Point(12, 120);
            this.btn_del_class.Name = "btn_del_class";
            this.btn_del_class.Size = new System.Drawing.Size(151, 36);
            this.btn_del_class.TabIndex = 1;
            this.btn_del_class.Text = "Delete Class";
            this.btn_del_class.UseVisualStyleBackColor = true;
            this.btn_del_class.Click += new System.EventHandler(this.btn_del_class_Click);
            // 
            // btn_addclass
            // 
            this.btn_addclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addclass.Location = new System.Drawing.Point(0, 323);
            this.btn_addclass.Name = "btn_addclass";
            this.btn_addclass.Size = new System.Drawing.Size(107, 36);
            this.btn_addclass.TabIndex = 0;
            this.btn_addclass.Text = "ADD class";
            this.btn_addclass.UseVisualStyleBackColor = true;
            this.btn_addclass.Visible = false;
            this.btn_addclass.Click += new System.EventHandler(this.btn_addclass_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_cls_id);
            this.panel3.Controls.Add(this.btn_del);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_cls_name);
            this.panel3.Controls.Add(this.btn_addclass);
            this.panel3.Controls.Add(this.cbx_teacher);
            this.panel3.Location = new System.Drawing.Point(211, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 359);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter ID";
            // 
            // txt_cls_id
            // 
            this.txt_cls_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cls_id.Location = new System.Drawing.Point(117, 159);
            this.txt_cls_id.Multiline = true;
            this.txt_cls_id.Name = "txt_cls_id";
            this.txt_cls_id.Size = new System.Drawing.Size(160, 35);
            this.txt_cls_id.TabIndex = 4;
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(173, 323);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(116, 36);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Delete Class";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Visible = false;
            this.btn_del.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name";
            // 
            // txt_cls_name
            // 
            this.txt_cls_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cls_name.Location = new System.Drawing.Point(117, 113);
            this.txt_cls_name.Multiline = true;
            this.txt_cls_name.Name = "txt_cls_name";
            this.txt_cls_name.Size = new System.Drawing.Size(160, 35);
            this.txt_cls_name.TabIndex = 1;
            // 
            // cbx_teacher
            // 
            this.cbx_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_teacher.FormattingEnabled = true;
            this.cbx_teacher.Location = new System.Drawing.Point(117, 63);
            this.cbx_teacher.Name = "cbx_teacher";
            this.cbx_teacher.Size = new System.Drawing.Size(160, 33);
            this.cbx_teacher.TabIndex = 0;
            this.cbx_teacher.Visible = false;
            // 
            // dgv_class
            // 
            this.dgv_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_class.Location = new System.Drawing.Point(0, 0);
            this.dgv_class.Name = "dgv_class";
            this.dgv_class.Size = new System.Drawing.Size(338, 359);
            this.dgv_class.TabIndex = 3;
            // 
            // panel_show_class
            // 
            this.panel_show_class.Controls.Add(this.dgv_class);
            this.panel_show_class.Location = new System.Drawing.Point(524, 102);
            this.panel_show_class.Name = "panel_show_class";
            this.panel_show_class.Size = new System.Drawing.Size(338, 359);
            this.panel_show_class.TabIndex = 4;
            this.panel_show_class.Visible = false;
            // 
            // classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 565);
            this.Controls.Add(this.panel_show_class);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "classes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "class";
            this.Load += new System.EventHandler(this.class_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).EndInit();
            this.panel_show_class.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_small;
        private System.Windows.Forms.PictureBox pic_big;
        private System.Windows.Forms.Button btn_showclass;
        private System.Windows.Forms.Button btn_del_class;
        private System.Windows.Forms.Button btn_addclass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_cls_name;
        private System.Windows.Forms.ComboBox cbx_teacher;
        private System.Windows.Forms.DataGridView dgv_class;
        private System.Windows.Forms.Panel panel_show_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cls_id;
    }
}