using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamTest {
  class Program {
    static void Main(string[] args) {
      try {
        FileStream writeStrea = new FileStream("test.dat",
            FileMode.Create, FileAccess.Write);

        //Write some data to the stream;
        writeStrea.WriteByte(33);
        writeStrea.Write(new byte[] { 34, 35, 36 }, 0, 3);
        writeStrea.Close();

        FileStream readStream = new FileStream("test.dat",
            FileMode.Open, FileAccess.Read);

        for (int b = readStream.ReadByte(); b != -1; b = readStream.ReadByte()) {
          Console.WriteLine(b);
        }
      }
      catch (Exception e) {
        Console.WriteLine("Exception:" + e.ToString());
      }
    }
  }
}
