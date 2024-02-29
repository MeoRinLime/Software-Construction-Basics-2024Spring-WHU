using System;
using System.Collections.Generic;

class IndexerRecord {
  private string[] data = new string[6];
  private string[] keys = {
        "Author", "Publisher", "Title",
        "Subject", "ISBN", "Comments"
        };

  public string this[int idx] {
    set {
      if (idx >= 0 && idx < data.Length) {
        data[idx] = value;
      }
    }
    get {
        return (idx >= 0 && idx < data.Length)?data[idx]:null;
    }
  }

  public string this[string key] {
    set {
      int idx = Array.IndexOf(keys, key);
      this[idx] = value;
    }
    get {
      return this[Array.IndexOf(keys, key)];
    }
  }
  
  static void Main() {
    IndexerRecord record = new IndexerRecord();
    record[0] = "���-����";
    record[1] = "Crox���湫˾";
    record["Title"] = "��ķ-�������ռ�";
    Console.WriteLine(record[2]);
    Console.WriteLine(record["Author"]);
    Console.WriteLine(record["Publisher"]);
  }
}


