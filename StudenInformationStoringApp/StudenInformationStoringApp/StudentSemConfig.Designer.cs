﻿namespace StudenInformationStoringApp
{
    partial class StudentSemConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSemConfig));
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            this.dgvStuSubSemConfig = new System.Windows.Forms.DataGridView();
            this.clmFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmuniversityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSemesterCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStuSemConfigID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSemesterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.cmbSemster = new System.Windows.Forms.ComboBox();
            this.cmbStudentID = new System.Windows.Forms.ComboBox();
            this.lblSemsters = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuSubSemConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(32, 358);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 23);
            this.btnInsert.TabIndex = 89;
            this.btnInsert.Text = "Insert ";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Department";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(29, 179);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 87;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.lblCopyright2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright2.Location = new System.Drawing.Point(610, 433);
            this.lblCopyright2.Name = "lblCopyright2";
            this.lblCopyright2.Size = new System.Drawing.Size(27, 7);
            this.lblCopyright2.TabIndex = 86;
            this.lblCopyright2.Text = "C 2017";
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.lblCopyright1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright1.Location = new System.Drawing.Point(567, 429);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(45, 12);
            this.lblCopyright1.TabIndex = 85;
            this.lblCopyright1.Text = "Copyright";
            // 
            // dgvStuSubSemConfig
            // 
            this.dgvStuSubSemConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuSubSemConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFullName,
            this.clmuniversityID,
            this.clmSemesterCode,
            this.clmSubjectCode,
            this.clmSubjectName,
            this.clmStudentID,
            this.clmStuSemConfigID,
            this.clmSemesterID,
            this.clmSemesterName,
            this.clmSubjectID});
            this.dgvStuSubSemConfig.Location = new System.Drawing.Point(330, 21);
            this.dgvStuSubSemConfig.Name = "dgvStuSubSemConfig";
            this.dgvStuSubSemConfig.Size = new System.Drawing.Size(739, 298);
            this.dgvStuSubSemConfig.TabIndex = 83;
            this.dgvStuSubSemConfig.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStuSubSemConfig_RowHeaderMouseDoubleClick);
            // 
            // clmFullName
            // 
            this.clmFullName.DataPropertyName = "FullName";
            this.clmFullName.HeaderText = "Student\'s Name";
            this.clmFullName.Name = "clmFullName";
            // 
            // clmuniversityID
            // 
            this.clmuniversityID.DataPropertyName = "universityID";
            this.clmuniversityID.HeaderText = "university ID";
            this.clmuniversityID.Name = "clmuniversityID";
            // 
            // clmSemesterCode
            // 
            this.clmSemesterCode.DataPropertyName = "SemesterCode";
            this.clmSemesterCode.HeaderText = "Semester Code";
            this.clmSemesterCode.Name = "clmSemesterCode";
            // 
            // clmSubjectCode
            // 
            this.clmSubjectCode.DataPropertyName = "SubjectCode";
            this.clmSubjectCode.HeaderText = "Subject Code";
            this.clmSubjectCode.Name = "clmSubjectCode";
            // 
            // clmSubjectName
            // 
            this.clmSubjectName.DataPropertyName = "SubjectName";
            this.clmSubjectName.HeaderText = "Subject Name";
            this.clmSubjectName.Name = "clmSubjectName";
            // 
            // clmStudentID
            // 
            this.clmStudentID.DataPropertyName = "StudentID";
            this.clmStudentID.HeaderText = "Student ID";
            this.clmStudentID.Name = "clmStudentID";
            this.clmStudentID.Visible = false;
            // 
            // clmStuSemConfigID
            // 
            this.clmStuSemConfigID.DataPropertyName = "StuSemConfigID";
            this.clmStuSemConfigID.HeaderText = "StuSemConfigID";
            this.clmStuSemConfigID.Name = "clmStuSemConfigID";
            this.clmStuSemConfigID.Visible = false;
            // 
            // clmSemesterID
            // 
            this.clmSemesterID.DataPropertyName = "SemesterID";
            this.clmSemesterID.HeaderText = "Semester ID";
            this.clmSemesterID.Name = "clmSemesterID";
            this.clmSemesterID.Visible = false;
            // 
            // clmSemesterName
            // 
            this.clmSemesterName.DataPropertyName = "SemesterName";
            this.clmSemesterName.HeaderText = "Semester Name";
            this.clmSemesterName.Name = "clmSemesterName";
            this.clmSemesterName.Visible = false;
            // 
            // clmSubjectID
            // 
            this.clmSubjectID.DataPropertyName = "SubjectID";
            this.clmSubjectID.HeaderText = "Subject ID";
            this.clmSubjectID.Name = "clmSubjectID";
            this.clmSubjectID.Visible = false;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(109, 215);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(189, 20);
            this.txtDepartment.TabIndex = 82;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(109, 176);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(189, 20);
            this.txtStudentName.TabIndex = 81;
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(84, 32);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(165, 60);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 80;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // cmbSemster
            // 
            this.cmbSemster.FormattingEnabled = true;
            this.cmbSemster.Location = new System.Drawing.Point(109, 251);
            this.cmbSemster.Name = "cmbSemster";
            this.cmbSemster.Size = new System.Drawing.Size(189, 21);
            this.cmbSemster.TabIndex = 79;
            // 
            // cmbStudentID
            // 
            this.cmbStudentID.FormattingEnabled = true;
            this.cmbStudentID.Location = new System.Drawing.Point(109, 138);
            this.cmbStudentID.Name = "cmbStudentID";
            this.cmbStudentID.Size = new System.Drawing.Size(189, 21);
            this.cmbStudentID.TabIndex = 78;
            this.cmbStudentID.SelectionChangeCommitted += new System.EventHandler(this.cmbStudentID_SelectionChangeCommitted);
            // 
            // lblSemsters
            // 
            this.lblSemsters.AutoSize = true;
            this.lblSemsters.Location = new System.Drawing.Point(29, 254);
            this.lblSemsters.Name = "lblSemsters";
            this.lblSemsters.Size = new System.Drawing.Size(51, 13);
            this.lblSemsters.TabIndex = 77;
            this.lblSemsters.Text = "Semester";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(29, 141);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 76;
            this.lblStudentID.Text = "Student ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(878, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 23);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(981, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 91;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(136, 358);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 23);
            this.btnReset.TabIndex = 92;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // StudentSemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 449);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.dgvStuSubSemConfig);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Controls.Add(this.cmbSemster);
            this.Controls.Add(this.cmbStudentID);
            this.Controls.Add(this.lblSemsters);
            this.Controls.Add(this.lblStudentID);
            this.Name = "StudentSemConfig";
            this.Text = "StudentSemConfig";
            this.Load += new System.EventHandler(this.StudentSemConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuSubSemConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
        private System.Windows.Forms.DataGridView dgvStuSubSemConfig;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.ComboBox cmbSemster;
        private System.Windows.Forms.ComboBox cmbStudentID;
        private System.Windows.Forms.Label lblSemsters;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmuniversityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemesterCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStuSemConfigID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemesterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemesterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubjectID;
    }
}