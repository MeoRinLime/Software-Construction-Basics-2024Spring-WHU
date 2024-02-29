using System;
using System.IO;
using System.Xml;
public class Sample {
  private const string filename = "sampledata.xml";
  public static void Main() {
    using (XmlTextWriter writer = new XmlTextWriter(filename, null)) {
      writer.Formatting = Formatting.Indented;//为使文件易读，使用缩进
      writer.WriteStartDocument(); //写XML声明
      writer.WriteComment("sample XML");//文档注释
      writer.WriteStartElement("book");//写book元素（根元素）
      writer.WriteAttributeString("genre", "novel");//属性
      writer.WriteAttributeString("ISBN", "1-8630-014");//属性
      writer.WriteElementString("title", "The Handmaid's Tale");//title元素
      writer.WriteElementString("price", "19.95");//price元素
      writer.WriteEndElement(); //写book元素结束标签
      writer.WriteEndDocument();//文档结束
    }
    
    XmlDocument doc = new XmlDocument();
    doc.PreserveWhitespace = true;
    doc.Load(filename);//加载文件
    Console.Write(doc.InnerXml);//XML文件的内容显示在控制台
    Console.WriteLine();

    using (XmlReader reader = new XmlTextReader(filename)) { 
      while (reader.Read()) {
        switch (reader.NodeType) {
          case XmlNodeType.Element:
            Console.Write("\n" + Indent(reader.Depth) + reader.Name + ":");
            if (reader.HasAttributes) {
              reader.MoveToFirstAttribute();
              do {
                Console.Write(" \n" + Indent(reader.Depth) + 
                  reader.Name + ":" + reader.Value);
              } while (reader.MoveToNextAttribute());
            }
            break;
          case XmlNodeType.Text:
            Console.Write(reader.Value);
            break;
        }
      }
      Console.WriteLine();
    }
  }
  static string Indent(int i) {
    if (i == 0) return "";
    return new String(' ', i);//i个空格
  }
}
