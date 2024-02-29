namespace MultiForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.mainPanel = new System.Windows.Forms.Panel();
      this.btnShowFormInPanel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(55, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(105, 59);
      this.button1.TabIndex = 0;
      this.button1.Text = "打开模态窗口";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnShowDialog_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(193, 12);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(105, 59);
      this.button2.TabIndex = 1;
      this.button2.Text = "打开非模态窗口";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.btnShowForm_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(55, 97);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 21);
      this.textBox1.TabIndex = 2;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(188, 86);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(105, 41);
      this.button3.TabIndex = 3;
      this.button3.Text = "带参数打开窗口";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.btnShowWithParam_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(323, 86);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(170, 41);
      this.button4.TabIndex = 4;
      this.button4.Text = "打开窗口后设置属性";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.btnSetProperties_Click);
      // 
      // panelForSubForm
      // 
      this.mainPanel.Location = new System.Drawing.Point(33, 145);
      this.mainPanel.Name = "panelForSubForm";
      this.mainPanel.Size = new System.Drawing.Size(740, 283);
      this.mainPanel.TabIndex = 5;
      // 
      // btnShowFormInPanel
      // 
      this.btnShowFormInPanel.Location = new System.Drawing.Point(350, 12);
      this.btnShowFormInPanel.Name = "btnShowFormInPanel";
      this.btnShowFormInPanel.Size = new System.Drawing.Size(143, 58);
      this.btnShowFormInPanel.TabIndex = 6;
      this.btnShowFormInPanel.Text = "在Panel中显示窗体";
      this.btnShowFormInPanel.UseVisualStyleBackColor = true;
      this.btnShowFormInPanel.Click += new System.EventHandler(this.btnShowFormInPanel_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnShowFormInPanel);
      this.Controls.Add(this.mainPanel);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Panel mainPanel;
    private System.Windows.Forms.Button btnShowFormInPanel;
  }
}

