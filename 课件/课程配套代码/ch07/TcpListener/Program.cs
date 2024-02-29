using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpListenerServer {
  class Program {

    static void Main(string[] args) {
      //创建启动TCPListener
      TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 10000);
      listener.Start();

      using (TcpClient tcpClient = listener.AcceptTcpClient()) {
        Console.WriteLine($"接收到客户端连接");
        //使用NetworkStream读写数据
        using (NetworkStream stream = tcpClient.GetStream()) {
          string message = "";
          do {
            byte[] data = new byte[1024];
            int length = stream.Read(data, 0, 1024);
            message = Encoding.UTF8.GetString(data, 0, length);
            Console.WriteLine(message);
          } while (message != "q");
        }
      }
      listener.Stop();
    }
  }
}
