using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    class Patterns
    {
      public static string regex5 = "^[A-Za-z0-9!@#>$&]{8,}$";
      public bool password1(string password1)
        {
            return Regex.IsMatch(password1, regex5);
        }
     }
}
