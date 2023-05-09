namespace EvaluationManagerG10 {
    partial class FrmEvaluation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblEvaluationDate = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // cboActivities
            // 
            this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(26, 29);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(266, 21);
            this.cboActivities.TabIndex = 0;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(360, 29);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(149, 20);
            this.txtMinForSignature.TabIndex = 1;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(558, 29);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(152, 20);
            this.txtMinForGrade.TabIndex = 2;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(23, 13);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(51, 13);
            this.lblActivity.TabIndex = 3;
            this.lblActivity.Text = "Aktivnost";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(357, 13);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(77, 13);
            this.lblSignature.TabIndex = 4;
            this.lblSignature.Text = "Uvjet za potpis";
            this.lblSignature.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(555, 13);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(81, 13);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Uvjet za ocjenu";
            this.lblGrade.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(343, 315);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtTeacher.TabIndex = 7;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(469, 314);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(100, 20);
            this.txtEvaluationDate.TabIndex = 8;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(590, 314);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(120, 20);
            this.numPoints.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(530, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(635, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(343, 296);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(57, 13);
            this.lblTeacher.TabIndex = 13;
            this.lblTeacher.Text = "Ocjenjivač";
            // 
            // lblEvaluationDate
            // 
            this.lblEvaluationDate.AutoSize = true;
            this.lblEvaluationDate.Location = new System.Drawing.Point(469, 295);
            this.lblEvaluationDate.Name = "lblEvaluationDate";
            this.lblEvaluationDate.Size = new System.Drawing.Size(89, 13);
            this.lblEvaluationDate.TabIndex = 14;
            this.lblEvaluationDate.Text = "Datum evaluacije";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(590, 294);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(40, 13);
            this.lblPoints.TabIndex = 15;
            this.lblPoints.Text = "Bodovi";
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(26, 70);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(684, 204);
            this.txtActivityDescription.TabIndex = 16;
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblEvaluationDate);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.cboActivities);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            this.Load += new System.EventHandler(this.FrmEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblEvaluationDate;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtActivityDescription;
    }
}