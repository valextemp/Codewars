using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            var mystart=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var myend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество цифр равно = "+ DontGiveMeFive(mystart, myend));
            Console.ReadKey();
            
        }

        public static int DontGiveMeFive(int start, int end)
        {
            int number = 0;
            if (start < end)
            {
                for (int x = start; x <= end; x++)
                {
                    if (x.ToString().IndexOf('5') == -1) number++;
                }
            }
            return number;
        }

    }
}
