using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4.Strings
{
    public class RegexExample
    {
        public static bool IsMatch(string text, string pattern, int textIndex, int patIndex)
        {
            if (textIndex >= text.Length)
                if (patIndex >= pattern.Length)
                    return true;
                else
                    if ((patIndex + 1 < pattern.Length) && (pattern[patIndex + 1] == '*'))
                {
                    return IsMatch(text, pattern, textIndex, patIndex + 2);
                }

                else
                    return false;

            else if ((patIndex >= pattern.Length) && (textIndex < text.Length))
                return false;

            // string matching for character followed by '*'
            else if ((patIndex + 1 < pattern.Length) && (pattern[patIndex + 1] == '*'))
                if ((pattern[patIndex] == '.') || (text[textIndex] == pattern[patIndex]))
                    return (IsMatch(text, pattern, textIndex, patIndex + 2) ||
                            IsMatch(text, pattern, textIndex + 1, patIndex));
                else
                    return IsMatch(text, pattern, textIndex, patIndex + 2);

            // string matching for '.' or ordinary char.
            else if ((pattern[patIndex] == '.') ||
                    (pattern[patIndex] == text[textIndex]))
            {
                return IsMatch(text, pattern, textIndex + 1, patIndex + 1);
            }

            else
                return false;

        }
    }

}
