using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTest {
  class Program {
    static void Main(string[] args) {
      Task<double>[] tasks = {
                 Task.Run( ()=>SomeFun() ),
                 Task.Run( ()=>SomeFun() ),
            };
      for (int i = 0; i < tasks.Length; i++) {
        Console.WriteLine($"tasks[{i}].Status={tasks[i].Status}");  
      }
      for (int i = 0; i < tasks.Length; i++) {
        //等到计算结束取结果
        Console.WriteLine($"tasks[{i}].Result={tasks[i].Result}"); 
      }
      for (int i = 0; i < tasks.Length; i++) {
        Console.WriteLine($"tasks[{i}].Status={tasks[i].Status}");
      }
      //Task.WaitAll(tasks); //也可以用这句来等待结束
    }

    static double SomeFun() {
      Thread.Sleep(500);
      return DateTime.Now.Ticks;
    }
  }
}
