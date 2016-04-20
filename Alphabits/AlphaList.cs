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
      // Constructor required by exercise instructions
    }

    private List<char> _letterList = new List<char>();

    public bool addChar(char newChar)
    {
      if (Char.IsLetter(newChar))
      {
        _letterList.Add(newChar);
        return true;
      }
      else
      {
        return false;
      }
      
    }

    public int listLength()
    {
      return _letterList.Count;
    }
  }
}
