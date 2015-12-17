namespace FinalProject
{
    partial class ListOfReasons
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
            this.datagrid_Reasons = new System.Windows.Forms.DataGridView();
            this.ReasonName = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addReason = new System.Windows.Forms.Button();
            this.DeleteReason = new System.Windows.Forms.Button();
            this.UpdateReason = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Reasons)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_Reasons
            // 
            this.datagrid_Reasons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Reasons.Location = new System.Drawing.Point(71, 326);
            this.datagrid_Reasons.Name = "datagrid_Reasons";
            this.datagrid_Reasons.RowTemplate.Height = 33;
            this.datagrid_Reasons.Size = new System.Drawing.Size(424, 240);
            this.datagrid_Reasons.TabIndex = 0;
            this.datagrid_Reasons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.datagrid_Reasons.SelectionChanged += new System.EventHandler(this.datagrid_Reasons_SelectionChanged);
            // 
            // ReasonName
            // 
            this.ReasonName.Enabled = false;
            this.ReasonName.Location = new System.Drawing.Point(303, 124);
            this.ReasonName.Name = "ReasonName";
            this.ReasonName.Size = new System.Drawing.Size(168, 31);
            this.ReasonName.TabIndex = 1;
            // 
            // Price_txt
            // 
            this.Price_txt.Enabled = false;
            this.Price_txt.Location = new System.Drawing.Point(303, 177);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(168, 31);
            this.Price_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reason Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // addReason
            // 
            this.addReason.Location = new System.Drawing.Point(679, 2);
            this.addReason.Name = "addReason";
            this.addReason.Size = new System.Drawing.Size(168, 66);
            this.addReason.TabIndex = 6;
            this.addReason.Text = "Add Reason";
            this.addReason.UseVisualStyleBackColor = true;
            this.addReason.Click += new System.EventHandler(this.addReason_Click);
            // 
            // DeleteReason
            // 
            this.DeleteReason.Location = new System.Drawing.Point(679, 74);
            this.DeleteReason.Name = "DeleteReason";
            this.DeleteReason.Size = new System.Drawing.Size(168, 66);
            this.DeleteReason.TabIndex = 7;
            this.DeleteReason.Text = "Delete";
            this.DeleteReason.UseVisualStyleBackColor = true;
            this.DeleteReason.Click += new System.EventHandler(this.DeleteReason_Click);
            // 
            // UpdateReason
            // 
            this.UpdateReason.Location = new System.Drawing.Point(679, 146);
            this.UpdateReason.Name = "UpdateReason";
            this.UpdateReason.Size = new System.Drawing.Size(168, 66);
            this.UpdateReason.TabIndex = 8;
            this.UpdateReason.Text = "Update";
            this.UpdateReason.UseVisualStyleBackColor = true;
            this.UpdateReason.Click += new System.EventHandler(this.UpdateReason_Click);
            // 
            // ListOfReasons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 633);
            this.Controls.Add(this.UpdateReason);
            this.Controls.Add(this.DeleteReason);
            this.Controls.Add(this.addReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.ReasonName);
            this.Controls.Add(this.datagrid_Reasons);
            this.Name = "ListOfReasons";
            this.Text = "ListOfReasons";
            this.Load += new System.EventHandler(this.ListOfReasons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Reasons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_Reasons;
        private System.Windows.Forms.TextBox ReasonName;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addReason;
        private System.Windows.Forms.Button DeleteReason;
        private System.Windows.Forms.Button UpdateReason;
    }
}