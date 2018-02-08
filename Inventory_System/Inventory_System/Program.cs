using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productlist = new List<Product>()
            {
                new Product(){ Name="lettuce",Price=10.5,Quantity=50,Type="Leafy green"},
                new Product(){ Name="cabbages",Price=20,Quantity=100,Type="Cruciferous"},
                new Product(){ Name="pumpkin",Price=30,Quantity=30,Type="Marrow"},
                new Product(){ Name="cauliflower",Price=10,Quantity=25,Type="Cruciferous"},
                new Product(){ Name="zucchini",Price=20.5,Quantity=50,Type="Marrow"},
                new Product(){ Name="yam",Price=30,Quantity=50,Type="Root"},
                new Product(){ Name="spinach",Price=10,Quantity=100,Type="Leafy green"},
                new Product(){ Name="broccoli",Price=20.2,Quantity=75,Type="Cruciferous"},
                new Product(){ Name="Garlic",Price=30,Quantity=20,Type="Leafy green"},
                new Product(){ Name="silverbeet",Price=10,Quantity=50,Type="Marrow"},
            };
            Console.WriteLine("1.Total No. Of Product:" + productlist.Count);

            productlist.Add(new Product() { Name = "Potato", Price = 10, Quantity = 50, Type = "Root" });
            Console.WriteLine("\n2.Total No. Of Product after adding potato:" + productlist.Count);

            Console.WriteLine("\nProduct List:");
            foreach (Product p in productlist)
            {
                Console.WriteLine("Name:{0}| Price:{1}RS| Quantity:{2}| Type:{3}", p.Name, p.Price, p.Quantity, p.Type);
            }

            Console.WriteLine("\n3.Product type is Leafy Green:");
            foreach (Product p in productlist)
            {
                string type = "Leafy green";
                if (p.Type.Equals(type))
                {
                    Console.WriteLine("Name:{0}| Price:{1}RS| Quantity:{2}| Type:{3}", p.Name, p.Price, p.Quantity, p.Type);
                }
            }

            var itemToRemove = productlist.Single(r => r.Name == "Garlic");
            productlist.Remove(itemToRemove);
            Console.WriteLine("\n4.Total No. Of Product after deletion of (garlic):" + productlist.Count);

            Console.WriteLine("\n5.Qauntity of Cabbage after adding 50 cabbage:");
            foreach (Product p in productlist)
            {
                if (p.Name.Equals("cabbages"))
                {
                    p.Quantity = p.Quantity + 50;
                    Console.Write(p.Quantity);
                }
            }
            Console.WriteLine();
            double price = 0;
            foreach (Product p in productlist)
            {

                if (p.Name.Equals("lettuce"))
                {
                    price = price + p.Price;
                }
                if (p.Name.Equals("zucchini"))
                {
                    price = price + p.Price * 2;
                }
                if (p.Name.Equals("broccoli"))
                {
                    price = price + p.Price;
                }
            }
            Console.WriteLine("\n6.Total Price of 1kg lettus,2kg zucchini,1kg broccoli:" + (int)price);
            Console.ReadKey();
        }
    }
}
