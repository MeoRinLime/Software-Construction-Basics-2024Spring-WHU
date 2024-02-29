namespace MDIApp
{
    partial class MainForm
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newSubFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.HorizonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.VerticalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗口ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 窗口ToolStripMenuItem
      // 
      this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSubFormMenuItem,
            this.CascadeMenuItem,
            this.HorizonMenuItem,
            this.VerticalMenuItem});
      this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
      this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
      this.窗口ToolStripMenuItem.Text = "窗口";
      // 
      // newSubFormMenuItem
      // 
      this.newSubFormMenuItem.Name = "newSubFormMenuItem";
      this.newSubFormMenuItem.Size = new System.Drawing.Size(216, 26);
      this.newSubFormMenuItem.Text = "新建子窗口";
      this.newSubFormMenuItem.Click += new System.EventHandler(this.newSubFormMenuItem_Click);
      // 
      // CascadeMenuItem
      // 
      this.CascadeMenuItem.Name = "CascadeMenuItem";
      this.CascadeMenuItem.Size = new System.Drawing.Size(216, 26);
      this.CascadeMenuItem.Text = "层叠窗口";
      this.CascadeMenuItem.Click += new System.EventHandler(this.CascadeMenuItem_Click);
      // 
      // HorizonMenuItem
      // 
      this.HorizonMenuItem.Name = "HorizonMenuItem";
      this.HorizonMenuItem.Size = new System.Drawing.Size(216, 26);
      this.HorizonMenuItem.Text = "水平平铺";
      this.HorizonMenuItem.Click += new System.EventHandler(this.HorizonMenuItem_Click);
      // 
      // VerticalMenuItem
      // 
      this.VerticalMenuItem.Name = "VerticalMenuItem";
      this.VerticalMenuItem.Size = new System.Drawing.Size(216, 26);
      this.VerticalMenuItem.Text = "垂直平铺";
      this.VerticalMenuItem.Click += new System.EventHandler(this.VerticalMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 562);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSubFormMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HorizonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerticalMenuItem;
    }
}

