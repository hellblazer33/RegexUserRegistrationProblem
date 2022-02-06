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
      public static string regex7 = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9!@#>$&]{8,}$";
       public bool password3(string password3)
        {
            return Regex.IsMatch(password3, regex7);
        }
     }
}
