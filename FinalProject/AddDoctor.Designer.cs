namespace FinalProject
{
    partial class AddDoctor
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
            this.buttonResert = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.healthProvider = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textNameF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonResert
            // 
            this.buttonResert.Location = new System.Drawing.Point(566, 213);
            this.buttonResert.Name = "buttonResert";
            this.buttonResert.Size = new System.Drawing.Size(170, 80);
            this.buttonResert.TabIndex = 27;
            this.buttonResert.Text = "Resert";
            this.buttonResert.UseVisualStyleBackColor = true;
            this.buttonResert.Click += new System.EventHandler(this.buttonResert_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(566, 78);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 80);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(219, 298);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(209, 31);
            this.textTitle.TabIndex = 23;
            this.textTitle.TextChanged += new System.EventHandler(this.textIncuranceName_TextChanged);
            // 
            // healthProvider
            // 
            this.healthProvider.AutoSize = true;
            this.healthProvider.Location = new System.Drawing.Point(53, 301);
            this.healthProvider.Name = "healthProvider";
            this.healthProvider.Size = new System.Drawing.Size(53, 25);
            this.healthProvider.TabIndex = 20;
            this.healthProvider.Text = "Title";
            this.healthProvider.Click += new System.EventHandler(this.healthProvider_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(219, 238);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(208, 31);
            this.textID.TabIndex = 19;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(219, 166);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(209, 31);
            this.textLastName.TabIndex = 18;
            this.textLastName.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
            // 
            // textNameF
            // 
            this.textNameF.Location = new System.Drawing.Point(219, 92);
            this.textNameF.Name = "textNameF";
            this.textNameF.Size = new System.Drawing.Size(214, 31);
            this.textNameF.TabIndex = 17;
            this.textNameF.TextChanged += new System.EventHandler(this.textNameF_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = " ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(53, 166);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(115, 25);
            this.lastName.TabIndex = 15;
            this.lastName.Text = "Last Name";
            this.lastName.Click += new System.EventHandler(this.lastName_Click);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(53, 95);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(116, 25);
            this.firstName.TabIndex = 14;
            this.firstName.Text = "First Name";
            this.firstName.Click += new System.EventHandler(this.firstName_Click);
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 567);
            this.Controls.Add(this.buttonResert);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.healthProvider);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textNameF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "AddDoctor";
            this.Text = "AddDoctor";
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResert;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label healthProvider;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textNameF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
    }
}