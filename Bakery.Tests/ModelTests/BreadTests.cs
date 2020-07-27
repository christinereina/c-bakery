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
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void CreatesCost_CreateBreadCost_Int()
    {
      Bread newCost = new Bread(5);
      Assert.AreEqual(typeof(Bread), newCost.GetType());
    }

    [TestMethod]
    public void CountsBreadAmount_ReturnsBreadAmount_Int()
    {
      int breadCount = "fifty";
      Bread newBread = new Bread(breadCount);
      int result = newBread.BreadAmount;
      Assert.AreEqual(breadCount, result);
    }

  }
  }