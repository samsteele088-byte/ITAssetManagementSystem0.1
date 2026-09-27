namespace ITAssetManagementSystem0._1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAssetTag = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtAssignedTo = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.cboDeviceType = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtModelYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset Tag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Device Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Assigned To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Serial Number";
            // 
            // txtAssetTag
            // 
            this.txtAssetTag.Location = new System.Drawing.Point(132, 22);
            this.txtAssetTag.Name = "txtAssetTag";
            this.txtAssetTag.Size = new System.Drawing.Size(121, 22);
            this.txtAssetTag.TabIndex = 6;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(132, 61);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(121, 22);
            this.txtDeviceName.TabIndex = 7;
            // 
            // txtAssignedTo
            // 
            this.txtAssignedTo.Location = new System.Drawing.Point(384, 58);
            this.txtAssignedTo.Name = "txtAssignedTo";
            this.txtAssignedTo.Size = new System.Drawing.Size(116, 22);
            this.txtAssignedTo.TabIndex = 8;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(384, 97);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(116, 22);
            this.txtSerial.TabIndex = 9;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(800, 39);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(116, 22);
            this.textSearch.TabIndex = 10;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // cboDeviceType
            // 
            this.cboDeviceType.FormattingEnabled = true;
            this.cboDeviceType.Location = new System.Drawing.Point(132, 97);
            this.cboDeviceType.Name = "cboDeviceType";
            this.cboDeviceType.Size = new System.Drawing.Size(121, 24);
            this.cboDeviceType.TabIndex = 11;
            this.cboDeviceType.SelectedIndexChanged += new System.EventHandler(this.cboDeviceType_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(379, 19);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 24);
            this.cboStatus.TabIndex = 12;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Device";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 35);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Device";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(368, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 35);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Device";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(529, 206);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 37);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 275);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 182);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Location = new System.Drawing.Point(1052, 6);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(100, 22);
            this.txtDeviceID.TabIndex = 18;
            this.txtDeviceID.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(830, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(50, 16);
            this.lbl.TabIndex = 19;
            this.lbl.Text = "Search";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(906, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 59);
            this.button1.TabIndex = 20;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtModelYear
            // 
            this.txtModelYear.Location = new System.Drawing.Point(619, 22);
            this.txtModelYear.Name = "txtModelYear";
            this.txtModelYear.Size = new System.Drawing.Size(116, 22);
            this.txtModelYear.TabIndex = 22;
            this.txtModelYear.TextChanged += new System.EventHandler(this.txtModelYear_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Model Year";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 603);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtModelYear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtDeviceID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboDeviceType);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.txtAssignedTo);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.txtAssetTag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DeviceForm.cs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAssetTag;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtAssignedTo;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ComboBox cboDeviceType;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtModelYear;
        private System.Windows.Forms.Label label7;
    }
}

