﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication {

  // 链表节点
  public class Node<T> {
    public Node<T> Next { get; set; }
    public T Data { get; set; }

    public Node(T t) {
      Next = null;
      Data = t;
    }
  }

  //泛型链表类
  public class GenericList<T> {
    private Node<T> head;
    private Node<T> tail;

    public GenericList() {
      tail = head = null;
    }

    public Node<T> Head {
      get => head;
    }

    public void Add(T t) {
      Node<T> n = new Node<T>(t);
      if (tail == null) {
        head = tail = n;
      }else {
        tail.Next = n;
        tail = n;
      }
    }
  
    public IEnumerator<T> GetEnumerator() {
      for (Node<T> current = head; 
        current != null; current = current.Next) {
        yield return current.Data;
      }
    }

  }
  



  class Program {
    static void Main(string[] args) {
      // 整型List
      GenericList<int> intlist = new GenericList<int>();
      for (int x = 0; x < 10; x++) {
        intlist.Add(x);
      }
      foreach(int x in intlist) {
        Console.WriteLine(x);
      }
      // 字符串型List
      GenericList<string> strList = new GenericList<string>();
      for (int x = 0; x < 10; x++) {
        strList.Add("str"+x);
      }
      foreach (string s in strList) {
        Console.WriteLine(s);
      }
    }

  }
}