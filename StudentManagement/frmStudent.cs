using System;
using System.Windows.Forms;
//using 

using DataAccessLayer;
using ObjectClass;

namespace StudentManagement
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtName.Text;
            student.Department = cmboDept.SelectedItem.ToString();
            student.MobileNumber = txtMobileNo.Text;
            int RowAffected = CRUD_Operations.SaveEmployee(student);
            if(RowAffected > 0)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Data inserted Successfully","Success");
                ShowAllStudent();
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Please Try Again","Error");
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            //txtRollNumber = "";
            cmboDept.SelectedItem = -1;
            txtMobileNo.Text = "";
            txtName.Focus();
        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbeName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbeDept_Click(object sender, EventArgs e)
        {

        }

        private void cmboDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void frmStudent_Load(object sender, EventArgs e)
        {
            ShowAllStudent();
        }
        private void ShowAllStudent()
        {
            dgvShowDetailsBox.DataSource= CRUD_Operations.GetAllStudent();
            dgvShowDetailsBox.Columns[0].Width = 90;
            dgvShowDetailsBox.Columns[1].Width = 200;
            dgvShowDetailsBox.Columns[2].Width = 200;
            dgvShowDetailsBox.Columns[3].Width = 200;
            lblCountValue.Text = CRUD_Operations.CountStudent().ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int roll =Convert.ToInt32(txtRollNumber.Text);
            int RF = CRUD_Operations.DeleteStudent(roll);
            if (RF > 0)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Data Deleted Successfully", "Success");
                txtRollNumber.Text = "";
                ShowAllStudent();
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Please Try Again", "Error");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.RollNumber = Convert.ToInt32(txtRollNumber.Text);
            student.Name = txtName.Text;
            student.Department = cmboDept.SelectedItem.ToString();
            student.MobileNumber = txtMobileNo.Text;
            int RowAffected = CRUD_Operations.UpdateStudent(student);
            if (RowAffected > 0)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Data Update Successfully", "Success");
                ShowAllStudent();
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Please Try Again", "Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student = CRUD_Operations.GetBasedOnRollNumber(Convert.ToInt32(txtRollNumber.Text));
            txtName.Text = student.Name;
            cmboDept.SelectedText = student.Department;
            txtMobileNo.Text = student.MobileNumber;
        }
    }
}
