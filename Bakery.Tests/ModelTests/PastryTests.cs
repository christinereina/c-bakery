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
    public void CreatesCost_CreatePastryCost_Int()
    {
      int pastryCost = 2;
      Pastry newPastry = new Pastry();
      int result = newPastry.Cost;
      Assert.AreEqual(pastryCost, result);
    }

    [TestMethod]
    public void CountsPastryAmount_ReturnsPastryAmount_Int()
    {
      int pastryCount = 50;
      Pastry newPastry = new Pastry(pastryCount);
      int result = newPastry.PastryAmount;
      Assert.AreEqual(pastryCount, result);
    }
}
}