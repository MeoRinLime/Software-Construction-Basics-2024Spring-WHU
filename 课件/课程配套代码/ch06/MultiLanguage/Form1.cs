using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLanguage {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
      if (comboBox1.SelectedIndex == 0) {
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
      }else if(comboBox1.SelectedIndex == 1){
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
      }
      ApplyResource();
    }

    private void ApplyResource() {
      System.ComponentModel.ComponentResourceManager res = new ComponentResourceManager(typeof(Form1));
      foreach (Control ctl in this.Controls) {
        res.ApplyResources(ctl, ctl.Name);
      }
      this.ResumeLayout(false);
      this.PerformLayout();
      res.ApplyResources(this, "$this");
    }
  }
}
