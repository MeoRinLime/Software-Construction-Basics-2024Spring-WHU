class Test{
	int x;
	static int y;

	static void Method1() {
		//x = 1;			// �����ھ�̬�����в���ֱ�ӷ��ʷǾ�̬��Ա
		y = 1;			// Ok���൱�� Test.y = 1
	}

  void Method2() {
    x = 1;      // Ok���൱�� this.x = 1
    y = 1;      // Ok���൱�� Test.y = 1
  }


  static void Main() {
		Test t = new Test();
		t.x = 1;		// Ok
		//t.y = 1;		// ���󣬲����ö���������static��Ա
		//Test.x = 1;		// ���󣬲�������������ʵ����Ա
		Test.y = 1;		// Ok
    Test.Method1();
    t.Method2();
	}
}
