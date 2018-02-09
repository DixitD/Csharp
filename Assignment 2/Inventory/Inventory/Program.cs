using System;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = new List<string>
            { "Tomato","Potato","ToMato","Potato","Red Tomato","Tomato Catchup","Grapes","grapes","potato"};
            string str = "tomato";
            var count= 0;
            Console.WriteLine("Total No of Count of tomato in list:");
            foreach (string i in inventory)
            {
                if (string.Equals(i, str, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            Console.WriteLine("Index of Potato in List:");
                for(int i = 0; i < inventory.Count; i++)
                {
                   
                    if (inventory[i].Equals("Potato"))
                    {
                        Console.WriteLine(i);
                    }
                }
            
            Console.ReadKey();
        }
    }
}
