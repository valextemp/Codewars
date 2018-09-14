using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = "8 3 -5 42 -1 0 0 -9 4 7 4 -4";
            HighAndLow(ss);
        }

        public static string HighAndLow(string numbers)
        {
            var nums = numbers.Split(new Char[] { ' ', ',', '.', ':', '\t' }).Select(c=>Convert.ToInt32(c));
            return string.Format("{0} {1}", nums.Max(), nums.Min()); ;
        }

    }
}
