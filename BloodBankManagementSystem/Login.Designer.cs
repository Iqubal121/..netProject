
namespace BloodBankManagementSystem
{
    partial class Login
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
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.acceptBox = new System.Windows.Forms.CheckBox();
            this.show = new System.Windows.Forms.Label();
            this.login_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::BloodBankManagementSystem.Properties.Resources.logo;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(572, 12);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(296, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "You can become a superhero too. Just donate a bag of blood";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.acceptBox);
            this.panel1.Controls.Add(this.show);
            this.panel1.Controls.Add(this.login_Password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.login_Username);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 410);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.White;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBtn.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginBtn.Location = new System.Drawing.Point(255, 260);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(118, 56);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Sign In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // acceptBox
            // 
            this.acceptBox.AutoSize = true;
            this.acceptBox.Location = new System.Drawing.Point(39, 199);
            this.acceptBox.Name = "acceptBox";
            this.acceptBox.Size = new System.Drawing.Size(215, 21);
            this.acceptBox.TabIndex = 4;
            this.acceptBox.Text = "Accept Terms and Conditions";
            this.acceptBox.UseVisualStyleBackColor = true;
            this.acceptBox.CheckedChanged += new System.EventHandler(this.acceptBox_CheckedChanged);
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(318, 194);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(48, 23);
            this.show.TabIndex = 3;
            this.show.Text = "show";
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // login_Password
            // 
            this.login_Password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Password.Location = new System.Drawing.Point(39, 159);
            this.login_Password.Name = "login_Password";
            this.login_Password.PasswordChar = '*';
            this.login_Password.Size = new System.Drawing.Size(334, 32);
            this.login_Password.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name.";
            // 
            // login_Username
            // 
            this.login_Username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_Username.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Username.Location = new System.Drawing.Point(39, 67);
            this.login_Username.Name = "login_Username";
            this.login_Username.Size = new System.Drawing.Size(334, 32);
            this.login_Username.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(567, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(553, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 416);
            this.panel2.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(141, 384);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(164, 18);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "terms and conditions";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BloodBankManagementSystem.Properties.Resources.wall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 723);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox acceptBox;
        private System.Windows.Forms.Label show;
        private System.Windows.Forms.TextBox login_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_Username;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}