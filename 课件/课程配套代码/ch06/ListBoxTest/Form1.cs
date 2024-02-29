﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxTest {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, System.EventArgs e) {
      this.listBox1.SelectionMode = SelectionMode.One;
      this.listBox2.SelectionMode = SelectionMode.MultiSimple;

      this.listBox1.Items.AddRange(new string[] {     new string( 'a', 8 ),
                                                            new string( 'b', 8 ),
                                                            new string( 'c', 8 ),
                                                            new string( 'd', 8 ),});

      this.listBox2.Items.AddRange(new string[] {
                                                            new string( '1', 6 ),
                                                            new string( '2', 6 ),
                                                            new string( '3', 6 ),
                                                            new string( '4', 6 ),});


    }

    private void button1_Click(object sender, System.EventArgs e) {
      object obj = listBox1.SelectedItem;
      if (obj != null) {
        listBox2.Items.Add(obj);
        listBox1.Items.Remove(obj);
      }
    }

    private void button2_Click(object sender, System.EventArgs e) {
      ListBox.SelectedObjectCollection objs = listBox2.SelectedItems;
      listBox1.BeginUpdate();
      foreach (object obj in objs) {
        listBox1.Items.Add(obj);
      }
      this.listBox1.EndUpdate();

      ListBox.SelectedIndexCollection ids = listBox2.SelectedIndices;
      listBox2.BeginUpdate();
      for (int i = ids.Count - 1; i >= 0; i--) {
        listBox2.Items.RemoveAt(ids[i]);
      }
      listBox2.EndUpdate();
    }

  }
}
