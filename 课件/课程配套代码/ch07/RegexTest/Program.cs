using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest {
  class Program {
    static void Main(string[] args) {
      //Console.WriteLine(Regex.IsMatch("Hello World", "He")); //true
      //Console.WriteLine(Regex.IsMatch("Hello World", "le")); //false
      //Console.WriteLine(Regex.IsMatch("Hello World", @"lo\s")); //true

      //Console.WriteLine(Regex.IsMatch("Hello 2020", @"\s[0-2][0-2]")); //true
      //Console.WriteLine(Regex.IsMatch("Hello 2020", @"\s\d\d")); //true
      //Console.WriteLine(Regex.IsMatch("Hello 2020", @"[^0-9]\s\d")); //true
      //Console.WriteLine(Regex.IsMatch("Hello 2020", @"\W\s\d")); //false

      //Console.WriteLine(Regex.IsMatch("Hello 2020", @"\s\d{4}")); //true
      //Console.WriteLine(Regex.IsMatch("Hello 2020", @"\s\d{4,}")); //true
      //Console.WriteLine(Regex.IsMatch("Hello 2020", @"\s\d+")); //true
      //Console.WriteLine(Regex.IsMatch("Hello 2020", @"\s\d?")); //true

      //Console.WriteLine(Regex.IsMatch("ABC0", @"^[^0-9]+$")); //false
      //Console.WriteLine(Regex.IsMatch("ABC0", @"^[^0-9]+")); //true
      //Console.WriteLine(Regex.IsMatch("Hello C2", @"\bC\d\b")); //true

      /*
       (\w+)	匹配一个或多个单词字符。 这是第一个捕获组。
       \s	与空白字符匹配。
       (\1)	与第一个捕获组捕获中的字符串匹配。 这是第二个捕获组。
      */
      string pattern = @"(\w+)\s(\1)";  
      string input = "He said that that was the the correct answer.";
      MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);
      foreach (Match match in matches)
        Console.WriteLine("Duplicate '{0}' found at positions {1} and {2}.",
                          match.Groups[1].Value, 
                          match.Groups[1].Index, 
                          match.Groups[2].Index);
      /*
       (?<word>\w+)	匹配一个或多个单词字符。 命名此捕获组Word。
       \s	与空白字符匹配。
       \k<word>	匹配名为 word的捕获的组。
       \W	匹配包括空格和标点符号的一个非单词字符。
       (?<nextWord>\w+) 匹配一个或多个单词字符。 命名此捕获组 nextWord。
      */
      pattern = @"(?<word>\w+)\s\k<word>\W(?<nextWord>\w+)";
       input = "He said that that was the the correct answer.";
      foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
        Console.WriteLine("A duplicate '{0}' at position {1} is followed by '{2}'.",
                          match.Groups["word"].Value, match.Groups["word"].Index, 
                          match.Groups["nextWord"].Value);

      pattern = "[Bbw]il";
      string s = "My friend Bill will pay the bill";
      Console.WriteLine(Regex.IsMatch(s, pattern));

      Regex rx = new Regex(pattern);
      MatchCollection mc = rx.Matches(s);
      Console.WriteLine($"matches {mc.Count} times.");
      foreach (Match mt in mc) {
        Console.WriteLine($"matches {mt.Value} at {mt.Index}");
      }

      Match m = rx.Match(s);
      while (m.Success) {
        Console.WriteLine($"matches {m.Value} at {m.Index}");
        //m = rx.Match(s, m.Index + m.Length);
        m = m.NextMatch();
      }
    }


  }
}
