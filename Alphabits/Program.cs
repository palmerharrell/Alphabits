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
      char userInput = ' ';
      string message = "";

      while (!gameOver)
      {
        Console.Clear();
        Console.WriteLine("\nLetters entered: {0}", testList.listLength());
        Console.WriteLine("\n{0}", message);
        Console.WriteLine("\nEnter a letter.");
        Console.Write("> {0}", userInput);
        userInput = Console.ReadKey(false).KeyChar;

        if(testList.addChar(userInput))
        {
          message = "";
        }
        else
        {
          message = "That's not a letter.";
        }

        if (testList.listLength() == 26)
        {
          gameOver = true;
          message = "That's all of them!";
          Console.Clear();
          Console.WriteLine("\nLetters entered: {0}", testList.listLength());
          Console.WriteLine("\n{0}", message);
          Console.WriteLine("\n\n");
        }
      }
      
    } // Main
  } // Program
} // namespace
