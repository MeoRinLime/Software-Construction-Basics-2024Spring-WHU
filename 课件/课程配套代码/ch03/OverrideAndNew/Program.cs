﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideAndNew {
  class Program {
    static void Main(string[] args) {
      BaseClass bc = new BaseClass();
      DerivedClass dc = new DerivedClass();
      BaseClass bcdc = new DerivedClass();

      // The following two calls invoke the methods that are defined in BaseClass.  
      bc.Method1();// Output:  Base - Method1  
      bc.Method2();// Output:  Base - Method2  

      // The following two calls invoke the methods that are defined in DerivedClass.  
      dc.Method1();// Output:  Derived - Method1 
      dc.Method2();// Output:  Derived - Method2  

      // The following two calls produce different results, depending   
      // on whether override (Method1) or new (Method2) is used.  
      bcdc.Method1();// Output:  Derived - Method1  
      bcdc.Method2();// Output:  Base - Method2  
    }
  }

  class BaseClass {

    public virtual void Method1() {
      Console.WriteLine("Base - Method1");
    }

    public virtual void Method2() {
      Console.WriteLine("Base - Method2");
    }
  }

  class DerivedClass : BaseClass {

    public override void Method1() {
      Console.WriteLine("Derived - Method1");
    }

    public new void Method2() {
      Console.WriteLine("Derived - Method2");
    }
  }


}
