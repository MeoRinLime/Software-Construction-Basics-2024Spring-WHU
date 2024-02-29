using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpServer
{
    class WorkerThreadHandler
    {
        public TcpListener tcpListener;

        public WorkerThreadHandler(TcpListener tcpListener)
        {
            this.tcpListener = tcpListener;
        }

        public void HandleThread()
        {
            Socket socket = tcpListener.AcceptSocket();






        }

    }
}
