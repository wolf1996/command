namespace Terminal
{
    partial class Form3
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_test_received = new System.Windows.Forms.RichTextBox();
            this.rtb_test_send = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Получено";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Отправлено";
            // 
            // rtb_test_received
            // 
            this.rtb_test_received.Location = new System.Drawing.Point(367, 128);
            this.rtb_test_received.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_test_received.Name = "rtb_test_received";
            this.rtb_test_received.ReadOnly = true;
            this.rtb_test_received.Size = new System.Drawing.Size(244, 275);
            this.rtb_test_received.TabIndex = 13;
            this.rtb_test_received.Text = "";
            // 
            // rtb_test_send
            // 
            this.rtb_test_send.Location = new System.Drawing.Point(112, 128);
            this.rtb_test_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_test_send.Name = "rtb_test_send";
            this.rtb_test_send.ReadOnly = true;
            this.rtb_test_send.Size = new System.Drawing.Size(244, 275);
            this.rtb_test_send.TabIndex = 12;
            this.rtb_test_send.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 507);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtb_test_received);
            this.Controls.Add(this.rtb_test_send);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_test_received;
        private System.Windows.Forms.RichTextBox rtb_test_send;
    }
}