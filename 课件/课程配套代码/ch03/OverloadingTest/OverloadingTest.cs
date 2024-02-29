using System;
class OverloadingTest
{
	static void Foo() {
		Console.WriteLine("Foo()");
	}

  static void Foo(int value) {
    Console.WriteLine("Foo(int)");
  }

  static void Foo(int a, int b) {
    Console.WriteLine("Foo(int, int)");
  }

  static void Foo(int[] values) {
    Console.WriteLine("Foo(int[])");
  }

  static void Foo(object o) {
		Console.WriteLine("Foo(object)");
	}
	

	static void Main() {
		Foo();  //output: Foo()
    Foo(1);  //output: Foo(int)
    Foo(1, 2);//output: Foo(int, int)
    Foo(new int[] { 1, 2, 3 });//output: Foo(int[])
    object n=10;//output: Foo(object)
    Foo(n);//output: Foo(object)
    Foo("string");//output: Foo(object)
    Foo(new Double[] { 1.2, 2.0 });//output: Foo(object)

  }
}
