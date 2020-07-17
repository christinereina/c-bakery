using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfItem_Bread()
    {
      Bread newBread = new Bread("Red Bean Bread");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadName_ReturnsBreadName_String()
    {
      string breadName = "Red Bean Bread";
      Bread newBread = new Bread(breadName);
      string choice = newBread.BreadName;
      Assert.AreEqual(breadName, choice);
    }


  }
}