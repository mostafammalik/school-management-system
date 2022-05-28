namespace A7Aproject
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_small = new System.Windows.Forms.PictureBox();
            this.pic_big = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.panel_pay = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_std_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_show = new System.Windows.Forms.Panel();
            this.dgv_paid_std = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_pay.SuspendLayout();
            this.panel_show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paid_std)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1147, 57);
            this.panel1.TabIndex = 1;
            // 
            // pic_small
            // 
            this.pic_small.Image = ((System.Drawing.Image)(resources.GetObject("pic_small.Image")));
            this.pic_small.Location = new System.Drawing.Point(12, 11);
            this.pic_small.Name = "pic_small";
            this.pic_small.Size = new System.Drawing.Size(47, 38);
            this.pic_small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_small.TabIndex = 3;
            this.pic_small.TabStop = false;
            this.pic_small.MouseHover += new System.EventHandler(this.pic_small_MouseHover);
            // 
            // pic_big
            // 
            this.pic_big.Image = ((System.Drawing.Image)(resources.GetObject("pic_big.Image")));
            this.pic_big.Location = new System.Drawing.Point(8, 8);
            this.pic_big.Name = "pic_big";
            this.pic_big.Size = new System.Drawing.Size(54, 45);
            this.pic_big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_big.TabIndex = 4;
            this.pic_big.TabStop = false;
            this.pic_big.Visible = false;
            this.pic_big.Click += new System.EventHandler(this.pic_big_Click);
            this.pic_big.MouseLeave += new System.EventHandler(this.pic_big_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_pay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 526);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Not paid student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Paid student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(3, 60);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(167, 32);
            this.btn_pay.TabIndex = 0;
            this.btn_pay.Text = "Pay ";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // panel_pay
            // 
            this.panel_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_pay.Controls.Add(this.label2);
            this.panel_pay.Controls.Add(this.txt_money);
            this.panel_pay.Controls.Add(this.label1);
            this.panel_pay.Controls.Add(this.txt_std_name);
            this.panel_pay.Controls.Add(this.button1);
            this.panel_pay.Location = new System.Drawing.Point(224, 117);
            this.panel_pay.Name = "panel_pay";
            this.panel_pay.Size = new System.Drawing.Size(244, 192);
            this.panel_pay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Money";
            // 
            // txt_money
            // 
            this.txt_money.Location = new System.Drawing.Point(92, 78);
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(149, 27);
            this.txt_money.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // txt_std_name
            // 
            this.txt_std_name.Location = new System.Drawing.Point(92, 30);
            this.txt_std_name.Name = "txt_std_name";
            this.txt_std_name.Size = new System.Drawing.Size(149, 27);
            this.txt_std_name.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pay ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_show
            // 
            this.panel_show.Controls.Add(this.dgv_paid_std);
            this.panel_show.Location = new System.Drawing.Point(515, 117);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(379, 192);
            this.panel_show.TabIndex = 4;
            // 
            // dgv_paid_std
            // 
            this.dgv_paid_std.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paid_std.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_paid_std.Location = new System.Drawing.Point(0, 0);
            this.dgv_paid_std.Name = "dgv_paid_std";
            this.dgv_paid_std.Size = new System.Drawing.Size(379, 192);
            this.dgv_paid_std.TabIndex = 0;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 583);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.panel_pay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_pay.ResumeLayout(false);
            this.panel_pay.PerformLayout();
            this.panel_show.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paid_std)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_small;
        private System.Windows.Forms.PictureBox pic_big;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Panel panel_pay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_std_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.DataGridView dgv_paid_std;

    }
}