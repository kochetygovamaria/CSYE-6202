namespace SrudentDirectory
{
    partial class NewStudentRegistration
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
            this.groupBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxEnroll = new System.Windows.Forms.GroupBox();
            this.radioButtonType2 = new System.Windows.Forms.RadioButton();
            this.radioButtonType = new System.Windows.Forms.RadioButton();
            this.textStudentID = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonResert = new System.Windows.Forms.Button();
            this.groupBoxStudentInfo.SuspendLayout();
            this.groupBoxEnroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudentInfo
            // 
            this.groupBoxStudentInfo.Controls.Add(this.groupBoxEnroll);
            this.groupBoxStudentInfo.Controls.Add(this.textStudentID);
            this.groupBoxStudentInfo.Controls.Add(this.textFirstName);
            this.groupBoxStudentInfo.Controls.Add(this.textLastName);
            this.groupBoxStudentInfo.Controls.Add(this.comboBoxDepartment);
            this.groupBoxStudentInfo.Controls.Add(this.label4);
            this.groupBoxStudentInfo.Controls.Add(this.label3);
            this.groupBoxStudentInfo.Controls.Add(this.label2);
            this.groupBoxStudentInfo.Controls.Add(this.label1);
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(41, 38);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(1014, 366);
            this.groupBoxStudentInfo.TabIndex = 1;
            this.groupBoxStudentInfo.TabStop = false;
            this.groupBoxStudentInfo.Text = "Student Info";
            // 
            // groupBoxEnroll
            // 
            this.groupBoxEnroll.Controls.Add(this.radioButtonType2);
            this.groupBoxEnroll.Controls.Add(this.radioButtonType);
            this.groupBoxEnroll.Location = new System.Drawing.Point(492, 50);
            this.groupBoxEnroll.Name = "groupBoxEnroll";
            this.groupBoxEnroll.Size = new System.Drawing.Size(468, 241);
            this.groupBoxEnroll.TabIndex = 8;
            this.groupBoxEnroll.TabStop = false;
            this.groupBoxEnroll.Text = "Enrollment Type";
            // 
            // radioButtonType2
            // 
            this.radioButtonType2.AutoSize = true;
            this.radioButtonType2.Location = new System.Drawing.Point(287, 114);
            this.radioButtonType2.Name = "radioButtonType2";
            this.radioButtonType2.Size = new System.Drawing.Size(135, 29);
            this.radioButtonType2.TabIndex = 1;
            this.radioButtonType2.Text = "Part Time";
            this.radioButtonType2.UseVisualStyleBackColor = true;
            // 
            // radioButtonType
            // 
            this.radioButtonType.AutoSize = true;
            this.radioButtonType.Checked = true;
            this.radioButtonType.Location = new System.Drawing.Point(54, 114);
            this.radioButtonType.Name = "radioButtonType";
            this.radioButtonType.Size = new System.Drawing.Size(131, 29);
            this.radioButtonType.TabIndex = 0;
            this.radioButtonType.TabStop = true;
            this.radioButtonType.Text = "Full Time";
            this.radioButtonType.UseVisualStyleBackColor = true;
            // 
            // textStudentID
            // 
            this.textStudentID.Location = new System.Drawing.Point(220, 60);
            this.textStudentID.Name = "textStudentID";
            this.textStudentID.Size = new System.Drawing.Size(179, 31);
            this.textStudentID.TabIndex = 7;
            this.textStudentID.TextChanged += new System.EventHandler(this.EnableResetBurron);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(220, 128);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(179, 31);
            this.textFirstName.TabIndex = 6;
            this.textFirstName.TextChanged += new System.EventHandler(this.EnableResetBurron);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(220, 193);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(179, 31);
            this.textLastName.TabIndex = 5;
            this.textLastName.TextChanged += new System.EventHandler(this.EnableResetBurron);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "",
            "Information System",
            "Nursing",
            "International Affairs",
            "Pharmacy",
            "Professional Studies",
            "Psycology",
            "Public Administration"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(220, 259);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(179, 33);
            this.comboBoxDepartment.TabIndex = 4;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            this.comboBoxDepartment.TextChanged += new System.EventHandler(this.EnableResetBurron);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(294, 463);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 80);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonResert
            // 
            this.buttonResert.Location = new System.Drawing.Point(499, 463);
            this.buttonResert.Name = "buttonResert";
            this.buttonResert.Size = new System.Drawing.Size(170, 80);
            this.buttonResert.TabIndex = 3;
            this.buttonResert.Text = "Resert";
            this.buttonResert.UseVisualStyleBackColor = true;
            this.buttonResert.Click += new System.EventHandler(this.buttonResert_Click);
            // 
            // NewStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 597);
            this.Controls.Add(this.buttonResert);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxStudentInfo);
            this.Name = "NewStudentRegistration";
            this.Text = "NewStudentRegistration";
            this.Load += new System.EventHandler(this.NewStudentRegistration_Load);
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            this.groupBoxEnroll.ResumeLayout(false);
            this.groupBoxEnroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudentInfo;
        private System.Windows.Forms.GroupBox groupBoxEnroll;
        private System.Windows.Forms.RadioButton radioButtonType2;
        private System.Windows.Forms.RadioButton radioButtonType;
        private System.Windows.Forms.TextBox textStudentID;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonResert;
    }
}