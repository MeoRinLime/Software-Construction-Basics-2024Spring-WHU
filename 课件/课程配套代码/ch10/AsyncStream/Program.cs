﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncStream {
  class Program {
    static void Main(string[] args) {
      WriteFile();
      Console.WriteLine("do otherthing.");
    }


    async static void WriteFile() {
      using (StreamWriter sw = new StreamWriter(
          new FileStream("aaa.txt", FileMode.Create))) {
        await sw.WriteAsync("My Text");
      }
     
    }
  }
}
