namespace EmailSendingApp
{
    partial class Form1
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtTo = new System.Windows.Forms.TextBox();
      this.txtFrom = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.rtxMessage = new System.Windows.Forms.RichTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.txtSubject = new System.Windows.Forms.TextBox();
      this.txt_smtpserver = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(73, 16);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "To";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(73, 61);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(162, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "From / your email";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(73, 101);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(98, 25);
      this.label3.TabIndex = 2;
      this.label3.Text = "Password";
      // 
      // txtTo
      // 
      this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtTo.Location = new System.Drawing.Point(243, 16);
      this.txtTo.Margin = new System.Windows.Forms.Padding(4);
      this.txtTo.Name = "txtTo";
      this.txtTo.Size = new System.Drawing.Size(405, 25);
      this.txtTo.TabIndex = 3;
      this.txtTo.Text = "jiaxiangyang@qq.com";
      // 
      // txtFrom
      // 
      this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFrom.Location = new System.Drawing.Point(243, 61);
      this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
      this.txtFrom.Name = "txtFrom";
      this.txtFrom.Size = new System.Drawing.Size(405, 25);
      this.txtFrom.TabIndex = 4;
      this.txtFrom.Text = "jiaxiangyang@163.com";
      // 
      // txtPassword
      // 
      this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPassword.Location = new System.Drawing.Point(243, 98);
      this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(405, 25);
      this.txtPassword.TabIndex = 5;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // rtxMessage
      // 
      this.rtxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rtxMessage.Location = new System.Drawing.Point(16, 252);
      this.rtxMessage.Margin = new System.Windows.Forms.Padding(4);
      this.rtxMessage.Name = "rtxMessage";
      this.rtxMessage.Size = new System.Drawing.Size(698, 183);
      this.rtxMessage.TabIndex = 6;
      this.rtxMessage.Text = "";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(16, 223);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(93, 25);
      this.label4.TabIndex = 7;
      this.label4.Text = "Message";
      // 
      // button1
      // 
      this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.button1.Location = new System.Drawing.Point(250, 458);
      this.button1.Margin = new System.Windows.Forms.Padding(4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(177, 38);
      this.button1.TabIndex = 8;
      this.button1.Text = "Send";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnSend_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(73, 177);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(78, 25);
      this.label5.TabIndex = 9;
      this.label5.Text = "Subject";
      // 
      // txtSubject
      // 
      this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSubject.Location = new System.Drawing.Point(243, 178);
      this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
      this.txtSubject.Name = "txtSubject";
      this.txtSubject.Size = new System.Drawing.Size(405, 25);
      this.txtSubject.TabIndex = 10;
      // 
      // txt_smtpserver
      // 
      this.txt_smtpserver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_smtpserver.Location = new System.Drawing.Point(243, 136);
      this.txt_smtpserver.Margin = new System.Windows.Forms.Padding(4);
      this.txt_smtpserver.Name = "txt_smtpserver";
      this.txt_smtpserver.Size = new System.Drawing.Size(405, 25);
      this.txt_smtpserver.TabIndex = 12;
      this.txt_smtpserver.Text = "smtp.163.com";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(73, 138);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(117, 25);
      this.label6.TabIndex = 11;
      this.label6.Text = "Smtp server";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(724, 548);
      this.Controls.Add(this.txt_smtpserver);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtSubject);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.rtxMessage);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtFrom);
      this.Controls.Add(this.txtTo);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.Text = "Mail Sender";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RichTextBox rtxMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txt_smtpserver;
        private System.Windows.Forms.Label label6;
    }
}

