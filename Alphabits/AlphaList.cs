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

    public void addChar(char newChar)
    {
      _letterList.Add(Char.ToUpper(newChar));
    }

    public bool isALetter(char letter)
    {
      if (Char.IsLetter(letter))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool inList(char letter)
    {
      if (_letterList.Contains(Char.ToUpper(letter)))
      {
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
