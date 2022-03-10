namespace StudentManagement
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.lbeName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbeDept = new System.Windows.Forms.Label();
            this.cmboDept = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvShowDetailsBox = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDetailsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(160, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Student Management System";
            // 
            // lbeName
            // 
            this.lbeName.AutoSize = true;
            this.lbeName.Location = new System.Drawing.Point(174, 122);
            this.lbeName.Name = "lbeName";
            this.lbeName.Size = new System.Drawing.Size(100, 17);
            this.lbeName.TabIndex = 1;
            this.lbeName.Text = "Student Name";
            this.lbeName.Click += new System.EventHandler(this.lbeName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(347, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 25);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbeDept
            // 
            this.lbeDept.AutoSize = true;
            this.lbeDept.Location = new System.Drawing.Point(174, 167);
            this.lbeDept.Name = "lbeDept";
            this.lbeDept.Size = new System.Drawing.Size(85, 17);
            this.lbeDept.TabIndex = 3;
            this.lbeDept.Text = "Department";
            this.lbeDept.Click += new System.EventHandler(this.lbeDept_Click);
            // 
            // cmboDept
            // 
            this.cmboDept.FormattingEnabled = true;
            this.cmboDept.Items.AddRange(new object[] {
            "B.E - CSE",
            "B.E - ECE",
            "B.E - Mech",
            "B.E - Civil",
            "B.E - EEE",
            "B.Tech - FT"});
            this.cmboDept.Location = new System.Drawing.Point(347, 167);
            this.cmboDept.Name = "cmboDept";
            this.cmboDept.Size = new System.Drawing.Size(160, 25);
            this.cmboDept.TabIndex = 4;
            this.cmboDept.SelectedIndexChanged += new System.EventHandler(this.cmboDept_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mobile Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(347, 215);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(160, 25);
            this.txtMobileNo.TabIndex = 6;
            this.txtMobileNo.TextChanged += new System.EventHandler(this.txtMobileNo_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Student";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(296, 266);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 28);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Clear";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvShowDetailsBox
            // 
            this.dgvShowDetailsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDetailsBox.Location = new System.Drawing.Point(4, 320);
            this.dgvShowDetailsBox.Name = "dgvShowDetailsBox";
            this.dgvShowDetailsBox.Size = new System.Drawing.Size(723, 252);
            this.dgvShowDetailsBox.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(531, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 28);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "RollNumber";
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.Location = new System.Drawing.Point(347, 74);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(160, 25);
            this.txtRollNumber.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(408, 266);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 28);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(531, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(739, 600);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtRollNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvShowDetailsBox);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboDept);
            this.Controls.Add(this.lbeDept);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudent";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDetailsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbeName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbeDept;
        private System.Windows.Forms.ComboBox cmboDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvShowDetailsBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
    }
}

