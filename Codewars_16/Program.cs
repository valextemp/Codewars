using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            //Assert.AreEqual(13, MaxDiffLength.Mxdiflg(s1, s2));

            int max_s1 = s1.Max(s => s.Length);
            int min_s1= s1.Min(s => s.Length);

            int max_s2 = s2.Max(s => s.Length);
            int min_s2 = s2.Min(s => s.Length);

            int diff = new int[] { max_s1 - min_s2, max_s2 - min_s1 }.Max();
            int diff1 = new int[] { s1.Max(s => s.Length) - s2.Min(s => s.Length), s2.Max(s => s.Length) - s1.Min(s => s.Length) }.Max();
            int xx = Mxdiflg(s1, s2);


        }

        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length == 0 || a2.Length == 0)
                return -1;
            else 
                return new int[] { a1.Max(s => s.Length) - a2.Min(s => s.Length), a2.Max(s => s.Length) - a1.Min(s => s.Length) }.Max(); 
        }
    }
}
