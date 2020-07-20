using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
{
  public string Name {get; set;}
  
  public Bread(string word)
    {
      Name = name;
    }
    public bool IsBread(string word)
    {
      return true;
    }
    public Dictionary<char, int> AssignValues()
    {
      Dictionary<char, int> bread = new Dictionary<string, int> 
      {{'Red Bean', 3},
      {'White', 2},
      {'Rye', 4}};
      return bread;
    }
}
}

