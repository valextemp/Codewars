using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss=ReverseLetter("krishan");

            ss=ReverseLetter("ultr53o?n");

            ss=ReverseLetter("ab23c");

            ss=ReverseLetter("krish21an");

        }

        public static string ReverseLetter(string str)
        {
            return new string( str.Where(char.IsLetter).Reverse().Select(x => x).ToArray());
        }

    }
}
