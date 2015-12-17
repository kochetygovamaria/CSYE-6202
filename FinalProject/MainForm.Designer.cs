namespace FinalProject
{
    partial class MainForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonViewAppoimtnet = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(-5, 123);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(209, 65);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = " Patient List";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonViewAppoimtnet
            // 
            this.buttonViewAppoimtnet.Location = new System.Drawing.Point(307, 120);
            this.buttonViewAppoimtnet.Name = "buttonViewAppoimtnet";
            this.buttonViewAppoimtnet.Size = new System.Drawing.Size(197, 65);
            this.buttonViewAppoimtnet.TabIndex = 3;
            this.buttonViewAppoimtnet.Text = "Appoimnets";
            this.buttonViewAppoimtnet.UseVisualStyleBackColor = true;
            this.buttonViewAppoimtnet.Click += new System.EventHandler(this.buttonViewAppoimtnet_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(615, 123);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(197, 62);
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 577);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.buttonViewAppoimtnet);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form2";
            this.Text = "For2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonViewAppoimtnet;
        private System.Windows.Forms.Button logOutBtn;
    }
}