using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
{
  static void Main()
  {
    string[] breadList = {"red bean", "chocolate", "banana", "rye", "brown", "white", "pink fluffy"};
    int[] breadListPrices = { 3, 6, 4, 2, 4, 4};

    Console.WriteLine("Bread Menu");
    foreach (string breadItem in myBreadList)
    {
      Console.WriteLine(breadItem);
    }

    int total = 0;
    foreach (int price in breadListPrices)
    {
      total = total + price;
    }

    Console.WriteLine("Your total bread cost is" + total);
  }
}
//   public class Bread
//   {
//     public string BreadName { get; set;}
//     public int BreadPrice { get; set; }
//     public int BreadAmount { get; set; }
//     public int FinalCost { get; set; }

//     public Bread(string breadName, int breadPrice, int breadAmount, int finalCost )
//     {
//       BreadName = breadName;
//     }

//     public void BreadCost()
//     {
//       FinalCost = BreadAmount * 5;
//     }

    
// }
// }