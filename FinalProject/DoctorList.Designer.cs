namespace FinalProject
{
    partial class DoctorList
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
            this.AddDoctor = new System.Windows.Forms.Button();
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.healthProvider = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textNameF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDoctor
            // 
            this.AddDoctor.Location = new System.Drawing.Point(1, -1);
            this.AddDoctor.Name = "AddDoctor";
            this.AddDoctor.Size = new System.Drawing.Size(229, 73);
            this.AddDoctor.TabIndex = 0;
            this.AddDoctor.Text = "Add Doctor";
            this.AddDoctor.UseVisualStyleBackColor = true;
            this.AddDoctor.Click += new System.EventHandler(this.AddDoctor_Click);
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Location = new System.Drawing.Point(121, 398);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.Size = new System.Drawing.Size(734, 314);
            this.dataGridViewDoctor.TabIndex = 2;
            this.dataGridViewDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctor_CellContentClick);
            this.dataGridViewDoctor.SelectionChanged += new System.EventHandler(this.dataGridViewDoctor_CellContentClick);
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(427, 320);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(209, 31);
            this.textTitle.TabIndex = 31;
            // 
            // healthProvider
            // 
            this.healthProvider.AutoSize = true;
            this.healthProvider.Location = new System.Drawing.Point(261, 323);
            this.healthProvider.Name = "healthProvider";
            this.healthProvider.Size = new System.Drawing.Size(53, 25);
            this.healthProvider.TabIndex = 30;
            this.healthProvider.Text = "Title";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(427, 260);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(208, 31);
            this.textID.TabIndex = 29;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(427, 188);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(209, 31);
            this.textLastName.TabIndex = 28;
            // 
            // textNameF
            // 
            this.textNameF.Location = new System.Drawing.Point(427, 114);
            this.textNameF.Name = "textNameF";
            this.textNameF.Size = new System.Drawing.Size(214, 31);
            this.textNameF.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = " ID";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(261, 188);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(115, 25);
            this.lastName.TabIndex = 25;
            this.lastName.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(261, 117);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(116, 25);
            this.firstName.TabIndex = 24;
            this.firstName.Text = "First Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 73);
            this.button1.TabIndex = 33;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(225, -1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(177, 73);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Delete ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // DoctorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 757);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.healthProvider);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textNameF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.dataGridViewDoctor);
            this.Controls.Add(this.AddDoctor);
            this.Name = "DoctorList";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.DoctorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDoctor;
        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label healthProvider;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textNameF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}