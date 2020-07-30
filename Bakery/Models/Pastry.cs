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

  public int FinalPastryCost()
  {
    int finalCost = 0;
    for (int i =1; i <= PastryAmount; i++)
    {
      if (i % 3 != 0) 
      {
        finalCost += Cost;
      } 
      else 
      {
      finalCost = ++Cost;
      }
    }
     return finalCost;
  }
  }
}
