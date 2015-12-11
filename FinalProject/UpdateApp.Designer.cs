namespace FinalProject
{
    partial class UpdateApp
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ReasonCBX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientCBX = new System.Windows.Forms.ComboBox();
            this.DoctorCBX = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.AppID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(627, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 31);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // ReasonCBX
            // 
            this.ReasonCBX.FormattingEnabled = true;
            this.ReasonCBX.Items.AddRange(new object[] {
            "New Appoimnet",
            "Follow-up"});
            this.ReasonCBX.Location = new System.Drawing.Point(626, 318);
            this.ReasonCBX.Name = "ReasonCBX";
            this.ReasonCBX.Size = new System.Drawing.Size(218, 33);
            this.ReasonCBX.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Patient";
            // 
            // PatientCBX
            // 
            this.PatientCBX.Enabled = false;
            this.PatientCBX.FormattingEnabled = true;
            this.PatientCBX.Location = new System.Drawing.Point(627, 115);
            this.PatientCBX.Name = "PatientCBX";
            this.PatientCBX.Size = new System.Drawing.Size(217, 33);
            this.PatientCBX.TabIndex = 21;
            // 
            // DoctorCBX
            // 
            this.DoctorCBX.FormattingEnabled = true;
            this.DoctorCBX.Location = new System.Drawing.Point(627, 181);
            this.DoctorCBX.Name = "DoctorCBX";
            this.DoctorCBX.Size = new System.Drawing.Size(217, 33);
            this.DoctorCBX.TabIndex = 20;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(627, 430);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(217, 74);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // AppID
            // 
            this.AppID.Enabled = false;
            this.AppID.Location = new System.Drawing.Point(626, 52);
            this.AppID.Name = "AppID";
            this.AppID.Size = new System.Drawing.Size(218, 31);
            this.AppID.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Appoimnet ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // UpdateApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 887);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AppID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ReasonCBX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientCBX);
            this.Controls.Add(this.DoctorCBX);
            this.Name = "UpdateApp";
            this.Text = "UpdateApp";
            this.Load += new System.EventHandler(this.UpdateApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ReasonCBX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PatientCBX;
        private System.Windows.Forms.ComboBox DoctorCBX;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox AppID;
        private System.Windows.Forms.Label label5;
    }
}