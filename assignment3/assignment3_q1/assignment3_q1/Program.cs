using System;
using System.Collections.Generic;

namespace assignment3_q1
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
            Console.WriteLine("1.(1).Leafy green,(2).Marrow,(3).Cruciferous,(4).Root");
            Console.WriteLine("Enter Your Choice:");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    foreach (Product p in productlist)
                    {
                        string type = "Leafy green";
                        if (p.Type.Equals(type))
                        {
                            Console.WriteLine("Name:{0}| Price:{1}RS| Quantity:{2}| Type:{3}", p.Name, p.Price, p.Quantity, p.Type);
                        }
                    }
                    break;

                case 2:
                    foreach (Product p in productlist)
                    {
                        string type = "Marrow";
                        if (p.Type.Equals(type))
                        {
                            Console.WriteLine("Name:{0}| Price:{1}RS| Quantity:{2}| Type:{3}", p.Name, p.Price, p.Quantity, p.Type);
                        }
                    }
                    break;

                case 3:
                    foreach (Product p in productlist)
                    {
                        string type = "Cruciferous";
                        if (p.Type.Equals(type))
                        {
                            Console.WriteLine("Name:{0}| Price:{1}RS| Quantity:{2}| Type:{3}", p.Name, p.Price, p.Quantity, p.Type);
                        }
                    }
                    break;

                case 4:
                    foreach (Product p in productlist)
                    {
                        string type = "Root";
                        if (p.Type.Equals(type))
                        {
                            Console.WriteLine("Name:{0}| Price:{1}RS| Quantity:{2}| Type:{3}", p.Name, p.Price, p.Quantity, p.Type);
                        }
                    }
                    break;
            }

               double price = 0;
               foreach (Product p in productlist)
                {
                   price = price + p.Quantity * p.Price;
                }
            Console.WriteLine("\n2.Total Price of whole Inventory including quantities of product:" + price);
   
            int qu = 0;
            foreach (Product p in productlist)
            {
                qu = qu + p.Quantity;
            }
            double avg = price/qu;
            Console.WriteLine("\n3.Average Price of products:" + avg);
            Console.WriteLine("\n4.(1).Costly Products, (2).Chip Products");
            Console.WriteLine("enter your Choice:");
            int y = int.Parse(Console.ReadLine());
            switch (y)
            {
                case 1:
                    foreach (Product p in productlist)
                    {
                        if (p.Price > 50)
                        {
                            Console.WriteLine("Name:{0}| Price:{1}RS| Quantity:{2}| Type:{3}", p.Name, p.Price, p.Quantity, p.Type);
                        }
                        else
                        {
                           Console.WriteLine("There is no any Costly Products in Inventory");
                            break;
                        }
                    }
                    break;

                case 2:
                    foreach (Product p in productlist)
                    {
                        if (p.Price < 50)
                        {
                            Console.WriteLine("Name:{0}| Price:{1}RS| Quantity:{2}| Type:{3}", p.Name, p.Price, p.Quantity, p.Type);
                        }
                        else
                        {
                            Console.WriteLine("There is No any Chip Product in inventory");
                        }
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
