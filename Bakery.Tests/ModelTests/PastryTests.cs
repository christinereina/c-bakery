using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
   public void TestConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void CreatesPastryCost_PastryCost_Int()
    {
      int pastryCost = 2;
      Pastry newPastry = new Pastry(1);
      int result = newPastry.Cost;
      Assert.AreEqual(pastryCost, result);
    }


  }
}