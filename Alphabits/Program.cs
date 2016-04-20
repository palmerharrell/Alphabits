using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
  class Program
  {
    static void Main(string[] args)
    {
      AlphaList testList = new AlphaList();
      bool gameOver = false;

      while (!gameOver)
      {
        Console.WriteLine("\nEnter a letter.");
        Console.Write("> ");
        char userInput = Console.ReadKey().KeyChar;
        Console.WriteLine("\nInput: {0}", userInput);
        if (userInput == 'x') // Will check listLength.Count == 26
        {
          gameOver = true;
          Console.WriteLine("\nWin!\n");
        }
      }
      
    } // Main
  } // Program
} // namespace
