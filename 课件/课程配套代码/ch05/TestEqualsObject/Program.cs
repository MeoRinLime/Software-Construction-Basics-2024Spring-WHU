using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEqualsObject {
  class SimpleDate {
    public int day, month, year;
    public SimpleDate(int i, int j, int k) {
      day = i;
      month = j;
      year = k;
    }


  }

  class OkDate : SimpleDate {
    public OkDate(int i, int j, int k)
    : base(i, j, k) {
    }

    public override bool Equals(object obj) {
      OkDate m = obj as OkDate;
      return m != null && m.day == day 
        && m.month == month && m.year == year;
    }

    public override int GetHashCode() {
      return year * 366 + month * 31 + day;
    }

  }

  class Program {
    static void Main(string[] args) {
      SimpleDate m1 = new SimpleDate(24, 3, 2001);
      SimpleDate m2 = new SimpleDate(24, 3, 2001);
      SimpleDate m3 = m2;
      Console.WriteLine(m1 == m2); //不相等,显示false
      Console.WriteLine(m3 == m2);
      Console.WriteLine(m1.Equals(m2)); //不相等,显示false
      Console.WriteLine(m3.Equals(m2));
      m1 = new OkDate(24, 3, 2001);
      m2 = new OkDate(24, 3, 2001);
      Console.WriteLine(m1.Equals(m2)); //相等,显示true
    }
  }
}
