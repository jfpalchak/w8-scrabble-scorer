//USING DIRECTIVES HERE
using ScrabbleScorer.Models;
using System;

namespace ScrabbleScorer
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Scrabble Scorer!");
      Console.WriteLine("Enter a word below to discover how many points it's worth:");
      string userInput = Console.ReadLine();
      ScrabbleWord newWord = new ScrabbleWord(userInput);

      int wordPoints = newWord.GetPoints();
    
      Console.WriteLine("===============================");
      Console.WriteLine($"{userInput} is worth {wordPoints} points.");
      Console.WriteLine("===============================");

      Console.WriteLine("Would you like to enter another word?");
      Console.WriteLine("Enter 'yes' to go again, otherwise enter any key to exit.");
      string userInput2 = Console.ReadLine();

      if (userInput2.ToLower() == "yes")
      {
        Main();
      }
      else
      {
        Console.WriteLine("~");
        Console.WriteLine("Goodbye.");
        Console.WriteLine("~");
      }

    }
  }
}