using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            float X = 0.06f;
            float Y = 5.94f;
            Console.WriteLine("X= " + X + "  Y=" + Y);
            Console.WriteLine("1.Sum of X & Y=" + (X + Y));

            if ((X + Y).Equals(6))
            {
                Console.WriteLine("2.Yes,X + Y = 6 is right.");
            }
            else
            {
                Console.WriteLine("2.x + y=6 is wrong");
            }
            int x = X.CompareTo(Y);
            if (x == 0)
            {
                Console.WriteLine("3.X and Y both are equal.");
            }
            else if (x == -1)
            {
                Console.WriteLine("3.X is less than Y");
            }
            else
            {
                Console.WriteLine("3.X is Greater than Y");
            }
            Console.ReadLine();
        }
    }
}

