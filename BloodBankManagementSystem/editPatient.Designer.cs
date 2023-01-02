
namespace BloodBankManagementSystem
{
    partial class editPatient
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
            this.donorSubmit = new System.Windows.Forms.Button();
            this.donorClose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.patientAddress = new System.Windows.Forms.TextBox();
            this.patientBloodgroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.patientGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.patientDob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.patientMobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.patientFathername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patientName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.deleteDonor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchDonor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // donorSubmit
            // 
            this.donorSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.donorSubmit.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorSubmit.Location = new System.Drawing.Point(500, 509);
            this.donorSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.donorSubmit.Name = "donorSubmit";
            this.donorSubmit.Size = new System.Drawing.Size(79, 30);
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
            this.donorClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // patientAddress
            // 
            this.patientAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAddress.Location = new System.Drawing.Point(329, 447);
            this.patientAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientAddress.Multiline = true;
            this.patientAddress.Name = "patientAddress";
            this.patientAddress.Size = new System.Drawing.Size(252, 48);
            this.patientAddress.TabIndex = 18;
            // 
            // patientBloodgroup
            // 
            this.patientBloodgroup.FormattingEnabled = true;
            this.patientBloodgroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.patientBloodgroup.Location = new System.Drawing.Point(329, 392);
            this.patientBloodgroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientBloodgroup.Name = "patientBloodgroup";
            this.patientBloodgroup.Size = new System.Drawing.Size(252, 21);
            this.patientBloodgroup.TabIndex = 17;
            this.patientBloodgroup.Text = "Select";
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
            // patientGender
            // 
            this.patientGender.FormattingEnabled = true;
            this.patientGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.patientGender.Location = new System.Drawing.Point(329, 335);
            this.patientGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientGender.Name = "patientGender";
            this.patientGender.Size = new System.Drawing.Size(252, 21);
            this.patientGender.TabIndex = 15;
            this.patientGender.Text = "Select";
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
            // patientDob
            // 
            this.patientDob.CustomFormat = "dd-MM-yyyy";
            this.patientDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.patientDob.Location = new System.Drawing.Point(430, 280);
            this.patientDob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientDob.Name = "patientDob";
            this.patientDob.Size = new System.Drawing.Size(151, 20);
            this.patientDob.TabIndex = 13;
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
            // patientMobile
            // 
            this.patientMobile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientMobile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientMobile.Location = new System.Drawing.Point(329, 239);
            this.patientMobile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientMobile.Name = "patientMobile";
            this.patientMobile.Size = new System.Drawing.Size(252, 32);
            this.patientMobile.TabIndex = 10;
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
            // patientFathername
            // 
            this.patientFathername.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientFathername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFathername.Location = new System.Drawing.Point(329, 178);
            this.patientFathername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientFathername.Name = "patientFathername";
            this.patientFathername.Size = new System.Drawing.Size(252, 32);
            this.patientFathername.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edit Patient Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient Name";
            // 
            // patientName
            // 
            this.patientName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientName.Location = new System.Drawing.Point(329, 118);
            this.patientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(252, 32);
            this.patientName.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BackgroundImage = global::BloodBankManagementSystem.Properties.Resources.wall;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.deleteDonor);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.searchDonor);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.donorSubmit);
            this.panel6.Controls.Add(this.donorClose);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.patientAddress);
            this.panel6.Controls.Add(this.patientBloodgroup);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.patientGender);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.patientDob);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.patientMobile);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.patientFathername);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.patientName);
            this.panel6.Location = new System.Drawing.Point(9, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(809, 576);
            this.panel6.TabIndex = 7;
            // 
            // deleteDonor
            // 
            this.deleteDonor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteDonor.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDonor.ForeColor = System.Drawing.Color.White;
            this.deleteDonor.Location = new System.Drawing.Point(422, 509);
            this.deleteDonor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteDonor.Name = "deleteDonor";
            this.deleteDonor.Size = new System.Drawing.Size(64, 30);
            this.deleteDonor.TabIndex = 28;
            this.deleteDonor.Text = "Delete";
            this.deleteDonor.UseVisualStyleBackColor = false;
            this.deleteDonor.Click += new System.EventHandler(this.deleteDonor_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(554, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchDonor
            // 
            this.searchDonor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchDonor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDonor.Location = new System.Drawing.Point(422, 62);
            this.searchDonor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchDonor.Name = "searchDonor";
            this.searchDonor.Size = new System.Drawing.Size(128, 32);
            this.searchDonor.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Find Donor:";
            // 
            // editPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 596);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "editPatient";
            this.Text = "editPatient";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button donorSubmit;
        private System.Windows.Forms.Button donorClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox patientAddress;
        private System.Windows.Forms.ComboBox patientBloodgroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox patientGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker patientDob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox patientMobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientFathername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchDonor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteDonor;
    }
}