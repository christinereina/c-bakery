using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
  public int Cost { get; set; }

  public int PastryAmount {get; set;}

    public Pastry(int pastryAmount)
    {
      Cost = 2;
      PastryAmount = pastryAmount;
    }

  }
}
