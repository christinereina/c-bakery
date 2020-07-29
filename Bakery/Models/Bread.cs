using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread 
{
  public int Cost { get; set; }

  public int BreadAmount {get; set;}

  public Bread(int breadAmount)
    {
      Cost = 5;
      BreadAmount = breadAmount;
    }

   public void FinalBreadCost()
    {
      int finalCost = Cost * BreadAmount;
      if (BreadAmount % 5 == 0) 
      {
        Cost -= 5;
      } 
    }
}
}

