using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryName_ReturnsPastryName_String()
    {
      string pastryName = "Chocolate Croissant";
      Bread newPastry = new Bread(pastryName);
      string choice = newPastry.PastryName;
      Assert.AreEqual(pastryName, choice);
    }

  }
}