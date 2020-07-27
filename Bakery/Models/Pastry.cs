using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {

    public string PastryName { get; set;}

    public Pastry(string pastryName)
    {
      PastryName = pastryName;
    }

  }
}