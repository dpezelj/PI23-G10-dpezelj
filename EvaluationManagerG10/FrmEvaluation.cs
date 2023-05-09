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

namespace EvaluationManagerG10 {
    public partial class FrmEvaluation : Form {
        private Student student;
        public FrmEvaluation(Student selectedStudent) {
            InitializeComponent();
            student = selectedStudent;
        }

        private void FrmEvaluation_Load(object sender, EventArgs e) {
            SetFormText();
            var activities = ActivityRepository.GetActivities();
            cboActivities.DataSource = activities;
        }

        private void SetFormText() {
            Text = student.First_Name + student.Last_Name;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            var currentActivity = cboActivities.SelectedItem as Activity;   
            
            txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity.MaxPoints;
            txtMinForSignature.Text = currentActivity.MinPointsForSignature + "/" + currentActivity.MaxPoints;
            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoints;

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}
