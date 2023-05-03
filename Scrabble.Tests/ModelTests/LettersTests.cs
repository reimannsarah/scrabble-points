using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Test
{
  [TestClass]
  public class Letters
  {
    [TestMethod]
      public void LettersConstructor_CreatesInstanceOfDictionary_Letters()
      {
      Letters letterPoints = new Letters();
      Assert.AreEqual(typeof(Letters), letterPoints.GetType());
    }
  }
}