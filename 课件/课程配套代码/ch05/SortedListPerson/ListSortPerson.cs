using System;
using System.Linq;
using System.Collections.Generic;
public class ListSortPerson {

  public class Person : IComparable {
    public string Name { set; get; }
    public bool Sex { set; get; }
    public int Age { set; get; }

    public Person(string name, bool sex, int age) {
      this.Name = name;
      this.Sex = sex;
      this.Age = age;
    }

    public int CompareTo(object obj2) {
      Person rec2 = obj2 as Person;
      if (rec2 == null)
        throw new System.ArgumentException();
      return this.Name.CompareTo(rec2.Name);
    }

    public override string ToString() {
      return "Name:" + Name + "\tSex:" + Sex + "\tAge:" + Age;
    }
  }

  public class AgeComparer : IComparer<Person> {
    public int Compare(Person p1, Person p2) {
      return p1.Age-p2.Age;
    }
  }


  public static void Main() {
    List<Person> persons = new List<Person>() {
            new Person( "Li ", true, 12 ),
            new Person( "Tang", false, 23 ),
            new Person( "Zhang", true, 18 ),
            new Person( "Chen", false, 37 ),
        };

    Console.WriteLine("original array:");
    persons.ForEach(p => Console.WriteLine(p));

    Console.WriteLine("sort(Icompable):");
    persons.Sort();
    persons.ForEach(p => Console.WriteLine(p));

    Console.WriteLine("sort by age (comparer):");
    persons.Sort(new AgeComparer());
    persons.ForEach(p => Console.WriteLine(p));

    Console.WriteLine("sort by age (lambda):");
    persons.Sort((p1, p2) => p1.Age - p2.Age);
    persons.ForEach(p => Console.WriteLine(p));

  }



}
