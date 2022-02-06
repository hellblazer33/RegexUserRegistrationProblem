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
      public static string regex4 = "^[0-9]{2}[ ][0-9]{10}$";
      public bool validateMobile(string mobile)
        {
            return Regex.IsMatch(mobile, regex4);
        }
     }
}
