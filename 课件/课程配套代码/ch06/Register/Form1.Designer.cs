namespace Register {
  partial class Form1 {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent() {
      this.txtUser = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.btnRegister = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.RadioGender1 = new System.Windows.Forms.RadioButton();
      this.RadioGender2 = new System.Windows.Forms.RadioButton();
      this.label5 = new System.Windows.Forms.Label();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label6 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.chk1 = new System.Windows.Forms.CheckBox();
      this.chkHabit2 = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtUser
      // 
      this.txtUser.Location = new System.Drawing.Point(155, 35);
      this.txtUser.Name = "txtUser";
      this.txtUser.Size = new System.Drawing.Size(223, 25);
      this.txtUser.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(84, 39);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "用户名";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(99, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "密码";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(155, 75);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(223, 25);
      this.txtPassword.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(99, 252);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "备注";
      // 
      // txtComment
      // 
      this.txtComment.Location = new System.Drawing.Point(155, 252);
      this.txtComment.MaxLength = 200;
      this.txtComment.Multiline = true;
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(223, 100);
      this.txtComment.TabIndex = 4;
      // 
      // btnRegister
      // 
      this.btnRegister.Location = new System.Drawing.Point(181, 386);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(110, 23);
      this.btnRegister.TabIndex = 6;
      this.btnRegister.Text = "注册(&R)";
      this.btnRegister.UseVisualStyleBackColor = true;
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(99, 119);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(37, 15);
      this.label4.TabIndex = 7;
      this.label4.Text = "性别";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.RadioGender2);
      this.panel1.Controls.Add(this.RadioGender1);
      this.panel1.Location = new System.Drawing.Point(155, 119);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(223, 31);
      this.panel1.TabIndex = 8;
      // 
      // RadioGender1
      // 
      this.RadioGender1.AutoSize = true;
      this.RadioGender1.Location = new System.Drawing.Point(13, 3);
      this.RadioGender1.Name = "RadioGender1";
      this.RadioGender1.Size = new System.Drawing.Size(43, 19);
      this.RadioGender1.TabIndex = 0;
      this.RadioGender1.TabStop = true;
      this.RadioGender1.Text = "男";
      this.RadioGender1.UseVisualStyleBackColor = true;
      // 
      // RadioGender2
      // 
      this.RadioGender2.AutoSize = true;
      this.RadioGender2.Location = new System.Drawing.Point(79, 3);
      this.RadioGender2.Name = "RadioGender2";
      this.RadioGender2.Size = new System.Drawing.Size(43, 19);
      this.RadioGender2.TabIndex = 9;
      this.RadioGender2.TabStop = true;
      this.RadioGender2.Text = "女";
      this.RadioGender2.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(105, 168);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(31, 15);
      this.label5.TabIndex = 9;
      this.label5.Text = "VIP";
      this.label5.Click += new System.EventHandler(this.label5_Click);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(79, 3);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(43, 19);
      this.radioButton1.TabIndex = 9;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "否";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(13, 3);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(43, 19);
      this.radioButton2.TabIndex = 0;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "是";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.radioButton1);
      this.panel2.Controls.Add(this.radioButton2);
      this.panel2.Location = new System.Drawing.Point(155, 163);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(223, 27);
      this.panel2.TabIndex = 10;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(99, 209);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(37, 15);
      this.label6.TabIndex = 11;
      this.label6.Text = "爱好";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.chkHabit2);
      this.panel3.Controls.Add(this.chk1);
      this.panel3.Location = new System.Drawing.Point(155, 209);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(223, 27);
      this.panel3.TabIndex = 11;
      // 
      // chk1
      // 
      this.chk1.AutoSize = true;
      this.chk1.Location = new System.Drawing.Point(13, 5);
      this.chk1.Name = "chk1";
      this.chk1.Size = new System.Drawing.Size(59, 19);
      this.chk1.TabIndex = 0;
      this.chk1.Text = "篮球";
      this.chk1.UseVisualStyleBackColor = true;
      // 
      // chkHabit2
      // 
      this.chkHabit2.AutoSize = true;
      this.chkHabit2.Location = new System.Drawing.Point(82, 4);
      this.chkHabit2.Name = "chkHabit2";
      this.chkHabit2.Size = new System.Drawing.Size(59, 19);
      this.chkHabit2.TabIndex = 1;
      this.chkHabit2.Text = "跳舞";
      this.chkHabit2.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(504, 447);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnRegister);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtUser);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtUser;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.RadioButton RadioGender1;
    private System.Windows.Forms.RadioButton RadioGender2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.CheckBox chk1;
    private System.Windows.Forms.CheckBox chkHabit2;
  }
}

