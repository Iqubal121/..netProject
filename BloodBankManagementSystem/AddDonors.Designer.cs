
namespace BloodBankManagementSystem
{
    partial class AddDonors
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.donorSubmit = new System.Windows.Forms.Button();
            this.donorClose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.donorAddress = new System.Windows.Forms.TextBox();
            this.donorBloodgroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.donorGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.donorDob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.donorMobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.donorFathrName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.donorName = new System.Windows.Forms.TextBox();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::BloodBankManagementSystem.Properties.Resources.wall;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.donorSubmit);
            this.panel6.Controls.Add(this.donorClose);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.donorAddress);
            this.panel6.Controls.Add(this.donorBloodgroup);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.donorGender);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.donorDob);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.donorMobile);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.donorFathrName);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.donorName);
            this.panel6.Location = new System.Drawing.Point(9, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(809, 576);
            this.panel6.TabIndex = 5;
            // 
            // donorSubmit
            // 
            this.donorSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.donorSubmit.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorSubmit.Location = new System.Drawing.Point(504, 509);
            this.donorSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.donorSubmit.Name = "donorSubmit";
            this.donorSubmit.Size = new System.Drawing.Size(75, 30);
            this.donorSubmit.TabIndex = 21;
            this.donorSubmit.Text = "Submit";
            this.donorSubmit.UseVisualStyleBackColor = false;
            this.donorSubmit.Click += new System.EventHandler(this.donorSubmit_Click);
            // 
            // donorClose
            // 
            this.donorClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.donorClose.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorClose.Location = new System.Drawing.Point(329, 509);
            this.donorClose.Margin = new System.Windows.Forms.Padding(2);
            this.donorClose.Name = "donorClose";
            this.donorClose.Size = new System.Drawing.Size(64, 30);
            this.donorClose.TabIndex = 20;
            this.donorClose.Text = "Close";
            this.donorClose.UseVisualStyleBackColor = false;
            this.donorClose.Click += new System.EventHandler(this.donorClose_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 425);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Address.";
            // 
            // donorAddress
            // 
            this.donorAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.donorAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorAddress.Location = new System.Drawing.Point(329, 447);
            this.donorAddress.Margin = new System.Windows.Forms.Padding(2);
            this.donorAddress.Multiline = true;
            this.donorAddress.Name = "donorAddress";
            this.donorAddress.Size = new System.Drawing.Size(252, 48);
            this.donorAddress.TabIndex = 18;
            // 
            // donorBloodgroup
            // 
            this.donorBloodgroup.FormattingEnabled = true;
            this.donorBloodgroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.donorBloodgroup.Location = new System.Drawing.Point(329, 392);
            this.donorBloodgroup.Margin = new System.Windows.Forms.Padding(2);
            this.donorBloodgroup.Name = "donorBloodgroup";
            this.donorBloodgroup.Size = new System.Drawing.Size(252, 21);
            this.donorBloodgroup.TabIndex = 17;
            this.donorBloodgroup.Text = "Select";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 370);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Blood Group.";
            // 
            // donorGender
            // 
            this.donorGender.FormattingEnabled = true;
            this.donorGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.donorGender.Location = new System.Drawing.Point(329, 335);
            this.donorGender.Margin = new System.Windows.Forms.Padding(2);
            this.donorGender.Name = "donorGender";
            this.donorGender.Size = new System.Drawing.Size(252, 21);
            this.donorGender.TabIndex = 15;
            this.donorGender.Text = "Select";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 313);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gender.";
            // 
            // donorDob
            // 
            this.donorDob.CustomFormat = "dd-MM-yyyy";
            this.donorDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.donorDob.Location = new System.Drawing.Point(430, 280);
            this.donorDob.Margin = new System.Windows.Forms.Padding(2);
            this.donorDob.Name = "donorDob";
            this.donorDob.Size = new System.Drawing.Size(151, 20);
            this.donorDob.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "DOB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mobile Number.";
            // 
            // donorMobile
            // 
            this.donorMobile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.donorMobile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorMobile.Location = new System.Drawing.Point(329, 239);
            this.donorMobile.Margin = new System.Windows.Forms.Padding(2);
            this.donorMobile.Name = "donorMobile";
            this.donorMobile.Size = new System.Drawing.Size(252, 32);
            this.donorMobile.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parents Name";
            // 
            // donorFathrName
            // 
            this.donorFathrName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.donorFathrName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorFathrName.Location = new System.Drawing.Point(329, 178);
            this.donorFathrName.Margin = new System.Windows.Forms.Padding(2);
            this.donorFathrName.Name = "donorFathrName";
            this.donorFathrName.Size = new System.Drawing.Size(252, 32);
            this.donorFathrName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the Details of the Donor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Donor Name";
            // 
            // donorName
            // 
            this.donorName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.donorName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorName.Location = new System.Drawing.Point(329, 118);
            this.donorName.Margin = new System.Windows.Forms.Padding(2);
            this.donorName.Name = "donorName";
            this.donorName.Size = new System.Drawing.Size(252, 32);
            this.donorName.TabIndex = 2;
            // 
            // AddDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 596);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDonors";
            this.Text = "AddDonors";
            this.Load += new System.EventHandler(this.AddDonors_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox donorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox donorFathrName;
        private System.Windows.Forms.Button donorSubmit;
        private System.Windows.Forms.Button donorClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox donorAddress;
        private System.Windows.Forms.ComboBox donorBloodgroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox donorGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker donorDob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox donorMobile;
    }
}