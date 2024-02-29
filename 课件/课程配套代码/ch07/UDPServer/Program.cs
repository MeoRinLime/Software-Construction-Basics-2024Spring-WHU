using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPReciver {
  class Program {

    static void Main(string[] args) {
      IPEndPoint localIp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6001);
      using (UdpClient reciver = new UdpClient(localIp)) {
        Console.WriteLine("服务端已经开启");
        string message = "";
        do {
          IPEndPoint point = new IPEndPoint(IPAddress.Any, 0);//发送方ip和端口号
          byte[] buffer = reciver.Receive(ref point);//接收数据报
          message = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
          Console.WriteLine(point.ToString() + ":" + message);
        } while (message != "q");
      }
    }
  }
}
