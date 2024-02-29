using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncUseEvent {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      WebClient client = new WebClient();
      client.Encoding = Encoding.UTF8;
      client.DownloadStringCompleted += DownloadCompleted;
      client.DownloadStringAsync(new Uri(textBox1.Text));
      label1.Text = "Downloading...";
    }


    private void DownloadCompleted(Object sender,
       DownloadStringCompletedEventArgs e) {
      label1.Text = "download completed！";
      if (!e.Cancelled && e.Error == null) {
        richTextBox1.Text = (String)e.Result;
      }else {
        richTextBox1.Text = "" + e.Error;
      }
    }
  }

}
