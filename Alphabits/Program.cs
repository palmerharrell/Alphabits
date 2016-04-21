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
        Console.WriteLine("\n               Enter all the letters of the alphabet");
        Console.WriteLine("               -------------------------------------\n");
        Console.WriteLine("\n                        Letters entered: {0}", testList.listLength());
        Console.WriteLine("\n {0}", message);
        Console.WriteLine("\n Enter a letter:");
        Console.Write(" > {0}", userInput);
        userInput = Console.ReadKey().KeyChar;

        // Check if userInput is a letter
        if (testList.isALetter(userInput))
        {
          if (testList.inList(userInput))
          {
            message = userInput + " has already been entered!";
          }
          else
          {
            message = userInput + " entered.";
            testList.addChar(userInput);
          }
        }
        else
        {
          message = userInput + " is not a letter.";
        }

        // End if all letters have been entered
        if (testList.listLength() == 26)
        {
          gameOver = true;
          message = "That's all of them!";
          Console.Clear();
          Console.WriteLine("\n               Enter all the letters of the alphabet");
          Console.WriteLine("               -------------------------------------\n");
          Console.WriteLine("\n                        Letters entered: {0}", testList.listLength());
          Console.WriteLine("\n{0}", message);
          Console.WriteLine("\n\n");
        }
      }
      
    } // Main
  } // Program
} // namespace
