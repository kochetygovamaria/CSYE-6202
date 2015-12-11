namespace FinalProject
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(-1, -2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 65);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = " Patient List";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonViewAppoimtnet
            // 
            this.buttonViewAppoimtnet.Location = new System.Drawing.Point(139, -2);
            this.buttonViewAppoimtnet.Name = "buttonViewAppoimtnet";
            this.buttonViewAppoimtnet.Size = new System.Drawing.Size(149, 65);
            this.buttonViewAppoimtnet.TabIndex = 3;
            this.buttonViewAppoimtnet.Text = "Appoimnets";
            this.buttonViewAppoimtnet.UseVisualStyleBackColor = true;
            this.buttonViewAppoimtnet.Click += new System.EventHandler(this.buttonViewAppoimtnet_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 577);
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
    }
}