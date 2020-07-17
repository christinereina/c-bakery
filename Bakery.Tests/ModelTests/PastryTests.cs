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
      Pastry newPastry = new Pastry("Chocolate Croissant");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryName_ReturnsPastryName_String()
    {
      string pastryName = "Chocolate Croissant";
      Pastry newPastry = new Pastry(pastryName);
      string choice = newPastry.PastryName;
      Assert.AreEqual(pastryName, choice);
    }

  }
}