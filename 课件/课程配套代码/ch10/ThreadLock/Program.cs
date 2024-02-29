using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLock {
  class Program {
    static void Main(string[] args) {
      Num num = new Num();
      Thread thread1 = new Thread(num.Run);
      Thread thread2 = new Thread(num.Run);
      thread1.Start();
      thread2.Start();
      for (int i = 0; i < 10; i++) {
        Thread.Sleep(10);
        num.TestEquals();
      }
    }
  }

  class Num {
    long x = 0; long y = 0;
    public void Run() {
      while (true) {
        lock (this) {//为当前对象加锁
          x++;
          y++;
        }
      }
    }

    public void TestEquals() {
      lock (this) {//为当前对象加锁
        Console.WriteLine($"x={x},y={y},{x == y}");
      }
    }
  }
}
