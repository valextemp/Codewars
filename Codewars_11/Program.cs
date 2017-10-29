using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLongest(new int[] { 1, 10, 100 }));
            Console.WriteLine(FindLongest(new int[] { 9000, 8, 800 }));
            Console.WriteLine(FindLongest(new int[] { 8, 900, 500 }));

            Console.ReadLine();

        }

        public static int FindLongest(int[] number)
        {
            int maxlenth = 0;
            int templenth = 0;
            int index = 0;
            for (int i=0; i<number.Length; i++)
            {
                templenth = Convert.ToString(number[i]).Length;
                if (templenth>maxlenth)
                {
                    maxlenth = templenth;
                    index = i;
                }
            }
            return number[index];
      }

    }
}
