using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.leap
{
    class Year
    {
        internal static object IsLeap(int year)
        {
            // The tricky thing here is that a leap year occurs:
            // on every year that is evenly divisible by 4
            // except every year that is evenly divisible by 100
            // unless the year is also evenly divisible by 400

            // Rule out years that aren't divisible by 4
            if (year % 4 != 0)
                return false;

            // If the year isn't divisible by 100, it's definitely a leap year
            if (year % 100 != 0)
                return true;

            // Now we know that the year is divisible by 4 and it's divisible by 100
            return (year % 400 == 0);
        }
    }
}
