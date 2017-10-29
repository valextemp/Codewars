using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_5
{
    class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0) return new double[1] { 0 };
            double[] temarray = new double[n];
            if (n == 1)
              {  temarray[0] = signature[0];
                return temarray;
              }
            if (n==2)
            {
                temarray[0] = signature[0];
                temarray[1] = signature[1];
                return temarray;
            }
            
            // hackonacci me
            // if n==0, then return an array of length 1, containing only a 0
            temarray[0] = signature[0];
            temarray[1] = signature[1];
            temarray[2] = signature[2];

            for (int i = 3; i < n; i++)
            {
                temarray[i] = temarray[i - 1] + temarray[i - 2] + temarray[i - 3];

            }
            return temarray;

        }
    }

}

