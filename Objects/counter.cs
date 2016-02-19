using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountProject.Objects
{
  public class Count
  {
   private string _Input;
   private string _CheckAgainst;

   public Count( string Input, string CheckAgainst)
   {
     _Input = Input;
     _CheckAgainst = CheckAgainst;
   }
   public string GetInput()
   {
     return _Input;
   }
   public string GetCheckAgainst()
   {
     return _CheckAgainst;
   }

   public int Repeats()
   {
     int result = Regex.Matches(_CheckAgainst, @"\b" + @_Input + @"\b").Count;
     return result;
   }
  }
}
