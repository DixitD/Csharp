using System;
using System.Collections.Generic;
using System.Linq;

namespace english_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wd = new string[] {"Boat","House","Cat","River","Cupboard"};
            Console.WriteLine("1.Plurals of all the words:");
            foreach (var i in wd)
            {
                Console.WriteLine(i + "s");
            }

            Console.WriteLine("\n2.Replaced 2nd word:");
            wd[1] = "Home";
            foreach (var i in wd)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n3.Added a new word:");
            List<string> wd1 = wd.ToList();
            wd1.Add("ABCDEFG");
            wd = wd1.ToArray();
            foreach (var i in wd)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n4.list of words which contains the length of characters as 7:");
            var wdlen = Array.FindAll(wd, i => i.Length == 7);
            foreach (var i in wdlen)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n5.3rd Word:");
            Console.WriteLine(wd[2]);

            Console.WriteLine("\n6.All the words are in Ascending Order:");
            Array.Sort(wd);
            foreach(var i in wd )
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n7.Reverse Array:");
            var rev = wd.Reverse();
            foreach (var i in rev)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
