using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assert.AreEqual(0, Kata.Gimme(new double[] { 2, 3, 1 }));
            //Assert.AreEqual(1, Kata.Gimme(new double[] { 5, 10, 14 }));
            int[] myar = new int[] { 2, 3, 1 };
            Array.Sort(myar);

            Gimme(new double[] { 2, 3, 1 });
            Console.ReadLine();
        }

        public static int Gimme(double[] inputArray)
        {
            double[] temparray=new double[inputArray.Length];
            inputArray.CopyTo(temparray,0);
            Array.Sort(temparray);
            for (int i=0; i<temparray.Length; i++)
            {
                Console.Write(temparray[i]+", ");
            }
            return 1;

            // Implement this function
        }

    }
}
