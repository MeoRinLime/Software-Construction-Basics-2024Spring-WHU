using System;
class ClassA {

  protected int b = 20;
  public int a = 10;
  
  public void Method1() {
    a++;
    Console.WriteLine("ClassA.Method1:"+a);
  }
  public virtual void Method2() {
    Console.WriteLine("ClassA.Method2:"+a);
  }
}
class ClassB : ClassA {

  new public int a = 20;
  
  new public void Method1() {
    a++;
    Console.WriteLine("ClassB.Method1:" + a);
  }

  public override void Method2() {
    Console.WriteLine("ClassB.Method2:"+a);
  }

  static void Main() {
    ClassB y = new ClassB();
    Console.WriteLine(y.a); //œ‘ æ20
    y.Method1(); //ClassB.Method1
    y.Method2();//ClassB.Method2


    ClassA x = new ClassB();
    Console.WriteLine(x.a); //œ‘ æ10
    x.Method1(); //ClassA.Method1
    x.Method2(); //ClassB.Method2 
  }
}
