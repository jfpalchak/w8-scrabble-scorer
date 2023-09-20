# _Scrabble Scorer_

#### By _Seth Gonzales, Paul LeTourneau, Joey Palchak_

#### _A console application that takes a word and returns the Scrabble score for that word._

## Technologies Used

* C#
* .NET 6
* MSTest

## Description

The application asks the user to enter a single word. Taking the user's input, the program parses the given string into an array of characters, and calculates the word's total score according to the sum of each character's point value. Upon evaluation of the word's score, it is presented to the user, after which the application will prompt the user to either enter another word, or exit the program.

The point value for each letter is defined as follows:

| Letter | Point Value |
| :------ | -----------: |
| A, E, I, O, U, L, N, R, S, T  |    1|
| D, G                          |    2|
| B, C, M, P                    |    3|
| F, H, V, W, Y                 |    4|
| K                             |    5|
| J, X                          |    8|
| Q, Z                          |   10|


## Setup/Installation Requirements

1. Clone this repo.
2. Open your terminal and navigate to this project's production directory called `ScrabbleScorer`.
3. In the command line, run the command `dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
   1. Optionally, you can run `dotnet build` to compile this console app without running it.
4. Navigate to test directory, `ScrabbleScorer.Tests`.
5. In the command line, run the command `dotnet test` to execute the tests.


## Known Bugs

* User can enter non-alphabetical characters without error, although the special character's will not be counted.

## License

MIT License

Copyright (c) _9/20/2023_ _Seth Gonzales, Paul LeTourneau, Joey Palchak_