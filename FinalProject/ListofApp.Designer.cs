using System.Collections.Generic;

namespace FinalProject
{
    partial class ListofApp
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
            this.AppoimentGridView = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.ScheduleAppoiment = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReasonCBX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientCBX = new System.Windows.Forms.ComboBox();
            this.DoctorCBX = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AppID = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.AppoimentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppoimentGridView
            // 
            this.AppoimentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppoimentGridView.Location = new System.Drawing.Point(122, 449);
            this.AppoimentGridView.Name = "AppoimentGridView";
            this.AppoimentGridView.RowTemplate.Height = 33;
            this.AppoimentGridView.Size = new System.Drawing.Size(976, 512);
            this.AppoimentGridView.TabIndex = 0;
            this.AppoimentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.AppoimentGridView.SelectionChanged += new System.EventHandler(this.AppoimentGridView_SelectionChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(170, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(177, 65);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel an Appominet ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // ScheduleAppoiment
            // 
            this.ScheduleAppoiment.Location = new System.Drawing.Point(-3, 0);
            this.ScheduleAppoiment.Name = "ScheduleAppoiment";
            this.ScheduleAppoiment.Size = new System.Drawing.Size(177, 65);
            this.ScheduleAppoiment.TabIndex = 3;
            this.ScheduleAppoiment.Text = "Schedule App";
            this.ScheduleAppoiment.UseVisualStyleBackColor = true;
            this.ScheduleAppoiment.Click += new System.EventHandler(this.ScheduleAppoiment_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(363, 301);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(217, 31);
            this.dateTimePicker.TabIndex = 27;
            // 
            // ReasonCBX
            // 
            this.ReasonCBX.Enabled = false;
            this.ReasonCBX.FormattingEnabled = true;
            this.ReasonCBX.Location = new System.Drawing.Point(362, 365);
            this.ReasonCBX.Name = "ReasonCBX";
            this.ReasonCBX.Size = new System.Drawing.Size(218, 33);
            this.ReasonCBX.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Patient";
            // 
            // PatientCBX
            // 
            this.PatientCBX.Enabled = false;
            this.PatientCBX.FormattingEnabled = true;
            this.PatientCBX.Location = new System.Drawing.Point(363, 162);
            this.PatientCBX.Name = "PatientCBX";
            this.PatientCBX.Size = new System.Drawing.Size(217, 33);
            this.PatientCBX.TabIndex = 21;
            // 
            // DoctorCBX
            // 
            this.DoctorCBX.Enabled = false;
            this.DoctorCBX.FormattingEnabled = true;
            this.DoctorCBX.Location = new System.Drawing.Point(363, 228);
            this.DoctorCBX.Name = "DoctorCBX";
            this.DoctorCBX.Size = new System.Drawing.Size(217, 33);
            this.DoctorCBX.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 65);
            this.button1.TabIndex = 28;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AppID
            // 
            this.AppID.Location = new System.Drawing.Point(363, 99);
            this.AppID.Name = "AppID";
            this.AppID.Size = new System.Drawing.Size(218, 31);
            this.AppID.TabIndex = 29;
            // 
            // ListofApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 1045);
            this.Controls.Add(this.AppID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.ReasonCBX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientCBX);
            this.Controls.Add(this.DoctorCBX);
            this.Controls.Add(this.ScheduleAppoiment);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.AppoimentGridView);
            this.Name = "ListofApp";
            this.Text = "List_of_App";
            this.Load += new System.EventHandler(this.List_of_App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppoimentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppoimentGridView;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button ScheduleAppoiment;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox ReasonCBX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PatientCBX;
        private System.Windows.Forms.ComboBox DoctorCBX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AppID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}