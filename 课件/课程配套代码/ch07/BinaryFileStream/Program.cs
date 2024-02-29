using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                FileStream stream = new FileStream("test.dat",
                    FileMode.Create, FileAccess.ReadWrite);

                BinaryWriter writer = new BinaryWriter(stream);

                //Write some data to the stream;
                writer.Write("A string");
                writer.Write(142);
                writer.Write(97.4);
                writer.Write(true);

                // Open it for reading;
                BinaryReader reader = new BinaryReader(stream);
                // Move back to the start;
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                // Read the data;
                Console.WriteLine(reader.ReadString());
                Console.WriteLine(reader.ReadInt32());
                Console.WriteLine(reader.ReadDouble());
                Console.WriteLine(reader.ReadBoolean());
            }catch (Exception e) {
                Console.WriteLine("Exception:" + e.ToString());
            }
        }
    }
}
