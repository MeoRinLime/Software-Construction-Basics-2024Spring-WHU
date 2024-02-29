using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Main()：invoke Test()");
      Task<double> task = new Program().Test();
      Console.WriteLine("Main()：waiting for result...");
      task.Wait();
      Console.WriteLine("Main()：the result is "+ task.Result);
      Console.ReadLine();
    }

    async Task<double> Test() {
      Console.WriteLine("\t\t\t\tTest():create a task");
      Task<double> task =Task.Run<double>(() => this.Calculate(100));
      Console.WriteLine("\t\t\t\tTest(): a task is await");
      double result = await task; //resume the Main Method
      Console.WriteLine("\t\t\t\tTest():the result is:" + result);
      return result; //return the task result
    }

    double Calculate(int n) {
      double s = 1;
      for (int i = 1; i < n; i++) {
        s = s * i;
      }
      return s;
    }
  }
}
