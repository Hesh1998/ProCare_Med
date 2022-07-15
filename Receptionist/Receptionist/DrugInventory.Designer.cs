
namespace ProCare
{
    partial class DrugInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeadingDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeadingDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeadingDashboard
            // 
            this.pnlHeadingDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlHeadingDashboard.Controls.Add(this.label1);
            this.pnlHeadingDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingDashboard.Name = "pnlHeadingDashboard";
            this.pnlHeadingDashboard.Size = new System.Drawing.Size(1608, 73);
            this.pnlHeadingDashboard.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drug Inventory";
            // 
            // DrugInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeadingDashboard);
            this.Name = "DrugInventory";
            this.Size = new System.Drawing.Size(1608, 974);
            this.pnlHeadingDashboard.ResumeLayout(false);
            this.pnlHeadingDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeadingDashboard;
        private System.Windows.Forms.Label label1;
    }
}
