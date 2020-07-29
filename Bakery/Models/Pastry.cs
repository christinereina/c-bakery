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
    int finalCost = Cost * PastryAmount;
    for (int i =0; i < PastryAmount; i++)
    {
      if (i % 3 == 0) 
      {
        finalCost -= 1;
      } 
    }
     return finalCost;
  }

  }
}
