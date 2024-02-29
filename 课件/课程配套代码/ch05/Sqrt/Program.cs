﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine(Newton(2.0));
      Console.WriteLine(Math.Sqrt(2.0));
    }

    // 求   
    static double Newton(double a) {
      double x1 = 1.0;
      double x2 = NextValue(x1, a);
      while (Math.Abs(x2 - x1) > 1e-6) {
        x1 = x2;
        x2 = NextValue(x1, a);
      }
      return x2;
    }

    private static double NextValue(double x, double a) {
      return x - (x * x - a) / (2 * x);
    }
  }
}
