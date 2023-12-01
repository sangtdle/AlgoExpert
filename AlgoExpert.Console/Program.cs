// See https://aka.ms/new-console-template for more information
using AlgoExpert.Questions.ArrayQuestions;

string[][] board = new string[][] {
      new string[] { "H", "H", "H", "H", "M" },
      new string[] { "H", "H", "M", "H", "H" },
      new string[] { "H", "H", "H", "H", "H" },
      new string[] { "H", "H", "H", "H", "H" }
    };

int[,] directions = new int[8, 2] {
          { -1, -1 },
          { -1, 0 },
          { -1, 1 },
          { 0, -1 },
          { 0, 1 },
          { 1, -1 },
          { 1, 0 },
          { 1, 1 }
      };

Console.WriteLine(board.Length);
Console.WriteLine(directions.Length);

Console.ReadLine();