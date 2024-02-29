using System;
using System.IO;
using System.Xml;
public class Sample {
  private const string filename = "sampledata.xml";
  public static void Main() {
    using (XmlTextWriter writer = new XmlTextWriter(filename, null)) {
      writer.Formatting = Formatting.Indented;//Ϊʹ�ļ��׶���ʹ������
      writer.WriteStartDocument(); //дXML����
      writer.WriteComment("sample XML");//�ĵ�ע��
      writer.WriteStartElement("book");//дbookԪ�أ���Ԫ�أ�
      writer.WriteAttributeString("genre", "novel");//����
      writer.WriteAttributeString("ISBN", "1-8630-014");//����
      writer.WriteElementString("title", "The Handmaid's Tale");//titleԪ��
      writer.WriteElementString("price", "19.95");//priceԪ��
      writer.WriteEndElement(); //дbookԪ�ؽ�����ǩ
      writer.WriteEndDocument();//�ĵ�����
    }
    
    XmlDocument doc = new XmlDocument();
    doc.PreserveWhitespace = true;
    doc.Load(filename);//�����ļ�
    Console.Write(doc.InnerXml);//XML�ļ���������ʾ�ڿ���̨
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
    return new String(' ', i);//i���ո�
  }
}
