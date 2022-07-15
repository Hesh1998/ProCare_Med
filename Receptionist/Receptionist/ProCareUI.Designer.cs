
namespace Receptionist
{
    partial class frmProCare
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProCare));
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlDateAndTime = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSelectStaffMgt = new System.Windows.Forms.Panel();
            this.pnlSelectDrugInventory = new System.Windows.Forms.Panel();
            this.pnlSelectMedication = new System.Windows.Forms.Panel();
            this.pnlSelectUpdPatient = new System.Windows.Forms.Panel();
            this.pnlSelectDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStaffMgt = new System.Windows.Forms.Button();
            this.btnDrugInventory = new System.Windows.Forms.Button();
            this.pnlSelectRegPatient = new System.Windows.Forms.Panel();
            this.btnMedication = new System.Windows.Forms.Button();
            this.btnUpdPatient = new System.Windows.Forms.Button();
            this.btnRegPatient = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.lblProfName = new System.Windows.Forms.Label();
            this.tmrDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.pnlDashboardInfo = new Receptionist.Dashboard();
            this.pnlUpdPatient = new ProCare.UpdatePatient();
            this.pnlMed = new ProCare.Medication();
            this.pnlDrugInventory = new ProCare.DrugInventory();
            this.pnlStfMgt = new ProCare.StaffManagement();
            this.pnlRegPatientImplement = new Receptionist.RegisterPatient();
            this.pnlDashboard.SuspendLayout();
            this.pnlDateAndTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlDashboard.Controls.Add(this.pnlDateAndTime);
            this.pnlDashboard.Controls.Add(this.pictureBox1);
            this.pnlDashboard.Controls.Add(this.pnlSelectStaffMgt);
            this.pnlDashboard.Controls.Add(this.pnlSelectDrugInventory);
            this.pnlDashboard.Controls.Add(this.pnlSelectMedication);
            this.pnlDashboard.Controls.Add(this.pnlSelectUpdPatient);
            this.pnlDashboard.Controls.Add(this.pnlSelectDashboard);
            this.pnlDashboard.Controls.Add(this.label1);
            this.pnlDashboard.Controls.Add(this.btnStaffMgt);
            this.pnlDashboard.Controls.Add(this.btnDrugInventory);
            this.pnlDashboard.Controls.Add(this.pnlSelectRegPatient);
            this.pnlDashboard.Controls.Add(this.btnMedication);
            this.pnlDashboard.Controls.Add(this.btnUpdPatient);
            this.pnlDashboard.Controls.Add(this.btnRegPatient);
            this.pnlDashboard.Controls.Add(this.btnDashboard);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(294, 1055);
            this.pnlDashboard.TabIndex = 0;
            this.pnlDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDashboard_Paint);
            // 
            // pnlDateAndTime
            // 
            this.pnlDateAndTime.Controls.Add(this.lblDate);
            this.pnlDateAndTime.Controls.Add(this.lblTime);
            this.pnlDateAndTime.Location = new System.Drawing.Point(22, 864);
            this.pnlDateAndTime.Name = "pnlDateAndTime";
            this.pnlDateAndTime.Size = new System.Drawing.Size(250, 101);
            this.pnlDateAndTime.TabIndex = 15;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(33, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(182, 31);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "00 : 00 : 0000";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(75, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 31);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00 : 00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSelectStaffMgt
            // 
            this.pnlSelectStaffMgt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlSelectStaffMgt.Location = new System.Drawing.Point(0, 716);
            this.pnlSelectStaffMgt.Name = "pnlSelectStaffMgt";
            this.pnlSelectStaffMgt.Size = new System.Drawing.Size(10, 71);
            this.pnlSelectStaffMgt.TabIndex = 7;
            // 
            // pnlSelectDrugInventory
            // 
            this.pnlSelectDrugInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlSelectDrugInventory.Location = new System.Drawing.Point(0, 605);
            this.pnlSelectDrugInventory.Name = "pnlSelectDrugInventory";
            this.pnlSelectDrugInventory.Size = new System.Drawing.Size(10, 71);
            this.pnlSelectDrugInventory.TabIndex = 6;
            // 
            // pnlSelectMedication
            // 
            this.pnlSelectMedication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlSelectMedication.Location = new System.Drawing.Point(0, 498);
            this.pnlSelectMedication.Name = "pnlSelectMedication";
            this.pnlSelectMedication.Size = new System.Drawing.Size(10, 71);
            this.pnlSelectMedication.TabIndex = 6;
            // 
            // pnlSelectUpdPatient
            // 
            this.pnlSelectUpdPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlSelectUpdPatient.Location = new System.Drawing.Point(0, 389);
            this.pnlSelectUpdPatient.Name = "pnlSelectUpdPatient";
            this.pnlSelectUpdPatient.Size = new System.Drawing.Size(10, 71);
            this.pnlSelectUpdPatient.TabIndex = 5;
            // 
            // pnlSelectDashboard
            // 
            this.pnlSelectDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlSelectDashboard.Location = new System.Drawing.Point(0, 169);
            this.pnlSelectDashboard.Name = "pnlSelectDashboard";
            this.pnlSelectDashboard.Size = new System.Drawing.Size(10, 71);
            this.pnlSelectDashboard.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 1059);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "© 2021 Royaque. All Rights Reserved.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStaffMgt
            // 
            this.btnStaffMgt.FlatAppearance.BorderSize = 0;
            this.btnStaffMgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffMgt.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStaffMgt.ForeColor = System.Drawing.Color.White;
            this.btnStaffMgt.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffMgt.Image")));
            this.btnStaffMgt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffMgt.Location = new System.Drawing.Point(12, 716);
            this.btnStaffMgt.Name = "btnStaffMgt";
            this.btnStaffMgt.Size = new System.Drawing.Size(278, 71);
            this.btnStaffMgt.TabIndex = 6;
            this.btnStaffMgt.Text = "   &Staff Management";
            this.btnStaffMgt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffMgt.UseVisualStyleBackColor = true;
            this.btnStaffMgt.Click += new System.EventHandler(this.btnStaffMgt_Click);
            // 
            // btnDrugInventory
            // 
            this.btnDrugInventory.FlatAppearance.BorderSize = 0;
            this.btnDrugInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrugInventory.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDrugInventory.ForeColor = System.Drawing.Color.White;
            this.btnDrugInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnDrugInventory.Image")));
            this.btnDrugInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrugInventory.Location = new System.Drawing.Point(12, 605);
            this.btnDrugInventory.Name = "btnDrugInventory";
            this.btnDrugInventory.Size = new System.Drawing.Size(278, 71);
            this.btnDrugInventory.TabIndex = 5;
            this.btnDrugInventory.Text = "   Drug &Inventory";
            this.btnDrugInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrugInventory.UseVisualStyleBackColor = true;
            this.btnDrugInventory.Click += new System.EventHandler(this.btnDrugInventory_Click);
            // 
            // pnlSelectRegPatient
            // 
            this.pnlSelectRegPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlSelectRegPatient.Location = new System.Drawing.Point(0, 276);
            this.pnlSelectRegPatient.Name = "pnlSelectRegPatient";
            this.pnlSelectRegPatient.Size = new System.Drawing.Size(10, 71);
            this.pnlSelectRegPatient.TabIndex = 4;
            this.pnlSelectRegPatient.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSelectDashboard_Paint);
            // 
            // btnMedication
            // 
            this.btnMedication.FlatAppearance.BorderSize = 0;
            this.btnMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedication.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedication.ForeColor = System.Drawing.Color.White;
            this.btnMedication.Image = ((System.Drawing.Image)(resources.GetObject("btnMedication.Image")));
            this.btnMedication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedication.Location = new System.Drawing.Point(12, 498);
            this.btnMedication.Name = "btnMedication";
            this.btnMedication.Size = new System.Drawing.Size(278, 71);
            this.btnMedication.TabIndex = 4;
            this.btnMedication.Text = "   &Medication";
            this.btnMedication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedication.UseVisualStyleBackColor = true;
            this.btnMedication.Click += new System.EventHandler(this.btnConsultant_Click);
            // 
            // btnUpdPatient
            // 
            this.btnUpdPatient.FlatAppearance.BorderSize = 0;
            this.btnUpdPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdPatient.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdPatient.ForeColor = System.Drawing.Color.White;
            this.btnUpdPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdPatient.Image")));
            this.btnUpdPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdPatient.Location = new System.Drawing.Point(12, 389);
            this.btnUpdPatient.Name = "btnUpdPatient";
            this.btnUpdPatient.Size = new System.Drawing.Size(287, 71);
            this.btnUpdPatient.TabIndex = 3;
            this.btnUpdPatient.Text = "   &Update Patient";
            this.btnUpdPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdPatient.UseVisualStyleBackColor = true;
            this.btnUpdPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegPatient
            // 
            this.btnRegPatient.FlatAppearance.BorderSize = 0;
            this.btnRegPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegPatient.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegPatient.ForeColor = System.Drawing.Color.White;
            this.btnRegPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnRegPatient.Image")));
            this.btnRegPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegPatient.Location = new System.Drawing.Point(12, 276);
            this.btnRegPatient.Name = "btnRegPatient";
            this.btnRegPatient.Size = new System.Drawing.Size(282, 71);
            this.btnRegPatient.TabIndex = 2;
            this.btnRegPatient.Text = "   &Register Patient";
            this.btnRegPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegPatient.UseVisualStyleBackColor = true;
            this.btnRegPatient.Click += new System.EventHandler(this.btnRegPatient_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(12, 169);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(282, 71);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   &Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlTop.Controls.Add(this.btnAccountSettings);
            this.pnlTop.Controls.Add(this.lblProfName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(294, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1608, 103);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAccountSettings.FlatAppearance.BorderSize = 0;
            this.btnAccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountSettings.Image")));
            this.btnAccountSettings.Location = new System.Drawing.Point(1550, 33);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(51, 39);
            this.btnAccountSettings.TabIndex = 0;
            this.btnAccountSettings.TabStop = false;
            this.btnAccountSettings.UseVisualStyleBackColor = false;
            this.btnAccountSettings.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblProfName
            // 
            this.lblProfName.AutoSize = true;
            this.lblProfName.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProfName.Location = new System.Drawing.Point(1290, 36);
            this.lblProfName.Name = "lblProfName";
            this.lblProfName.Size = new System.Drawing.Size(0, 36);
            this.lblProfName.TabIndex = 0;
            // 
            // tmrDateAndTime
            // 
            this.tmrDateAndTime.Interval = 1000;
            this.tmrDateAndTime.Tick += new System.EventHandler(this.Timer_action);
            // 
            // pnlDashboardInfo
            // 
            this.pnlDashboardInfo.BackColor = System.Drawing.Color.White;
            this.pnlDashboardInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboardInfo.Location = new System.Drawing.Point(294, 103);
            this.pnlDashboardInfo.Name = "pnlDashboardInfo";
            this.pnlDashboardInfo.Size = new System.Drawing.Size(1608, 952);
            this.pnlDashboardInfo.TabIndex = 2;
            // 
            // pnlUpdPatient
            // 
            this.pnlUpdPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdPatient.Location = new System.Drawing.Point(294, 103);
            this.pnlUpdPatient.Name = "pnlUpdPatient";
            this.pnlUpdPatient.Size = new System.Drawing.Size(1608, 952);
            this.pnlUpdPatient.TabIndex = 4;
            // 
            // pnlMed
            // 
            this.pnlMed.BackColor = System.Drawing.Color.White;
            this.pnlMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMed.Location = new System.Drawing.Point(294, 103);
            this.pnlMed.Name = "pnlMed";
            this.pnlMed.Size = new System.Drawing.Size(1608, 952);
            this.pnlMed.TabIndex = 5;
            // 
            // pnlDrugInventory
            // 
            this.pnlDrugInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrugInventory.Location = new System.Drawing.Point(294, 103);
            this.pnlDrugInventory.Name = "pnlDrugInventory";
            this.pnlDrugInventory.Size = new System.Drawing.Size(1608, 952);
            this.pnlDrugInventory.TabIndex = 6;
            // 
            // pnlStfMgt
            // 
            this.pnlStfMgt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStfMgt.Location = new System.Drawing.Point(294, 103);
            this.pnlStfMgt.Name = "pnlStfMgt";
            this.pnlStfMgt.Size = new System.Drawing.Size(1608, 952);
            this.pnlStfMgt.TabIndex = 7;
            this.pnlStfMgt.Load += new System.EventHandler(this.pnlStfMgt_Load);
            // 
            // pnlRegPatientImplement
            // 
            this.pnlRegPatientImplement.BackColor = System.Drawing.Color.White;
            this.pnlRegPatientImplement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegPatientImplement.Location = new System.Drawing.Point(294, 103);
            this.pnlRegPatientImplement.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlRegPatientImplement.Name = "pnlRegPatientImplement";
            this.pnlRegPatientImplement.Size = new System.Drawing.Size(1608, 952);
            this.pnlRegPatientImplement.TabIndex = 8;
            // 
            // frmProCare
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1055);
            this.Controls.Add(this.pnlRegPatientImplement);
            this.Controls.Add(this.pnlStfMgt);
            this.Controls.Add(this.pnlDrugInventory);
            this.Controls.Add(this.pnlMed);
            this.Controls.Add(this.pnlUpdPatient);
            this.Controls.Add(this.pnlDashboardInfo);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlDashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProCare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProCare Medical Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlDateAndTime.ResumeLayout(false);
            this.pnlDateAndTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnUpdPatient;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnRegPatient;
        private System.Windows.Forms.Button btnMedication;
        private System.Windows.Forms.Panel pnlSelectMedication;
        private System.Windows.Forms.Button btnDrugInventory;
        private System.Windows.Forms.Button btnAccountSettings;
        private System.Windows.Forms.Button btnStaffMgt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProfName;
        private System.Windows.Forms.Panel pnlSelectDashboard;
        private System.Windows.Forms.Panel pnlSelectRegPatient;
        private System.Windows.Forms.Panel pnlSelectUpdPatient;
        private System.Windows.Forms.Panel pnlSelectDrugInventory;
        private System.Windows.Forms.Panel pnlSelectStaffMgt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlDateAndTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrDateAndTime;
        private Dashboard pnlDashboardInfo;
        private RegisterPatient pnlRegPatientImplement;
        private ProCare.UpdatePatient pnlUpdPatient;
        private ProCare.Medication pnlMed;
        private ProCare.DrugInventory pnlDrugInventory;
        private ProCare.StaffManagement pnlStfMgt;
        private RegisterPatient registerPatient1;
    }
}

