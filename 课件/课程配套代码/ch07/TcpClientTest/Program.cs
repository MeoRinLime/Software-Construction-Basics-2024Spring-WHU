using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.声明一个客户端
            TcpClient tcpClient = new TcpClient("127.0.0.1", 7788);
            //2.声明一个流用来读写数据
            NetworkStream stream = tcpClient.GetStream();
            string message = Console.ReadLine();
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
            //3.关闭相应的东西
            stream.Close();
            tcpClient.Close();
            Console.ReadKey();
            
        }
    }
}
