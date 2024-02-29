using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClone {
  public class BirthDay {
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    public BirthDay(int year, int month, int day) {
      Year = year; Month = month; Day = day;
    }

    public override string ToString() {
      return Year + "/" + Month + "/" + Day;
    }
  }

  public class Person {
    public int Id { get; set; }
    public string Name { get; set; }
    public BirthDay Birthday { get; set; }

    public Person ShallowClone() {
      return (Person)this.MemberwiseClone();
    }

    public Person DeepClone() {
      Person other = (Person)this.MemberwiseClone();
      other.Birthday = new BirthDay(
        Birthday.Year, Birthday.Month, Birthday.Day);
      return other;
    }

    public override string ToString() {
      return "{name:" + this.Name + ",age:" + this.Id + ",birthday:" + this.Birthday + "}";
    }
  }

  class Program {
    static void Main(string[] args) {
      Person p1 = new Person() {
        Id = 42,
        Name = "Sam",
        Birthday = new BirthDay(1999, 3, 19)
      };
      Console.WriteLine("  original p1:" + p1);
      TestDeepClone(p1);
      TestShallowClone(p1);
    }

    private static void TestDeepClone(Person p1) {
      Console.WriteLine(" DeepClone p1 as p2, then modify p2");
      Person p2 = p1.DeepClone();
      p2.Name = "George";
      p2.Id = 39;
      p2.Birthday.Year = 1998;
      Console.WriteLine("   p1:" + p1);
      Console.WriteLine("   p2:" + p2);
    }

    private static void TestShallowClone(Person p1) {
      Console.WriteLine(" ShallowClone p1 as p3, then modify p3");
      Person p3 = p1.ShallowClone();
      p3.Id = 32;
      p3.Name = "Frank";
      p3.Birthday.Year = 1998;
      Console.WriteLine("   p1: " + p1);
      Console.WriteLine("   p3:" + p3);
    }
  }

}
