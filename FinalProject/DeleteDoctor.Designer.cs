namespace FinalProject
{
    partial class DeleteDoctor
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
            this.textTitle = new System.Windows.Forms.TextBox();
            this.healthProvider = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textNameF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(429, 411);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(209, 31);
            this.textTitle.TabIndex = 39;
            // 
            // healthProvider
            // 
            this.healthProvider.AutoSize = true;
            this.healthProvider.Location = new System.Drawing.Point(263, 414);
            this.healthProvider.Name = "healthProvider";
            this.healthProvider.Size = new System.Drawing.Size(53, 25);
            this.healthProvider.TabIndex = 38;
            this.healthProvider.Text = "Title";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(429, 351);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(208, 31);
            this.textID.TabIndex = 37;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(429, 279);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(209, 31);
            this.textLastName.TabIndex = 36;
            // 
            // textNameF
            // 
            this.textNameF.Location = new System.Drawing.Point(429, 205);
            this.textNameF.Name = "textNameF";
            this.textNameF.Size = new System.Drawing.Size(214, 31);
            this.textNameF.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = " ID";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(263, 279);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(115, 25);
            this.lastName.TabIndex = 33;
            this.lastName.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(263, 208);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(116, 25);
            this.firstName.TabIndex = 32;
            this.firstName.Text = "First Name";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(377, 507);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(217, 69);
            this.DeleteButton.TabIndex = 40;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 647);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.healthProvider);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textNameF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "DeleteDoctor";
            this.Text = "DeleteDoctor";
            this.Load += new System.EventHandler(this.DeleteDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label healthProvider;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textNameF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button DeleteButton;
    }
}