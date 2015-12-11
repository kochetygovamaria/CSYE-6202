namespace FinalProject
{
    partial class UpdateDoctor
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(347, 402);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(209, 31);
            this.textTitle.TabIndex = 47;
            // 
            // healthProvider
            // 
            this.healthProvider.AutoSize = true;
            this.healthProvider.Location = new System.Drawing.Point(181, 405);
            this.healthProvider.Name = "healthProvider";
            this.healthProvider.Size = new System.Drawing.Size(53, 25);
            this.healthProvider.TabIndex = 46;
            this.healthProvider.Text = "Title";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(347, 342);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(208, 31);
            this.textID.TabIndex = 45;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(347, 270);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(209, 31);
            this.textLastName.TabIndex = 44;
            // 
            // textNameF
            // 
            this.textNameF.Location = new System.Drawing.Point(347, 196);
            this.textNameF.Name = "textNameF";
            this.textNameF.Size = new System.Drawing.Size(214, 31);
            this.textNameF.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = " ID";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(181, 270);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(115, 25);
            this.lastName.TabIndex = 41;
            this.lastName.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(181, 199);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(116, 25);
            this.firstName.TabIndex = 40;
            this.firstName.Text = "First Name";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(283, 471);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(217, 74);
            this.buttonUpdate.TabIndex = 48;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UpdateDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 629);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.healthProvider);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textNameF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "UpdateDoctor";
            this.Text = "UpdateDoctor";
            this.Load += new System.EventHandler(this.UpdateDoctor_Load);
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
        private System.Windows.Forms.Button buttonUpdate;
    }
}