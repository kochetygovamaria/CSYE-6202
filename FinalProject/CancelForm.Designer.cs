namespace FinalProject
{
    partial class CancelForm
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
            this.AppID = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReasonCBX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientCBX = new System.Windows.Forms.ComboBox();
            this.DoctorCBX = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppID
            // 
            this.AppID.Location = new System.Drawing.Point(324, 66);
            this.AppID.Name = "AppID";
            this.AppID.Size = new System.Drawing.Size(218, 31);
            this.AppID.TabIndex = 38;
            this.AppID.TextChanged += new System.EventHandler(this.AppID_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(324, 268);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(217, 31);
            this.dateTimePicker.TabIndex = 37;
            // 
            // ReasonCBX
            // 
            this.ReasonCBX.Enabled = false;
            this.ReasonCBX.FormattingEnabled = true;
            this.ReasonCBX.Location = new System.Drawing.Point(323, 332);
            this.ReasonCBX.Name = "ReasonCBX";
            this.ReasonCBX.Size = new System.Drawing.Size(218, 33);
            this.ReasonCBX.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Patient";
            // 
            // PatientCBX
            // 
            this.PatientCBX.Enabled = false;
            this.PatientCBX.FormattingEnabled = true;
            this.PatientCBX.Location = new System.Drawing.Point(324, 129);
            this.PatientCBX.Name = "PatientCBX";
            this.PatientCBX.Size = new System.Drawing.Size(217, 33);
            this.PatientCBX.TabIndex = 31;
            // 
            // DoctorCBX
            // 
            this.DoctorCBX.Enabled = false;
            this.DoctorCBX.FormattingEnabled = true;
            this.DoctorCBX.Location = new System.Drawing.Point(324, 195);
            this.DoctorCBX.Name = "DoctorCBX";
            this.DoctorCBX.Size = new System.Drawing.Size(217, 33);
            this.DoctorCBX.TabIndex = 30;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(324, 438);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(217, 69);
            this.DeleteButton.TabIndex = 39;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 667);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AppID);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.ReasonCBX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientCBX);
            this.Controls.Add(this.DoctorCBX);
            this.Name = "CancelForm";
            this.Text = "CancelForm";
            this.Load += new System.EventHandler(this.CancelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AppID;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox ReasonCBX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PatientCBX;
        private System.Windows.Forms.ComboBox DoctorCBX;
        private System.Windows.Forms.Button DeleteButton;
    }
}