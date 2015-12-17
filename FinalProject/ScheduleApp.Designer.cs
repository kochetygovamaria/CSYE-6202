using System.Collections.Generic;

namespace FinalProject
{
    partial class ScheduleApp
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
            this.DoctorCBX = new System.Windows.Forms.ComboBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.PatientCBX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.ReasonCBX = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AppID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoctorCBX
            // 
            this.DoctorCBX.FormattingEnabled = true;
            this.DoctorCBX.Location = new System.Drawing.Point(317, 158);
            this.DoctorCBX.Name = "DoctorCBX";
            this.DoctorCBX.Size = new System.Drawing.Size(217, 33);
            this.DoctorCBX.TabIndex = 2;
            // 
            // PatientCBX
            // 
            this.PatientCBX.FormattingEnabled = true;
            this.PatientCBX.Location = new System.Drawing.Point(317, 92);
            this.PatientCBX.Name = "PatientCBX";
            this.PatientCBX.Size = new System.Drawing.Size(217, 33);
            this.PatientCBX.TabIndex = 3;
            this.PatientCBX.SelectedIndexChanged += new System.EventHandler(this.PatientCBX_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reason";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(438, 495);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(170, 80);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(229, 495);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(170, 80);
            this.buttonSchedule.TabIndex = 14;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click_1);
            // 
            // ReasonCBX
            // 
            this.ReasonCBX.FormattingEnabled = true;
            this.ReasonCBX.Location = new System.Drawing.Point(316, 295);
            this.ReasonCBX.Name = "ReasonCBX";
            this.ReasonCBX.Size = new System.Drawing.Size(218, 33);
            this.ReasonCBX.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 31);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // AppID
            // 
            this.AppID.Location = new System.Drawing.Point(316, 44);
            this.AppID.Name = "AppID";
            this.AppID.Size = new System.Drawing.Size(218, 31);
            this.AppID.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID";
            // 
            // ScheduleApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AppID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ReasonCBX);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientCBX);
            this.Controls.Add(this.DoctorCBX);
            this.Name = "ScheduleApp";
            this.Text = "ScheduleApp";
            this.Load += new System.EventHandler(this.ScheduleApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DoctorCBX;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ComboBox PatientCBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.ComboBox ReasonCBX;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox AppID;
        private System.Windows.Forms.Label label5;
    }
}