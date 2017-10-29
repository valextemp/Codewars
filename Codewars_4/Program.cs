using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sss = { 78, 56, 232, 12, 11, 43 };
            int[] aaa = { 78, 56, -2, 12, 8, -33 };

            int i = SmallestIntegerFinder.FindSmallestInt(sss);
            int i2= SmallestIntegerFinder.FindSmallestInt(aaa);

            Console.WriteLine("min from {0} == {1}", sss, i);
            Console.ReadLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("min from {0} == {1}", aaa, i2);
            Console.ReadLine();


        }
    }
}
