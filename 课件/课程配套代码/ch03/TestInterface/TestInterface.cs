using System;

interface Flyable {
  void Fly();
}

interface Swimable {
  void Swim();
}

abstract class Animal {
  abstract public void Eat();
}

class Bird : Animal, Flyable {
  public override void Eat() {
    Console.WriteLine("a bird is eating");
  }

  public void Fly() {
    Console.WriteLine("a bird is flying");
  }
}

class Person : Animal, Swimable {
  public void Run() {
    Console.WriteLine("a person is running");
  }
  public void Swim() {
    Console.WriteLine("a person is swimming");
  }
  public override void Eat() {
    Console.WriteLine("a person is eating");
  }
}

class TestInterface {

  public static void Main(string[] args) {
    Person person = new Person();
    person.Eat();
    person.Swim();
    Bird bird = new Bird();
    bird.Eat();
    bird.Fly();
  }
}
