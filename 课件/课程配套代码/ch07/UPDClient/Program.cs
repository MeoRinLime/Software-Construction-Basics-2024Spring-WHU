using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UPDSender {
  class Program {
    static void Main(string[] args) {
      IPEndPoint senderIp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6000);
      IPEndPoint reciverIp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6001);

      using (UdpClient sender = new UdpClient(senderIp)) {
        string message = "";
        do {
          message = Console.ReadLine();
          byte[] sendbytes = Encoding.UTF8.GetBytes(message);
          sender.Send(sendbytes, sendbytes.Length, reciverIp);
        } while (message != "q");
      }
    }
  }
}
