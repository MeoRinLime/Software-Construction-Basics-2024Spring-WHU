using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelInvoke {
  class Program {
    static void Main(string[] args) {

      Stopwatch sw = new Stopwatch();
      sw.Start();
      Parallel.Invoke(new Action[]{
                    ()=> DoSometing(1),
                    ()=> DoSometing(2)});
      sw.Stop();
      Console.WriteLine($"持续时间：{sw.ElapsedMilliseconds}");

    }

    static void DoSometing(int num) {
      for(int i = 0; i < 10; i++) {
        Console.WriteLine($"第{num}个任务：{i}");
        Thread.Sleep(200);
      }
    }
  }
}
