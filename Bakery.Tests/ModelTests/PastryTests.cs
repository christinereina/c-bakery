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
    public void CreatesCost_CreateBreadCost_Int()
    {
      int breadCost = 5;
      Bread newBread = new Bread(1);
      int result = newBread.Cost;
      Assert.AreEqual(breadCost, result);
    }
}
}