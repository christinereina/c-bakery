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
      Bread newCost = new Bread();
      Assert.AreEqual(typeof(Bread), newCost.GetType());
    }
  }
  }