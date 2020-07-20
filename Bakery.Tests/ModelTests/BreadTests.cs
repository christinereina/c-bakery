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

    //   [TestMethod]
    // public void IsBread_CheckIfBreadcd_Bool()
    // {
    //   Score newWord = new Score("word");
    //   Assert.AreEqual(true, newWord.IsWord("word"));
    // }


  }
}