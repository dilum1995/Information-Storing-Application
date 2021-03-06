﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudenInformationStoringApp
{
    public partial class SystemMainForm : Form
    {
        //public static extern int SetParent(int hWndChild, int hWndNewParent);
        public SystemMainForm()
        {
            InitializeComponent();
        }

        //method which block multiple windows opening at the same time
        private bool IsAlreadyLoded(Form frmForm)
        {
            bool bllFound = false;

            try
            {
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.Name.Equals(frmForm.Name.ToString()))
                    {
                        bllFound = true;
                        frm.WindowState = frmForm.WindowState;
                        frm.Focus();
                        break;
                    }
                }
                if (!bllFound)
                {
                    frmForm.MdiParent = this;
                    frmForm.Show();
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return bllFound;
        }
        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmInsertStudentDetails objfrmInsertStudentDetails = new frmInsertStudentDetails();
            //frm
            
            //this condition will check whether there is any forms loded before system loads another form.
            if (!IsAlreadyLoded(objfrmInsertStudentDetails))
            {
                objfrmInsertStudentDetails.Show();
            }
            else
            {
                MessageBox.Show("Please save and close the current window !","System warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
           
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertDepartments objInsertDepartments = new InsertDepartments();
            

            //this condition will check whether there is any forms loded before system loads another form.
            if (!IsAlreadyLoded(objInsertDepartments))
            {
                objInsertDepartments.Show();
            }
            else
            {
                MessageBox.Show("Please save and close the current window !", "System warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void studentMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertStudentMarkFinal objInsertStudentMarkFinal = new InsertStudentMarkFinal();
           

            //this condition will check whether there is any forms loded before system loads another form.
            if (!IsAlreadyLoded(objInsertStudentMarkFinal))
            {
                objInsertStudentMarkFinal.Show();
            }
            else
            {
                MessageBox.Show("Please save and close the current window !", "System warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void semestersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertSemesterDetailsForm objInsertSemesterDetailsForm = new InsertSemesterDetailsForm();

            //this condition will check whether there is any forms loded before system loads another form.
            if (!IsAlreadyLoded(objInsertSemesterDetailsForm))
            {
                objInsertSemesterDetailsForm.Show();
            }
            else
            {
                MessageBox.Show("Please save and close the current window !", "System warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InsertSubjectForm objInsertSubjectForm = new InsertSubjectForm();

            //this condition will check whether there is any forms loded before system loads another form.
            if (!IsAlreadyLoded(objInsertSubjectForm))
            {
                objInsertSubjectForm.Show();
            }
            else
            {
                MessageBox.Show("Please save and close the current window !", "System warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void semesterSubjectAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SemSubConfig objSemSubConfig = new SemSubConfig();

            //this condition will check whether there is any forms loded before system loads another form.
            if (!IsAlreadyLoded(objSemSubConfig))
            {
                objSemSubConfig.Show();
            }
            else
            {
                MessageBox.Show("Please save and close the current window !", "System warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void semesterDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SemesterReport objSemsterReport = new SemesterReport();

            //this condition will check whether there is any forms loded before system loads another form.
            if (!IsAlreadyLoded(objSemsterReport))
            {
                objSemsterReport.Show();
            }
            else
            {
                MessageBox.Show("Please save and close the current window !", "System warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void studentDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSystemView objfrmSystemView = new frmSystemView();
            //frm

            //this condition will check whether there is any forms loded before system loads another form.
            if (!IsAlreadyLoded(objfrmSystemView))
            {
                objfrmSystemView.Show();
            }
            else
            {
                MessageBox.Show("Please save and close the current window !", "System warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void studentSemsterAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentSemConfig objStudentSemConfig = new StudentSemConfig();


            //this condition will check whether there is any forms loded before system loads another form.
            if (!IsAlreadyLoded(objStudentSemConfig))
            {
                objStudentSemConfig.Show();
            }
            else
            {
                MessageBox.Show("Please save and close the current window !", "System warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
