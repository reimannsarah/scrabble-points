using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Test
{
  [TestClass]
  public class LettersTest
  {
    // [TestMethod]
    //   public void LettersConstructor_CreatesInstanceOfDictionary_Letters()
    //   {
    //   Letters letterPoints = new Letters();
    //   Assert.AreEqual(typeof(Letters), letterPoints.GetType());
    // }
    [TestMethod]
      public void LettersConstructor_CreatesInstanceOfDictionaryWithKeyValuePairs_Letters()
      {
      char[] expected = new char[]{'q','z'};
      Letters letterPoints = new Letters();
      CollectionAssert.AreEqual(expected, Letters.Points[10]);
    }

  }
}