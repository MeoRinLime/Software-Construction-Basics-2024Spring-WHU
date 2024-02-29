using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDemo
{
    [Serializable]
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person(String name,int age){
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return Name+"("+Age+")";
        }
    }
}
