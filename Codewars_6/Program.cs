using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars_6
{
    class Program
    {
 //  Return the number(count) of vowels in the given string.
//   We will consider a, e, i, o, and u as vowels for this Kata.

public static class Kata
    {
        public static int GetVowelCount(string str)
        {
                int ii = 0;
                ii= str.Count()
            int vowelCount = 0;
            vowelCount = Regex.Matches(str, "[aeiou]", RegexOptions.IgnoreCase).Count;
            return vowelCount;

                // return str.Count(i => "aeiou".Contains(i)); // еще вариант через Linq
                // return str.Count(x => "aeiou".IndexOf(x) != -1);// еще вариант через Linq
            }
        }
    static void Main(string[] args)
        {
            Console.Write(Regex.Matches("That is that.", "[t]", RegexOptions.IgnoreCase).Count);
            Console.ReadLine();
}
    }
}
