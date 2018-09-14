using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_20
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSum(0, 1);
        }

        public static int GetSum(int a, int b)
        {
            int minint, countint;
            if (a == b) return a;


            else if (a>b)
            {
                minint = b;
                countint = a - b+1;
            }
            else
            {
                minint = a;
                countint = b -a+1;
            }

            return Enumerable.Range(minint,countint).Sum();
        }

    }
}
