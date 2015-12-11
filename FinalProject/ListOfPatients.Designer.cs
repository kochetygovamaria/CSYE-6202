namespace FinalProject
{
    partial class ListOfPatients
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.textDOB = new System.Windows.Forms.TextBox();
            this.textNumberInsurance = new System.Windows.Forms.TextBox();
            this.textIncuranceName = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.Label();
            this.InsuranceNumber = new System.Windows.Forms.Label();
            this.healthProvider = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textNameF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.PatientInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PatientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 507);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(654, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1051, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(186, 58);
            this.Add.TabIndex = 1;
            this.Add.Text = "New Patient";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textDOB
            // 
            this.textDOB.Enabled = false;
            this.textDOB.Location = new System.Drawing.Point(201, 419);
            this.textDOB.Name = "textDOB";
            this.textDOB.Size = new System.Drawing.Size(208, 31);
            this.textDOB.TabIndex = 23;
            // 
            // textNumberInsurance
            // 
            this.textNumberInsurance.Enabled = false;
            this.textNumberInsurance.Location = new System.Drawing.Point(199, 344);
            this.textNumberInsurance.Name = "textNumberInsurance";
            this.textNumberInsurance.Size = new System.Drawing.Size(209, 31);
            this.textNumberInsurance.TabIndex = 22;
            // 
            // textIncuranceName
            // 
            this.textIncuranceName.Enabled = false;
            this.textIncuranceName.Location = new System.Drawing.Point(200, 273);
            this.textIncuranceName.Name = "textIncuranceName";
            this.textIncuranceName.Size = new System.Drawing.Size(209, 31);
            this.textIncuranceName.TabIndex = 21;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSize = true;
            this.DateOfBirth.Location = new System.Drawing.Point(34, 419);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(135, 25);
            this.DateOfBirth.TabIndex = 20;
            this.DateOfBirth.Text = "Date Of Birth";
            // 
            // InsuranceNumber
            // 
            this.InsuranceNumber.AutoSize = true;
            this.InsuranceNumber.Location = new System.Drawing.Point(9, 347);
            this.InsuranceNumber.Name = "InsuranceNumber";
            this.InsuranceNumber.Size = new System.Drawing.Size(187, 25);
            this.InsuranceNumber.TabIndex = 19;
            this.InsuranceNumber.Text = "Insurance Number";
            // 
            // healthProvider
            // 
            this.healthProvider.AutoSize = true;
            this.healthProvider.Location = new System.Drawing.Point(34, 276);
            this.healthProvider.Name = "healthProvider";
            this.healthProvider.Size = new System.Drawing.Size(160, 25);
            this.healthProvider.TabIndex = 18;
            this.healthProvider.Text = "Health Provider";
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(200, 213);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(208, 31);
            this.textID.TabIndex = 17;
            // 
            // textLastName
            // 
            this.textLastName.Enabled = false;
            this.textLastName.Location = new System.Drawing.Point(200, 141);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(209, 31);
            this.textLastName.TabIndex = 16;
            // 
            // textNameF
            // 
            this.textNameF.Enabled = false;
            this.textNameF.Location = new System.Drawing.Point(200, 67);
            this.textNameF.Name = "textNameF";
            this.textNameF.Size = new System.Drawing.Size(214, 31);
            this.textNameF.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Patient ID";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(34, 141);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(115, 25);
            this.lastName.TabIndex = 13;
            this.lastName.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(33, 73);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(116, 25);
            this.firstName.TabIndex = 12;
            this.firstName.Text = "First Name";
            // 
            // PatientInfo
            // 
            this.PatientInfo.Controls.Add(this.textDOB);
            this.PatientInfo.Controls.Add(this.textNumberInsurance);
            this.PatientInfo.Controls.Add(this.textIncuranceName);
            this.PatientInfo.Controls.Add(this.DateOfBirth);
            this.PatientInfo.Controls.Add(this.InsuranceNumber);
            this.PatientInfo.Controls.Add(this.healthProvider);
            this.PatientInfo.Controls.Add(this.textID);
            this.PatientInfo.Controls.Add(this.textLastName);
            this.PatientInfo.Controls.Add(this.textNameF);
            this.PatientInfo.Controls.Add(this.label3);
            this.PatientInfo.Controls.Add(this.lastName);
            this.PatientInfo.Controls.Add(this.firstName);
            this.PatientInfo.Location = new System.Drawing.Point(311, 12);
            this.PatientInfo.Name = "PatientInfo";
            this.PatientInfo.Size = new System.Drawing.Size(604, 474);
            this.PatientInfo.TabIndex = 24;
            this.PatientInfo.TabStop = false;
            this.PatientInfo.Text = "Patient Info";
            // 
            // ListOfPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 831);
            this.Controls.Add(this.PatientInfo);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListOfPatients";
            this.Text = "ListOfPatients";
            this.Load += new System.EventHandler(this.ListOfPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PatientInfo.ResumeLayout(false);
            this.PatientInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textDOB;
        private System.Windows.Forms.TextBox textNumberInsurance;
        private System.Windows.Forms.TextBox textIncuranceName;
        private System.Windows.Forms.Label DateOfBirth;
        private System.Windows.Forms.Label InsuranceNumber;
        private System.Windows.Forms.Label healthProvider;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textNameF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.GroupBox PatientInfo;
    }
}