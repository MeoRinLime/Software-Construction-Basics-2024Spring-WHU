using System;
class Person {
  private string myName ="N/A";
  public string Name {
    get { return myName; }
    set { myName = value; }
  }

  public int Age { get; set; }

  public string Info {
    get {
      return "Name:" + Name + ",Age:" + Age;
    }
  }

  public string Info2 {
    get => "Name:" + Name + ",Age:" + Age;
  }

  public static void Main() {
    Person person = new Person();
    person.Age = 20;
    person.Name = "Jia";
    //person.Info = "nobody"; //编译错误

    Console.WriteLine(person.Info);
    person.Age += 1;
    Console.WriteLine(person.Info); 

    //在创建对象时初始化属性
    Person person2 = new Person() {
      Name = "Joe",
      Age = 99
    };

  }
}
