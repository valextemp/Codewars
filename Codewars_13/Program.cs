using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "xyaabbbccccdefww";
            string b = "xxxxyyyyabklmopq";

            string bb = TwoToOne(a, b);

            Console.WriteLine(bb);
            Console.ReadLine();

        }

        public static string TwoToOne(string s1, string s2)
        {
            char[] myChars;

            string tempStr = s1 + s2;
            var myResult = tempStr.Distinct().OrderBy(c => c);
            return string.Join("", myResult);

            //myChars = tempStr.ToCharArray();
            //var myResult = myChars.Distinct().OrderBy(c=>c).ToString();
        }
    }
}
