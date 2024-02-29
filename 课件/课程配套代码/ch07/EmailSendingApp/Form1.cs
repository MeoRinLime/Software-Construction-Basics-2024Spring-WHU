using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace EmailSendingApp {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void btnSend_Click(object sender, EventArgs e) {
      MailMessage message = new MailMessage();
      SmtpClient SmtpServer = new SmtpClient(txt_smtpserver.Text);
      message.From = new MailAddress(txtFrom.Text);
      message.To.Add(txtTo.Text);
      message.Subject = txtSubject.Text;
      message.Body = rtxMessage.Text;
      SmtpServer.Port = 25;
      SmtpServer.Credentials =new NetworkCredential(
            txtFrom.Text, txtPassword.Text);
      //SmtpServer.EnableSsl = true;
      SmtpServer.Send(message);
    }
  }
}
