using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void btnShowDialog_Click(object sender, EventArgs e) {
      new Form2().ShowDialog();
    }

    private void btnShowForm_Click(object sender, EventArgs e) {
      new Form2().Show();
    }

    private void btnShowWithParam_Click(object sender, EventArgs e) {
      new Form2(textBox1.Text).Show();
    }

    private void btnSetProperties_Click(object sender, EventArgs e) {
      Form2 form2 = new Form2();
      form2.Greeting = textBox1.Text;
      form2.ShowDialog();
    }

    private void btnShowFormInPanel_Click(object sender, EventArgs e) {
      Form2 form2 = new Form2();
      form2.TopLevel = false;
      form2.FormBorderStyle = FormBorderStyle.None;
      form2.Dock = DockStyle.Fill;
      form2.Visible = true;
      this.mainPanel.Controls.Add(form2);
    }
  }
}
