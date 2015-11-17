using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.bob
{
    public class Bob
    {
        public static string Hey(string statement)
        {
            if (IsSilence(statement))
                return "Fine. Be that way!";
            if (IsYelling(statement))
                return "Whoa, chill out!";
            if (IsQuestion(statement))
                return "Sure.";
            return "Whatever.";
        }

        private static bool IsSilence(string statement)
        {
            return statement.Trim() == "";
        }

        private static bool IsYelling(string statement)
        {
            return statement.ToUpper() == statement && System.Text.RegularExpressions.Regex.IsMatch(statement, "[a-zA-Z]+");
        }

        private static bool IsQuestion(string statement)
        {
            return statement.Trim().EndsWith("?");
        }
     }
   }