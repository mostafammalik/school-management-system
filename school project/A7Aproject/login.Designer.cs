namespace A7Aproject
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.llk1 = new System.Windows.Forms.LinkLabel();
            this.ll_forget = new System.Windows.Forms.LinkLabel();
            this.pic_show = new System.Windows.Forms.PictureBox();
            this.pic_unshow = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_unshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pic_unshow);
            this.panel1.Controls.Add(this.pic_show);
            this.panel1.Controls.Add(this.ll_forget);
            this.panel1.Controls.Add(this.llk1);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 531);
            this.panel1.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(52, 159);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(243, 31);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(52, 240);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(243, 31);
            this.txt_password.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(52, 385);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(243, 36);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // llk1
            // 
            this.llk1.AutoSize = true;
            this.llk1.Location = new System.Drawing.Point(475, 487);
            this.llk1.Name = "llk1";
            this.llk1.Size = new System.Drawing.Size(83, 25);
            this.llk1.TabIndex = 3;
            this.llk1.TabStop = true;
            this.llk1.Text = "Register";
            // 
            // ll_forget
            // 
            this.ll_forget.AutoSize = true;
            this.ll_forget.Location = new System.Drawing.Point(302, 487);
            this.ll_forget.Name = "ll_forget";
            this.ll_forget.Size = new System.Drawing.Size(150, 25);
            this.ll_forget.TabIndex = 4;
            this.ll_forget.TabStop = true;
            this.ll_forget.Text = "forget password";
            // 
            // pic_show
            // 
            this.pic_show.Image = ((System.Drawing.Image)(resources.GetObject("pic_show.Image")));
            this.pic_show.Location = new System.Drawing.Point(307, 241);
            this.pic_show.Name = "pic_show";
            this.pic_show.Size = new System.Drawing.Size(40, 30);
            this.pic_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_show.TabIndex = 5;
            this.pic_show.TabStop = false;
            this.pic_show.Click += new System.EventHandler(this.pic_show_Click);
            // 
            // pic_unshow
            // 
            this.pic_unshow.Image = ((System.Drawing.Image)(resources.GetObject("pic_unshow.Image")));
            this.pic_unshow.Location = new System.Drawing.Point(307, 240);
            this.pic_unshow.Name = "pic_unshow";
            this.pic_unshow.Size = new System.Drawing.Size(40, 30);
            this.pic_unshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_unshow.TabIndex = 6;
            this.pic_unshow.TabStop = false;
            this.pic_unshow.Visible = false;
            this.pic_unshow.Click += new System.EventHandler(this.pic_unshow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(151)))), ((int)(((byte)(141)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 54);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 531);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "login";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_unshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel ll_forget;
        private System.Windows.Forms.LinkLabel llk1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.PictureBox pic_unshow;
        private System.Windows.Forms.PictureBox pic_show;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}