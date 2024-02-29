using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass {
  abstract class BaseClass   // Abstract class
 {
    protected int x = 100;
    protected int y = 150;
    public abstract void AbstractMethod();   // Abstract method
    public abstract int X { get; }  // Abstract property
    public abstract int Y { get; }  // Abstract property
  }

  class DerivedClass : BaseClass {
    public override void AbstractMethod() {
      x++;
      y++;
    }

    public override int X   // overriding property
    {
      get => x + 10;
    }

    public override int Y   // overriding property
    {
      get => y + 10;
    }

    static void Main() {
      BaseClass o = new DerivedClass();
      o.AbstractMethod();
      Console.WriteLine($"x = {o.X}, y = {o.Y}");
      // Output: x = 111, y = 161
    }
  }

}
