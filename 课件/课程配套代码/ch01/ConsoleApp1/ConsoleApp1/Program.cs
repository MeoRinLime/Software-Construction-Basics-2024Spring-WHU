using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            double d = 0;
            Console.Write("Please input an integer number: ");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.Write("Please input a double number: ");
            s = Console.ReadLine();
            d = Double.Parse(s);
          
            Console.WriteLine("n: {0} ,d: {1}", n, d);
            Console.WriteLine($"n: {n} ,d: {d}");
            Console.WriteLine($"n+d: {n+d} ");
        }
    }
}
