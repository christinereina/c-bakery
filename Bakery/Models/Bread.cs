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

   public int FinalBreadCost()
    {
      int finalCost = Cost * BreadAmount;
        for (int i =0; i < BreadAmount; i++)
        {
          if (i % 3 == 0) 
          {
              finalCost -= 5;
          }
        }
        return finalCost;
      } 
    }
}