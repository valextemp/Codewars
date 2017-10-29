using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_3
{
    class Program
    {

        //Переворот в строке букв наоборот если в слове больше 5 символов
        static void Main(string[] args)
        {

            string sss = SpinWords("hey everyone");

        }
        public static string SpinWords(string sentence)
        {
            //string[] split = words.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            string[] split = sentence.Split(new Char[] {' '});
            for (int i=0; i<=split.Length- 1; i++)
            {
                if (split[i].Length>5)
                {
                    char[] arr = split[i].ToCharArray();
                    Array.Reverse(arr);
                    split[i] = new string(arr);
                }

            }
            return String.Join(" ", split);

        }

    }
}
