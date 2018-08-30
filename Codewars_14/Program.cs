using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int gg = SumDigits(-52);
            Console.ReadLine();
        }

        public static int SumDigits(int number)
        {
            if (number>=0)
            {
                return number.ToString().ToCharArray().Sum(c => Convert.ToInt32(c.ToString()));
            }
               
            else
            {
                return number.ToString().Trim('-').ToCharArray().Sum(c => Convert.ToInt32(c.ToString()));
            }
        }
    }
}
