using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
   public void TestConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void CreatesCost_CreateBreadCost_Int()
    {
      int breadCost = 5;
      Bread newBread = new Bread(1);
      int result = newBread.Cost;
      Assert.AreEqual(breadCost, result);
    }

    [TestMethod]
    public void CountsBreadAmount_ReturnsBreadAmount_Int()
    {
      int breadCount = 50;
      Bread newBread = new Bread(breadCount);
      int result = newBread.BreadAmount;
      Assert.AreEqual(breadCount, result);
    }

    [TestMethod]
    public void CalculatesFinalPrice_ReturnsPriceBasedOnBreadAmount_Int()
    {
      int breadCost = 5;
      int breadCount = 2;
      Bread newBread = new Bread(breadCount);
      newBread.FinalBreadCost();
      int result = newBread.Cost;
      Assert.AreEqual(breadCost, result);
    }

  }
  }