namespace ListView {
  partial class Form1 {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    System.Windows.Forms.ListBox listBox1;
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
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.ItemHeight = 12;
      this.listBox1.Items.AddRange(new object[] {
            "LargeIcon",
            "SmallIcon",
            "Report",
            "List"});
      this.listBox1.Location = new System.Drawing.Point(118, 21);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(142, 88);
      this.listBox1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
      this.ClientSize = new System.Drawing.Size(272, 165);
      this.Controls.Add(this.listBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView listView1;
  }
}

