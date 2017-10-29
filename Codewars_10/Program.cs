using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //BitArray ba = new BitArray(5);
            //Console.WriteLine(ba.ToString());

            Console.WriteLine(AddBinary(2,2));

            Console.ReadLine();
        }

        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
        }

    }
}
