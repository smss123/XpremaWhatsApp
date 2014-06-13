namespace Xprema_Xaina.WhatsAppIDSender
{
    partial class frmWhatsAppIDSenderDelete
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IDSendersGridView = new System.Windows.Forms.DataGridView();
            this.SelectedForDeletelistBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDSendersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Look for?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectedForDeletelistBox);
            this.groupBox2.Controls.Add(this.IDSendersGridView);
            this.groupBox2.Location = new System.Drawing.Point(13, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // IDSendersGridView
            // 
            this.IDSendersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IDSendersGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.IDSendersGridView.Location = new System.Drawing.Point(3, 16);
            this.IDSendersGridView.Name = "IDSendersGridView";
            this.IDSendersGridView.Size = new System.Drawing.Size(300, 296);
            this.IDSendersGridView.TabIndex = 0;
            // 
            // SelectedForDeletelistBox
            // 
            this.SelectedForDeletelistBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SelectedForDeletelistBox.FormattingEnabled = true;
            this.SelectedForDeletelistBox.Location = new System.Drawing.Point(500, 16);
            this.SelectedForDeletelistBox.Name = "SelectedForDeletelistBox";
            this.SelectedForDeletelistBox.Size = new System.Drawing.Size(182, 296);
            this.SelectedForDeletelistBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 0;
            // 
            // frmWhatsAppIDSenderDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(713, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(729, 454);
            this.MinimumSize = new System.Drawing.Size(729, 454);
            this.Name = "frmWhatsAppIDSenderDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ID Sender Delete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDSendersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox SelectedForDeletelistBox;
        private System.Windows.Forms.DataGridView IDSendersGridView;
        private System.Windows.Forms.TextBox textBox1;
    }
}