using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void TestConstructor_CreateInstanceOfBread_Name()
    {
      Bread newName = new Bread("vanilla");
      Assert.AreEqual(typeof(Bread), newName.GetType());
    }

      [TestMethod]
    public void IsBread_CheckIfBread_Bool()
    {
      Bread newName = new Bread("vanilla");
      Assert.AreEqual(true, newName.IsBread("vanilla"));
    }


  }
}