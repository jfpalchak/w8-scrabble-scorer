//USING DIRECTIVES HERE
using System;
using System.Collections.Generic;


namespace ScrabbleScorer.Models
{
  public class ScrabbleWord
  {
    public string Word { get; set; }

    private static Dictionary<char, int> _wordScoreDictionary = new Dictionary<char, int> {
      { 'A', 1 }, { 'B', 3 }, { 'C', 3 }, { 'D', 2}, { 'E', 1}, { 'F', 4 }, { 'G', 2 }, { 'H', 4 }, { 'I', 1 }, { 'J', 8 }, { 'K', 5 }, 
      { 'L', 1 }, { 'M', 3 }, { 'N', 1 }, { 'O', 1}, { 'P', 3}, { 'Q', 10 },
      { 'R', 1 }, { 'S', 1 }, { 'T', 1 }, { 'U', 1}, { 'V', 4}, { 'W', 4 },
      { 'X', 8 }, { 'Y', 4 }, { 'Z', 10 }
    };


    public ScrabbleWord(string userInput)
    {
      Word = userInput.ToUpper();
    }
    public char[] WordArray()
    {
      char[] charArray = Word.ToCharArray();
      return charArray;
    }

    public int GetPoints()
    {
      char[] charArray = this.WordArray();
      int points = 0;
      
      foreach (char letter in charArray)
      {
        if (_wordScoreDictionary.ContainsKey(letter)) 
        {
          int letterPoints = _wordScoreDictionary[letter];
          points += letterPoints;
        }
      // else
      // {
      //   Main();
      // }
      }
      return points;
    }
  }
}