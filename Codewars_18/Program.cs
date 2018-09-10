using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_18
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string greet(string name)
        {
            if (string.IsNullOrEmpty(name)) 
            {
                return null;
            }
            else
            {
                return string.Format("hello {0}!", name);
            }
          
        }

    }
}
