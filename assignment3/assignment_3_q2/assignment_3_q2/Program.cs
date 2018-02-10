using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_q2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Developer DV = new Developer(5,8000);
            HR hr = new HR(4,8000);
            var a = hr.salary();
            var b = DV.salary();
            Console.WriteLine("Salary of HR:{0}",a);
            Console.WriteLine("Salary of Developer:{0}",b);
            Console.ReadLine();
        }
    }
}
