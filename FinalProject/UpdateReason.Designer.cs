namespace FinalProject
{
    partial class UpdateReason
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.ReasonName = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reason Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(431, 307);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(168, 31);
            this.Price_txt.TabIndex = 10;
            this.Price_txt.TextChanged += new System.EventHandler(this.Price_txt_TextChanged);
            // 
            // ReasonName
            // 
            this.ReasonName.Enabled = false;
            this.ReasonName.Location = new System.Drawing.Point(431, 254);
            this.ReasonName.Name = "ReasonName";
            this.ReasonName.Size = new System.Drawing.Size(168, 31);
            this.ReasonName.TabIndex = 9;
            this.ReasonName.TextChanged += new System.EventHandler(this.ReasonName_TextChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(261, 388);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(338, 84);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // UpdateReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 593);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.ReasonName);
            this.Name = "UpdateReason";
            this.Text = "UpdateReason";
            this.Load += new System.EventHandler(this.UpdateReason_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.TextBox ReasonName;
        private System.Windows.Forms.Button updateBtn;
    }
}