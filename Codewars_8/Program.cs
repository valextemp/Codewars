using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_8
{
    class Program
    {
        public static string Likes(string[] name)
        {
            int intnames = name.Length;
            if (intnames == 0)
            {
                return "no one likes this";
            }
            switch (intnames)
            {
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                default:
                    return $"{name[0]}, {name[1]} and {(intnames - 2).ToString()} others like this";
            }

        }
        static void Main(string[] args)
        {
            //Assert.AreEqual("no one likes this", Likes(new string[0]));
            //Assert.AreEqual("Peter likes this", Likes(new string[] { "Peter" }));
            //Assert.AreEqual("Jacob and Alex like this", Likes(new string[] { "Jacob", "Alex" }));
            //Assert.AreEqual("Max, John and Mark like this", Likes(new string[] { "Max", "John", "Mark" }));
            //Assert.AreEqual("Alex, Jacob and 2 others like this", Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));

            Console.WriteLine("no one likes this = "+Likes(new string[0]));
            Console.WriteLine("Peter likes this = "+Likes(new string[] { "Peter" }));
            Console.WriteLine("Jacob and Alex like this = "+ Likes(new string[] { "Jacob", "Alex" }));
            Console.WriteLine("Max, John and Mark like this = "+Likes(new string[] { "Max", "John", "Mark" }));
            Console.WriteLine("Alex, Jacob and 2 others like this = "+Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));

            Console.ReadLine();


        }
    }
}
