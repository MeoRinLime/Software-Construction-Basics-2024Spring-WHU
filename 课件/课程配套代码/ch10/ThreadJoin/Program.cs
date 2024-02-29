using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadJoin {
  public class ThreadJoin {
    public static void Main(string[] args) {
      Thread thread = new Thread(new Runner().run);
      thread.Start();

      thread.Join();//等待thread执行完

      for (int i = 0; i < 10; i++) {
        Console.WriteLine("主线程：" + i);
        Thread.Sleep(100);
      }
    }
  }

  class Runner {
    public void run() {
      for (int i = 0; i < 10; i++) {
        Console.WriteLine("Runner线程："+i);
        Thread.Sleep(100);
      }
    }
  }
}
