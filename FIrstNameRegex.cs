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
      public static string regex2 = "^[A-Z][a-z]{2,}$";
      public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, regex2);
        }
     }
}
