using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
  public class AlphaList
  {
    public AlphaList()
    {
      // Anything to put here?
    }

    private List<char> _letterList = new List<char>();

    public bool addChar(char newChar)
    {
      return true; // This should return true if letter, false otherwise
    }

    public int listLength()
    {
      return _letterList.Count;
    }
  }
}
