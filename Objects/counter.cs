using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountRepeatProject.Objects
{
  public class RepeatCounter
  {
   private string _Input;
   private string _CheckAgainst;

   public RepeatCounter( string Input, string CheckAgainst)
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

   public int CountRepeats()
   {
     int result = Regex.Matches(_CheckAgainst, @"\b" + @_Input + @"\b").Count;
     return result;
   }
  }
}
