using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher {
  public class Program {
    public static void Main(string[] args) {
      const string path = @"c:\temp";
      
      FileSystemWatcher watcher = new FileSystemWatcher(path);
      //订阅事件
      watcher.Changed += OnChanged;
      watcher.Created += OnChanged;
      watcher.Deleted += OnChanged;
      watcher.Renamed += OnRenamed;

      // 开始监视
      watcher.EnableRaisingEvents = true;

      // 等用户输入q才结束程序
      Console.WriteLine("Press'q' to quit.");
      while (Console.Read() != 'q') ;
    }

    // 事件处理函数.
    public static void OnChanged(object source, FileSystemEventArgs e) {
      // 显示哪些文件做了何种修改
      Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
    }

    public static void OnRenamed(object source, RenamedEventArgs e) {
      // 显示被更改的文件名
      Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
    }
  }
}
