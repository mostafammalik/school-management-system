namespace A7Aproject
{
    partial class material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(material));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_mat = new System.Windows.Forms.Button();
            this.btn_show_mat = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_small = new System.Windows.Forms.PictureBox();
            this.pic_big = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_del_mat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mat = new System.Windows.Forms.TextBox();
            this.btn_add_mat = new System.Windows.Forms.Button();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.panel_show_mat = new System.Windows.Forms.Panel();
            this.show_in_dgv = new System.Windows.Forms.Button();
            this.cbx_select_class = new System.Windows.Forms.ComboBox();
            this.dgv_mat = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_show_mat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.btn_mat);
            this.panel2.Controls.Add(this.btn_show_mat);
            this.panel2.Controls.Add(this.btn_del);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 527);
            this.panel2.TabIndex = 3;
            // 
            // btn_mat
            // 
            this.btn_mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mat.Location = new System.Drawing.Point(12, 56);
            this.btn_mat.Name = "btn_mat";
            this.btn_mat.Size = new System.Drawing.Size(151, 36);
            this.btn_mat.TabIndex = 4;
            this.btn_mat.Text = "ADD material";
            this.btn_mat.UseVisualStyleBackColor = true;
            this.btn_mat.Click += new System.EventHandler(this.btn_mat_Click);
            // 
            // btn_show_mat
            // 
            this.btn_show_mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_mat.Location = new System.Drawing.Point(12, 183);
            this.btn_show_mat.Name = "btn_show_mat";
            this.btn_show_mat.Size = new System.Drawing.Size(151, 36);
            this.btn_show_mat.TabIndex = 3;
            this.btn_show_mat.Text = "show material";
            this.btn_show_mat.UseVisualStyleBackColor = true;
            this.btn_show_mat.Click += new System.EventHandler(this.btn_show_mat_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(12, 120);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(151, 36);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "Delete material";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(151)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.pic_small);
            this.panel1.Controls.Add(this.pic_big);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 68);
            this.panel1.TabIndex = 2;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.btn_del_mat);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_mat);
            this.panel3.Controls.Add(this.btn_add_mat);
            this.panel3.Controls.Add(this.cbx_class);
            this.panel3.Location = new System.Drawing.Point(221, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 359);
            this.panel3.TabIndex = 4;
            // 
            // btn_del_mat
            // 
            this.btn_del_mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_mat.Location = new System.Drawing.Point(173, 323);
            this.btn_del_mat.Name = "btn_del_mat";
            this.btn_del_mat.Size = new System.Drawing.Size(116, 36);
            this.btn_del_mat.TabIndex = 3;
            this.btn_del_mat.Text = "Delete Class";
            this.btn_del_mat.UseVisualStyleBackColor = true;
            this.btn_del_mat.Visible = false;
            this.btn_del_mat.Click += new System.EventHandler(this.btn_del_Click);
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
            // txt_mat
            // 
            this.txt_mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat.Location = new System.Drawing.Point(117, 113);
            this.txt_mat.Multiline = true;
            this.txt_mat.Name = "txt_mat";
            this.txt_mat.Size = new System.Drawing.Size(160, 35);
            this.txt_mat.TabIndex = 1;
            // 
            // btn_add_mat
            // 
            this.btn_add_mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_mat.Location = new System.Drawing.Point(0, 323);
            this.btn_add_mat.Name = "btn_add_mat";
            this.btn_add_mat.Size = new System.Drawing.Size(107, 36);
            this.btn_add_mat.TabIndex = 0;
            this.btn_add_mat.Text = "ADD class";
            this.btn_add_mat.UseVisualStyleBackColor = true;
            this.btn_add_mat.Visible = false;
            this.btn_add_mat.Click += new System.EventHandler(this.btn_add_mat_Click);
            // 
            // cbx_class
            // 
            this.cbx_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Location = new System.Drawing.Point(117, 63);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(160, 33);
            this.cbx_class.TabIndex = 0;
            this.cbx_class.Visible = false;
            // 
            // panel_show_mat
            // 
            this.panel_show_mat.BackColor = System.Drawing.Color.MistyRose;
            this.panel_show_mat.Controls.Add(this.show_in_dgv);
            this.panel_show_mat.Controls.Add(this.cbx_select_class);
            this.panel_show_mat.Controls.Add(this.dgv_mat);
            this.panel_show_mat.Location = new System.Drawing.Point(685, 84);
            this.panel_show_mat.Name = "panel_show_mat";
            this.panel_show_mat.Size = new System.Drawing.Size(353, 359);
            this.panel_show_mat.TabIndex = 5;
            this.panel_show_mat.Visible = false;
            // 
            // show_in_dgv
            // 
            this.show_in_dgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_in_dgv.Location = new System.Drawing.Point(169, 20);
            this.show_in_dgv.Name = "show_in_dgv";
            this.show_in_dgv.Size = new System.Drawing.Size(107, 36);
            this.show_in_dgv.TabIndex = 4;
            this.show_in_dgv.Text = "show";
            this.show_in_dgv.UseVisualStyleBackColor = true;
            this.show_in_dgv.Click += new System.EventHandler(this.show_in_dgv_Click);
            // 
            // cbx_select_class
            // 
            this.cbx_select_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_select_class.FormattingEnabled = true;
            this.cbx_select_class.Location = new System.Drawing.Point(3, 20);
            this.cbx_select_class.Name = "cbx_select_class";
            this.cbx_select_class.Size = new System.Drawing.Size(160, 33);
            this.cbx_select_class.TabIndex = 4;
            this.cbx_select_class.Visible = false;
            this.cbx_select_class.SelectedIndexChanged += new System.EventHandler(this.cbx_select_mat_SelectedIndexChanged);
            this.cbx_select_class.SelectedValueChanged += new System.EventHandler(this.cbx_select_mat_SelectedValueChanged);
            // 
            // dgv_mat
            // 
            this.dgv_mat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mat.Location = new System.Drawing.Point(0, 59);
            this.dgv_mat.Name = "dgv_mat";
            this.dgv_mat.Size = new System.Drawing.Size(352, 300);
            this.dgv_mat.TabIndex = 0;
            // 
            // material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 595);
            this.Controls.Add(this.panel_show_mat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "material";
            this.Text = "material";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.material_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_show_mat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_mat;
        private System.Windows.Forms.Button btn_show_mat;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_small;
        private System.Windows.Forms.PictureBox pic_big;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_del_mat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mat;
        private System.Windows.Forms.Button btn_add_mat;
        private System.Windows.Forms.ComboBox cbx_class;
        private System.Windows.Forms.Panel panel_show_mat;
        private System.Windows.Forms.ComboBox cbx_select_class;
        private System.Windows.Forms.DataGridView dgv_mat;
        private System.Windows.Forms.Button show_in_dgv;
    }
}