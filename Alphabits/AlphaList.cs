using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
  public class AlphaList
  {
    // public AlphaList()
    // {
    //   // Anything to put here?
    // }

    public List<char> letterList;

    public void addChar(char newChar)
    {
      Console.WriteLine(newChar);
    }

    public int listLength()
    {
      return letterList.Count;
    }
  }
}
