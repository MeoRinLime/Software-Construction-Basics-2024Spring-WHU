﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControls {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      richTextBox1.LoadFile(@"C:\Users\jiaxy\source\repos\ch07\hello.rtf");
    }

    private void textBox2_TextChanged(object sender, EventArgs e) {

    }
  }
}
