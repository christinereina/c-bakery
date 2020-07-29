using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine(" Welcome to Pusheen's Bakery");
      Console.WriteLine("🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞");
      Console.WriteLine(" 🍞🍞🍞🍞🍞 Bread 🍞🍞🍞🍞🍞 ");
      Console.WriteLine("      One Loaf is $5");
      Console.WriteLine("🥐🥐🥐🥐🥐🥐🥐🥐🥐🥐🥐🥐🥐🥐🥐");
      Console.WriteLine("🥐🥐🥐🥐🥐 Pastries 🥐🥐🥐🥐🥐");
      Console.WriteLine("      One Pastry is $2");
      Console.WriteLine("🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎");
      Console.WriteLine("Pusheen Specials: Buy More, Save More!");
      Console.WriteLine("BOGO Bread || Buy 🍞🍞 get one FREE");
      Console.WriteLine("Pastry Me || Buy 🥐🥐🥐 for $5");
      Console.WriteLine("🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎");
      //user input for bread
      Console.WriteLine("How much Bread would you like?");
      int userBread = int.Parse(Console.ReadLine());
      Bread newBread = new Bread(userBread);
      int finalBread = newBread.FinalBreadCost();
      //user input for pastries
      Console.WriteLine("How many Pastries would you like?");
      int userPastry = int.Parse(Console.ReadLine());
      Pastry newPastry = new Pastry(userPastry);
      int finalPastry = newPastry.FinalPastryCost();
      Console.WriteLine("🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎🤎");
      //total amount of bread + pastry cost
      Console.WriteLine("Your Pusheen Total: $" + (finalBread + finalPastry));
      Console.WriteLine("Thank you for your order ~ Pusheen");
    }
  }
}