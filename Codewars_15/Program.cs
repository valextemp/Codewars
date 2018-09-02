using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_15
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new int[] { 49, 3, 5, 300, 7 };
            var avg = Average(scores);
            Console.ReadLine();
        }

        public static int Average(int[] scores)
        {
            //return Convert.ToInt32(Math.Round(scores.Average()));

            return (int)Math.Round(scores.Average());
        }
    }
}
