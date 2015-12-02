namespace SrudentDirectory
{
    partial class FMstudentInfo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.buttonNewStudent = new System.Windows.Forms.Button();
            this.buttonRemoveStudent = new System.Windows.Forms.Button();
            this.buttonEditStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxStudentInfo.SuspendLayout();
            this.groupBoxEnroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStudentInfo
            // 
            this.groupBoxStudentInfo.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxStudentInfo.Controls.Add(this.groupBoxEnroll);
            this.groupBoxStudentInfo.Controls.Add(this.textStudentID);
            this.groupBoxStudentInfo.Controls.Add(this.textFirstName);
            this.groupBoxStudentInfo.Controls.Add(this.textLastName);
            this.groupBoxStudentInfo.Controls.Add(this.comboBoxDepartment);
            this.groupBoxStudentInfo.Controls.Add(this.label4);
            this.groupBoxStudentInfo.Controls.Add(this.label3);
            this.groupBoxStudentInfo.Controls.Add(this.label2);
            this.groupBoxStudentInfo.Controls.Add(this.label1);
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(27, 73);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(1014, 360);
            this.groupBoxStudentInfo.TabIndex = 0;
            this.groupBoxStudentInfo.TabStop = false;
            this.groupBoxStudentInfo.Text = "Student Info";
            this.groupBoxStudentInfo.Enter += new System.EventHandler(this.groupBoxStudentInfo_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(757, 354);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 9;
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
            this.radioButtonType.Location = new System.Drawing.Point(54, 114);
            this.radioButtonType.Name = "radioButtonType";
            this.radioButtonType.Size = new System.Drawing.Size(131, 29);
            this.radioButtonType.TabIndex = 0;
            this.radioButtonType.Text = "Full Time";
            this.radioButtonType.UseVisualStyleBackColor = true;
            // 
            // textStudentID
            // 
            this.textStudentID.Enabled = false;
            this.textStudentID.Location = new System.Drawing.Point(220, 60);
            this.textStudentID.Name = "textStudentID";
            this.textStudentID.Size = new System.Drawing.Size(179, 31);
            this.textStudentID.TabIndex = 7;
            // 
            // textFirstName
            // 
            this.textFirstName.Enabled = false;
            this.textFirstName.Location = new System.Drawing.Point(220, 128);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(179, 31);
            this.textFirstName.TabIndex = 6;
            // 
            // textLastName
            // 
            this.textLastName.Enabled = false;
            this.textLastName.Location = new System.Drawing.Point(220, 193);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(179, 31);
            this.textLastName.TabIndex = 5;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Enabled = false;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(220, 259);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(179, 33);
            this.comboBoxDepartment.TabIndex = 4;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNewStudent
            // 
            this.buttonNewStudent.Location = new System.Drawing.Point(1104, 119);
            this.buttonNewStudent.Name = "buttonNewStudent";
            this.buttonNewStudent.Size = new System.Drawing.Size(188, 80);
            this.buttonNewStudent.TabIndex = 1;
            this.buttonNewStudent.Text = "New Student";
            this.buttonNewStudent.UseVisualStyleBackColor = true;
            this.buttonNewStudent.Click += new System.EventHandler(this.buttonNewStudent_Click);
            // 
            // buttonRemoveStudent
            // 
            this.buttonRemoveStudent.Location = new System.Drawing.Point(1104, 241);
            this.buttonRemoveStudent.Name = "buttonRemoveStudent";
            this.buttonRemoveStudent.Size = new System.Drawing.Size(188, 80);
            this.buttonRemoveStudent.TabIndex = 2;
            this.buttonRemoveStudent.Text = "Remove Student";
            this.buttonRemoveStudent.UseVisualStyleBackColor = true;
            this.buttonRemoveStudent.Click += new System.EventHandler(this.buttonRemoveStudent_Click);
            // 
            // buttonEditStudent
            // 
            this.buttonEditStudent.Location = new System.Drawing.Point(1104, 353);
            this.buttonEditStudent.Name = "buttonEditStudent";
            this.buttonEditStudent.Size = new System.Drawing.Size(188, 80);
            this.buttonEditStudent.TabIndex = 3;
            this.buttonEditStudent.Text = "Edit Student";
            this.buttonEditStudent.UseVisualStyleBackColor = true;
            this.buttonEditStudent.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 473);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 344);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FMstudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1352, 839);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEditStudent);
            this.Controls.Add(this.buttonRemoveStudent);
            this.Controls.Add(this.buttonNewStudent);
            this.Controls.Add(this.groupBoxStudentInfo);
            this.Location = new System.Drawing.Point(228, 162);
            this.MaximizeBox = false;
            this.Name = "FMstudentInfo";
            this.Text = "FMstudentInfo";
            this.Load += new System.EventHandler(this.FMstudentInfo_Load);
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            this.groupBoxEnroll.ResumeLayout(false);
            this.groupBoxEnroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudentInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textStudentID;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxEnroll;
        private System.Windows.Forms.RadioButton radioButtonType2;
        private System.Windows.Forms.RadioButton radioButtonType;
        private System.Windows.Forms.Button buttonNewStudent;
        private System.Windows.Forms.Button buttonRemoveStudent;
        private System.Windows.Forms.Button buttonEditStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}