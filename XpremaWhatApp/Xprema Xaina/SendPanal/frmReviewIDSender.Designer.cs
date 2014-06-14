namespace Xprema_Xaina.SendPanal
{
    partial class frmReviewIDSender
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblIDSenderCounter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSender,
            this.Checker});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(236, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // IDSender
            // 
            this.IDSender.FillWeight = 152.2843F;
            this.IDSender.HeaderText = "ID Sender";
            this.IDSender.Name = "IDSender";
            // 
            // Checker
            // 
            this.Checker.FillWeight = 47.71573F;
            this.Checker.HeaderText = "Status";
            this.Checker.Name = "Checker";
            // 
            // lblNumbers
            // 
            this.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumbers.Location = new System.Drawing.Point(364, 85);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(98, 20);
            this.lblNumbers.TabIndex = 2;
            this.lblNumbers.Text = "lbl lbl";
            // 
            // lblIDSenderCounter
            // 
            this.lblIDSenderCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDSenderCounter.Location = new System.Drawing.Point(364, 56);
            this.lblIDSenderCounter.Name = "lblIDSenderCounter";
            this.lblIDSenderCounter.Size = new System.Drawing.Size(98, 20);
            this.lblIDSenderCounter.TabIndex = 3;
            this.lblIDSenderCounter.Text = "lbl lbl";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(254, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tatal Reviewed";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(254, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Sender Counter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Review";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmReviewIDSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(761, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblIDSenderCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmReviewIDSender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review IDSender";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checker;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblIDSenderCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}