using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_q2
{
    abstract class Employee
    {
        int ID;
        string name;
        string Designation;
        int Experience;
        int A_salary;
        string join_date;
        public abstract  int salary();
    }
}
