using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Compare("ssss", "dddd");
            Console.ReadLine();
        }

        public static bool Compare(string s1, string s2)
        {
            
            string mys1, mys2;
            if (String.IsNullOrEmpty(s1)|| ! Regex.IsMatch(s1, "^[A-Za-z]+$")) mys1 = "";
            else mys1 = s1.ToUpper();

            if (String.IsNullOrEmpty(s2)|| !Regex.IsMatch(s2, "^[A-Za-z]+$")) mys2 = "";
            else mys2 = s2.ToUpper();

            Encoding strascii = Encoding.ASCII;

            byte[] mybytes1 = strascii.GetBytes(mys1);
            byte[] mybytes2 = strascii.GetBytes(mys2);

            int sumstr1 = mybytes1.Sum(p => p);
            int sumstr2 = mybytes2.Sum(p => p);

            if (sumstr1 == sumstr2) return true;
            else return false;
        }


    }
}
