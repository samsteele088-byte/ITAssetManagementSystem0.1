namespace ITAssetManagementSystem0._1
{
    partial class Dashboard
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAssigned = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblRepair = new System.Windows.Forms.Label();
            this.lblRetired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(204, 60);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 16);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Devices";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblAssigned
            // 
            this.lblAssigned.AutoSize = true;
            this.lblAssigned.Location = new System.Drawing.Point(204, 98);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(64, 16);
            this.lblAssigned.TabIndex = 1;
            this.lblAssigned.Text = "Assigned";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(204, 141);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(64, 16);
            this.lblAvailable.TabIndex = 2;
            this.lblAvailable.Text = "Available";
            this.lblAvailable.Click += new System.EventHandler(this.lblAvailable_Click);
            // 
            // lblRepair
            // 
            this.lblRepair.AutoSize = true;
            this.lblRepair.Location = new System.Drawing.Point(204, 179);
            this.lblRepair.Name = "lblRepair";
            this.lblRepair.Size = new System.Drawing.Size(48, 16);
            this.lblRepair.TabIndex = 3;
            this.lblRepair.Text = "Repair";
            // 
            // lblRetired
            // 
            this.lblRetired.AutoSize = true;
            this.lblRetired.Location = new System.Drawing.Point(204, 219);
            this.lblRetired.Name = "lblRetired";
            this.lblRetired.Size = new System.Drawing.Size(51, 16);
            this.lblRetired.TabIndex = 4;
            this.lblRetired.Text = "Retired";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Devies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Assigned Devices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Available Devices";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Devices Being Repaired";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Devices Retired";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRetired);
            this.Controls.Add(this.lblRepair);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblAssigned);
            this.Controls.Add(this.lblTotal);
            this.Name = "Dashboard";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblRepair;
        private System.Windows.Forms.Label lblRetired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}