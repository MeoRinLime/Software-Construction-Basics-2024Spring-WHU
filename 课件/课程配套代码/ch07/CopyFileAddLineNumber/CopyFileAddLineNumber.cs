using System;
using System.IO;
using System.Text;
public class CopyFileAddLineNumber {
  public static void Main(string[] args) {
    try {
      FileStream fin = new FileStream(
                "Test.cs", FileMode.Open, FileAccess.Read);
      FileStream fout = new FileStream(
                "Test.txt", FileMode.Create, FileAccess.Write);
      using (StreamReader reader = new StreamReader(fin, Encoding.Default)) {
        using (StreamWriter writer = new StreamWriter(fout, Encoding.Default)) {
          int lineNum = 0;
          string s = null;
          while ((s = reader.ReadLine()) != null) {//���ж�Դ�ļ�
            lineNum++;
            s = DeleteComments(s); //ȥ����//��ʼ��ע��
            writer.WriteLine(lineNum + ": \t" + s);//д�뵽Ŀ���ļ�
          }
        }
      }
     
    }catch (FileNotFoundException e) {
      Console.WriteLine($"File {e.FileName} is not found!+");
    }catch (IOException e2) {
      Console.WriteLine(e2);
    }
  }

  static string DeleteComments(string s) //ȥ����//��ʼ��ע��
  {
    if (s == null) return s;
    int pos = s.IndexOf("//");
    if (pos < 0) return s;
    return s.Substring(0, pos);
  }
}
