using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Xbonacci xx = new Xbonacci();

            // new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10))

            double[] ff = xx.Tribonacci(new double[] { 1, 1, 1 }, 2);

            Console.ReadLine();
        }
    }
}
