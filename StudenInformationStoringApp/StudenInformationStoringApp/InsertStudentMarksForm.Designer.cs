﻿namespace StudenInformationStoringApp
{
    partial class frmInsertStudentMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertStudentMarks));
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbStudentID = new System.Windows.Forms.ComboBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.btnInsertMarks = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(65, 15);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(165, 60);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 1;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Semester";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(133, 112);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(146, 21);
            this.cmbDepartment.TabIndex = 5;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbStudentID
            // 
            this.cmbStudentID.FormattingEnabled = true;
            this.cmbStudentID.Location = new System.Drawing.Point(133, 144);
            this.cmbStudentID.Name = "cmbStudentID";
            this.cmbStudentID.Size = new System.Drawing.Size(146, 21);
            this.cmbStudentID.TabIndex = 6;
            this.cmbStudentID.SelectionChangeCommitted += new System.EventHandler(this.cmbStudentID_SelectionChangeCommitted);
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(133, 283);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(146, 20);
            this.txtMarks.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mark";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(133, 214);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(146, 21);
            this.cmbSemester.TabIndex = 10;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(133, 248);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(146, 21);
            this.cmbSubject.TabIndex = 11;
            // 
            // btnInsertMarks
            // 
            this.btnInsertMarks.Location = new System.Drawing.Point(35, 318);
            this.btnInsertMarks.Name = "btnInsertMarks";
            this.btnInsertMarks.Size = new System.Drawing.Size(75, 23);
            this.btnInsertMarks.TabIndex = 12;
            this.btnInsertMarks.Text = "Insert Marks";
            this.btnInsertMarks.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 290);
            this.dataGridView1.TabIndex = 13;
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.lblCopyright2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright2.Location = new System.Drawing.Point(387, 346);
            this.lblCopyright2.Name = "lblCopyright2";
            this.lblCopyright2.Size = new System.Drawing.Size(27, 7);
            this.lblCopyright2.TabIndex = 69;
            this.lblCopyright2.Text = "C 2017";
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.lblCopyright1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright1.Location = new System.Drawing.Point(344, 342);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(45, 12);
            this.lblCopyright1.TabIndex = 68;
            this.lblCopyright1.Text = "Copyright";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(133, 180);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(146, 20);
            this.txtStudentName.TabIndex = 70;
            // 
            // frmInsertStudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 363);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInsertMarks);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.cmbStudentID);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Name = "frmInsertStudentMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertStudentMarks";
            this.Load += new System.EventHandler(this.frmInsertStudentMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbStudentID;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Button btnInsertMarks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentName;
    }
}