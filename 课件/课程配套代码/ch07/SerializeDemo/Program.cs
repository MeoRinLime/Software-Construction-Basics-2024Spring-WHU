using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializeDemo {
  class Program {

 
    static void Main(string[] args) {
      List<Person> persons =new List<Person> { new Person("zhang",23), new Person("wang",22) };
      Console.WriteLine("original array object:");
      persons.ForEach(p => Console.WriteLine(p));


      Console.WriteLine("serialized into s.temp.");
      BinaryFormatter binFormatter = new BinaryFormatter();
      using (FileStream fs = new FileStream("s.temp", FileMode.Create)) {
        binFormatter.Serialize(fs, persons);
      }

      using (FileStream fs = new FileStream("s.temp", FileMode.Open)) {
        List<Person> persons2 = (List<Person>)binFormatter.Deserialize(fs);
        Console.WriteLine("Deserialized from s.temp");
        persons2.ForEach(p => Console.WriteLine(p));
      }
      

      XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
      using (FileStream fs = new FileStream("s.xml", FileMode.Create)) {
        xmlSerializer.Serialize(fs, persons);
      }

      Console.WriteLine("\nSerialized as XML:");
      Console.WriteLine(File.ReadAllText("s.xml"));

      using (FileStream fs = new FileStream("s.xml", FileMode.Open)) {
        List<Person> persons3 = (List<Person>)xmlSerializer.Deserialize(fs);
        Console.WriteLine("\nDeserialized from s.xml");
        persons3.ForEach(p => Console.WriteLine(p));
      }

    }
  }
}
