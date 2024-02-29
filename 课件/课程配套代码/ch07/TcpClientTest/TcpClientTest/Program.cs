using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpClientTest {
  class Program {
    static void Main(string[] args) {
      using (TcpClient tcpClient = new TcpClient("127.0.0.1", 10000)) {
        Console.WriteLine("连接服务器成功！请输入消息:");
        //使用流用来读写数据
        using (NetworkStream stream = tcpClient.GetStream()) {
          string message = null;
          do {
            message = Console.ReadLine();
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
          } while (message != "q");
        }
      }
    }
  }
}
