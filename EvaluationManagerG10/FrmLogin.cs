using EvaluationManagerG10.Models;
using EvaluationManagerG10.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerG10
{
    public partial class frmLogin : Form
    {

        public static Teacher LoggedTeacher { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void txtUsername1_Load(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtUsername.Text == "") {
                MessageBox.Show("Korisnicko ime nije unseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPassword.Text == "") {
                MessageBox.Show("Password nije unsen!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoggedTeacher = TeacherRepository.GetTeacher(txtUsername.Text);
            if (LoggedTeacher != null && LoggedTeacher.CheckPassword(txtPassword.Text)) {
                FrmStudents frmStudents = new FrmStudents();
                Hide();
                frmStudents.ShowDialog();
                Close();
            } else {
                MessageBox.Show("Krivi podaci", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
