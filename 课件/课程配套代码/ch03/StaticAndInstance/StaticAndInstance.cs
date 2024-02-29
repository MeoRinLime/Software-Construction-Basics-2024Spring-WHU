class Test{
	int x;
	static int y;

	static void Method1() {
		//x = 1;			// 错误，在静态方法中不能直接访问非静态成员
		y = 1;			// Ok，相当于 Test.y = 1
	}

  void Method2() {
    x = 1;      // Ok，相当于 this.x = 1
    y = 1;      // Ok，相当于 Test.y = 1
  }


  static void Main() {
		Test t = new Test();
		t.x = 1;		// Ok
		//t.y = 1;		// 错误，不能用对象名访问static成员
		//Test.x = 1;		// 错误，不能用类名访问实例成员
		Test.y = 1;		// Ok
    Test.Method1();
    t.Method2();
	}
}
