using System;
public class LeapYear {
  public static void Main() {
    int num = Console.Read();
    long x = 2;
    Console.Write("Input a year:"+ num);
    string s = Console.ReadLine();
    if (int.TryParse(s, out int year)) {
      if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
        Console.WriteLine(year + " is a leap year.");
      }
      else {
        Console.WriteLine(year + " is not a leap year.");
      }
    }else {
      Console.Write("Invalid input!");
    }
  }
}
