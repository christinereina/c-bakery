using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void TestConstructor_CreateInstanceOfBread_Cost()
    {
      Bread newCost = new Bread(5);
      Assert.AreEqual(typeof(Bread), newCost.GetType());
    }

    [TestMethod]
   public void TestConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("5");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
  }