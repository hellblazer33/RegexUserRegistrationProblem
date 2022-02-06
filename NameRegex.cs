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
      public static string regex3 = "^[A-Z][a-z]{2,}$";
      public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, regex3);
        }
     }
