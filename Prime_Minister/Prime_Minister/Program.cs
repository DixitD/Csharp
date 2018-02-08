using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Prime_Minister
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                { "ABV", new PrimeMinister("Atal Bihari Vajpayee", "1998")},
                { "NM", new PrimeMinister("Narendra Modi", "2014") },
                { "MS", new PrimeMinister("Manmohan Singh", "2004")}

            };

            Console.WriteLine("\n1.Prime Minister in 2004:\n");
            foreach (var p in primeMinisters.Values)
            {
                if (p.year.Equals("2004"))
                {
                    Console.WriteLine(p.name);
                    break;
                }
            }

            Console.WriteLine("\n2.Added Current Prime Minister:\n");
            primeMinisters.Add("NMO", new PrimeMinister("Narendra Modi", "2018"));
            foreach (var p in primeMinisters.Values)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n3.Read-Only Dictionary:\n");
            var readon = new ReadOnlyDictionary<string, PrimeMinister>(primeMinisters);
            foreach (var p in readon.Values)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n4.Sorted Dictionary:\n");
       
            primeMinisters = primeMinisters.OrderBy(y => y.Value.year).ToDictionary(p => p.Key, p =>p.Value);
            foreach (var p in primeMinisters.Values)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();

        }
    }
}
