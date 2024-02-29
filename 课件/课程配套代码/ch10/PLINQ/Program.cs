using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ {
  class Program {
    static void Main(string[] args) {
      var source = Enumerable.Range(100, 50000);
      Stopwatch sw1 = new Stopwatch();
      sw1.Start();
      //普通LINQ
      var query = from num in source
                  where num % 10 == 0
                  select num;
      foreach (int i in query) Console.WriteLine(i);
      sw1.Stop();

      Stopwatch sw2 = new Stopwatch();
      sw2.Start();
      //PLINQ
      var parallelQuery = from num in source.AsParallel()
                          where num % 10 == 0
                          select num;
      parallelQuery.ForAll(i=>Console.WriteLine(i));
      sw2.Stop();

      Console.WriteLine("普通LINQ耗时："+sw1.ElapsedMilliseconds);
      Console.WriteLine("PLINQ耗时："+sw2.ElapsedMilliseconds);
    }
  }
}
