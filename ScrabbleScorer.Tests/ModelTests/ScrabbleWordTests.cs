using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScrabbleWordTests
  {
    [TestMethod]
    public void ScrabbleWordConstructor_CreateInstanceOfPalindrome_ScrabbleWord()
    {
      ScrabbleWord checkWord = new ScrabbleWord("panino");
      // assert
      Assert.AreEqual(typeof(ScrabbleWord), checkWord.GetType());
    }
    [TestMethod]
    public void WordArray_TransformUserInputIntoArray_Array()
    {
      //arrange
      string userInput = "panino"
      ScrabbleWord newWord = new ScrabbleWord("panino");
      // act
      char[] expectArray = userInput.ToCharArray();
      char[] theorArray = newWord.WordArray();
      //assert
      CollectionAssert.AreEqual(expectedArray, theorArray);
    }
  }
}