using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = IsSquare(25);
            var v1 = IsSquare(26);
            var v2 = IsSquare(28);

            //int b = (int)v*(int)v;
            //int b1 = (int)v1 * (int)v1;
            //int b2 = (int)v2 * (int)v2;
        }
        public static bool IsSquare(int n)
          {
            var mysqrt = Math.Sqrt(n);
            if (n == (int)mysqrt * (int)mysqrt) return true;
            else return false;
          }


   
}
}
