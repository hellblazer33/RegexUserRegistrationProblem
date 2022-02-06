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
      public static string regex6 = "^(?=.*[A-Z])[a-zA-Z0-9!@#>$&]{8,}$";
       public bool password2(string password2)
        {
            return Regex.IsMatch(password2, regex6);
        }
     }
}
