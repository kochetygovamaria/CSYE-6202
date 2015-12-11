using System.Collections.Generic;

namespace FinalProject
{
    partial class Add_Patient
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
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNameF = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textDOB = new System.Windows.Forms.TextBox();
            this.textNumberInsurance = new System.Windows.Forms.TextBox();
            this.textIncuranceName = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.Label();
            this.InsuranceNumber = new System.Windows.Forms.Label();
            this.healthProvider = new System.Windows.Forms.Label();
            this.buttonResert = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(37, 104);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(116, 25);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(37, 175);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(115, 25);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient ID";
            // 
            // textNameF
            // 
            this.textNameF.Location = new System.Drawing.Point(203, 101);
            this.textNameF.Name = "textNameF";
            this.textNameF.Size = new System.Drawing.Size(214, 31);
            this.textNameF.TabIndex = 3;
            this.textNameF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(203, 175);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(209, 31);
            this.textLastName.TabIndex = 4;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(203, 247);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(208, 31);
            this.textID.TabIndex = 5;
            // 
            // textDOB
            // 
            this.textDOB.Location = new System.Drawing.Point(204, 453);
            this.textDOB.Name = "textDOB";
            this.textDOB.Size = new System.Drawing.Size(208, 31);
            this.textDOB.TabIndex = 11;
            // 
            // textNumberInsurance
            // 
            this.textNumberInsurance.Location = new System.Drawing.Point(202, 378);
            this.textNumberInsurance.Name = "textNumberInsurance";
            this.textNumberInsurance.Size = new System.Drawing.Size(209, 31);
            this.textNumberInsurance.TabIndex = 10;
            // 
            // textIncuranceName
            // 
            this.textIncuranceName.Location = new System.Drawing.Point(203, 307);
            this.textIncuranceName.Name = "textIncuranceName";
            this.textIncuranceName.Size = new System.Drawing.Size(209, 31);
            this.textIncuranceName.TabIndex = 9;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSize = true;
            this.DateOfBirth.Location = new System.Drawing.Point(37, 453);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(135, 25);
            this.DateOfBirth.TabIndex = 8;
            this.DateOfBirth.Text = "Date Of Birth";
            // 
            // InsuranceNumber
            // 
            this.InsuranceNumber.AutoSize = true;
            this.InsuranceNumber.Location = new System.Drawing.Point(12, 381);
            this.InsuranceNumber.Name = "InsuranceNumber";
            this.InsuranceNumber.Size = new System.Drawing.Size(187, 25);
            this.InsuranceNumber.TabIndex = 7;
            this.InsuranceNumber.Text = "Insurance Number";
            // 
            // healthProvider
            // 
            this.healthProvider.AutoSize = true;
            this.healthProvider.Location = new System.Drawing.Point(37, 310);
            this.healthProvider.Name = "healthProvider";
            this.healthProvider.Size = new System.Drawing.Size(160, 25);
            this.healthProvider.TabIndex = 6;
            this.healthProvider.Text = "Health Provider";
            // 
            // buttonResert
            // 
            this.buttonResert.Location = new System.Drawing.Point(548, 310);
            this.buttonResert.Name = "buttonResert";
            this.buttonResert.Size = new System.Drawing.Size(170, 80);
            this.buttonResert.TabIndex = 13;
            this.buttonResert.Text = "Resert";
            this.buttonResert.UseVisualStyleBackColor = true;
            this.buttonResert.Click += new System.EventHandler(this.buttonResert_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(548, 175);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 80);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Add_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 667);
            this.Controls.Add(this.buttonResert);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textDOB);
            this.Controls.Add(this.textNumberInsurance);
            this.Controls.Add(this.textIncuranceName);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.InsuranceNumber);
            this.Controls.Add(this.healthProvider);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textNameF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Add_Patient";
            this.Text = "Add_Patient";
            this.Load += new System.EventHandler(this.Add_Patient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNameF;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textDOB;
        private System.Windows.Forms.TextBox textNumberInsurance;
        private System.Windows.Forms.TextBox textIncuranceName;
        private System.Windows.Forms.Label DateOfBirth;
        private System.Windows.Forms.Label InsuranceNumber;
        private System.Windows.Forms.Label healthProvider;
        private System.Windows.Forms.Button buttonResert;
        private System.Windows.Forms.Button buttonAdd;
        private List<Person> persons;

       
    }
}