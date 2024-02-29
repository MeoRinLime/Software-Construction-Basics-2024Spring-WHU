using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStreamTest {
  class Program {
    static void Main(string[] args) {
      try {
        byte[] array = { 33, 34, 35, 36, 37 };
        MemoryStream readStream = new MemoryStream(array);
        MemoryStream writeStream = new MemoryStream();

        int b;
        while ((b = readStream.ReadByte()) != -1) {
          writeStream.WriteByte((byte)(b + 3));
        }

        byte[] result = writeStream.ToArray();
        Array.ForEach(result, bt => Console.WriteLine(bt));

      }catch (IOException e) {
        Console.WriteLine("Exception:" + e.ToString());
      }
    }
  }
}
