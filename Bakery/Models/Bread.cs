using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
{
  public string Name {get; set;}
  
  public Bread(string name)
    {
      Name = name;
    }
    // public bool IsBread(string name)
    // {
    //   return true;
    // }
    public Dictionary<string, int> AssignValues()
    {
    Dictionary<string, int> breadOrder = new Dictionary<string, int>() 
    { {"vanilla", 5}, 
    {"chocolate", 5}, 
    {"raspberry", 5}, 
    {"caramel apple", 5} };
    return breadOrder;
    }
}
}

