using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string sss = "CodEWaRs";
            int[] arrayInt = Capitals(sss);
        }

        public static int[] Capitals(string word)
        {
            return  word.Select((wr, ind) => char.IsUpper(wr)?ind:-1).Where(w => w>=0).ToArray<int>();
         }

    }
}
