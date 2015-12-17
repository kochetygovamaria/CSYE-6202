namespace FinalProject
{
    partial class AddReason
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
            this.addReasonBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reason Name";
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(373, 158);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(168, 31);
            this.Price_txt.TabIndex = 6;
            // 
            // ReasonName
            // 
            this.ReasonName.Location = new System.Drawing.Point(373, 105);
            this.ReasonName.Name = "ReasonName";
            this.ReasonName.Size = new System.Drawing.Size(168, 31);
            this.ReasonName.TabIndex = 5;
            // 
            // addReasonBTN
            // 
            this.addReasonBTN.Location = new System.Drawing.Point(269, 280);
            this.addReasonBTN.Name = "addReasonBTN";
            this.addReasonBTN.Size = new System.Drawing.Size(272, 72);
            this.addReasonBTN.TabIndex = 9;
            this.addReasonBTN.Text = "Add";
            this.addReasonBTN.UseVisualStyleBackColor = true;
            this.addReasonBTN.Click += new System.EventHandler(this.addReasonBTN_Click);
            // 
            // AddReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 471);
            this.Controls.Add(this.addReasonBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.ReasonName);
            this.Name = "AddReason";
            this.Text = "AddReason";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.TextBox ReasonName;
        private System.Windows.Forms.Button addReasonBTN;
    }
}