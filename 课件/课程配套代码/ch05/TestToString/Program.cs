using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestToString {
  class SimpleDate {
    protected int day, month, year;
    public SimpleDate(int i, int j, int k) {
      day = i;
      month = j;
      year = k;
    }
  }

  class OkDate : SimpleDate {
    public OkDate(int i, int j, int k)
        : base(i, j, k) { }
    public override string ToString() {
      return year + "-" + month + "-" + day;
    }
  }

  class Program {
    static void Main(string[] args) {
      SimpleDate m1 = new SimpleDate(24, 3, 2001);
      SimpleDate m2 = new OkDate(24, 3, 2001);
      Console.WriteLine(m1); //显示TestToString.SimpleDate
      Console.WriteLine(m2); //显示2001-3-24
    }
  }
}
