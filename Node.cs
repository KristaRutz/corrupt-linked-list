using System;

public class Node
{
  public Node Next { get; set; }
  public string Name { get; set; }

  public Node(string name)
  {
    Name = name;
  }
}