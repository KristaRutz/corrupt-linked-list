using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    Node a = new Node("a");
    Node b = new Node("b");
    a.Next = b;
    Node c = new Node("c");
    b.Next = c;
    Node d = new Node("d");
    c.Next = d;
    Node e = new Node("e");
    d.Next = e;
    e.Next = c;

    Console.WriteLine(FindLoopStart(a).Name);
  }

  public static Node FindLoopStart(Node head){
    Node pointer = head.Next;
    List<Node> nodes = new List<Node>() {head};
    while(pointer.Next != null && pointer.Next.Next != null)
    {
      for (int i = 0; i < nodes.Count-1; i++)
      {
        if (pointer == nodes[i])
        {
          return pointer;
        }
        else
        {
          nodes.Add(pointer);
        }
      }
      pointer = pointer.Next;
    }
    return null;
  } 
}
