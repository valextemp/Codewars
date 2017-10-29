using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_7
{
    class Program
    {
        public static bool fff(int nnn)
        {
            return true;
           // return ((i % 3 = 0) or(i % 5 = 0));
        }
       public static int findSum(int n)
        {

            int ii = 0;
            //ii = Enumerable.Range(3, n).Sum(k=> ((k % 3==0) || ( k % 5==0)));
            //ii = Enumerable.Range(3, n).Sum(k => k>0);

            //ii = Enumerable.Range(3, n).Where(k => ((k % 3 == 0) || (k % 5 == 0))).Sum();
            //ii = Enumerable.Range(3, n).Where(k => ((k % 3 == 0) || (k % 5 == 0))).Select(f=>f).Sum();
            IEnumerable<int> nums = Enumerable.Range(1, n);
            Console.WriteLine("Input siquence equal");
            foreach (var item in nums)
            {
               Console.Write(item + " ");
                Console.WriteLine();
            }

            //IEnumerable<int> nums1=

            ii = Enumerable.Range(1, n).Where(k => (k % 3 == 0)|| (k % 5 == 0)).Sum();


            return ii;
        }

        // count = Enumerable.Range(0, int.MaxValue)
        static void Main(string[] args)
        {
            int e = 5;
            int dd = findSum(e);
            Console.WriteLine($"Сумма ряда до цифры {e} равнна {dd}");
            Console.ReadLine();

        }
    }
}
