using System;
class Person {
  string name;
  int age;

  Person(string name, int a) {
    this.name = name;
    this.age = a;
  }

  Person(string n) {
    name = n;
    age = -1;
  }

  Person() : this("", -1) {
  }

  public void ShowInfo() {
    Console.WriteLine($"name:{name} \t age:{age}");
  }

  public void SayHello(Person another) {
    Console.WriteLine($"hello,{another.name}, my name is {name} ");
  }

  //public void SayHello(Person another2) { }  //ERROR

  //public string SayHello(Person another2) { return "";}  //ERROR

  public static void Main(string[] args) {
    Person person1 = new Person();
    Person person2 = new Person("Li",20);
    Person person3 = new Person("Zhang");
    person1.ShowInfo();
    person2.ShowInfo();
    person3.ShowInfo();
  }
}
