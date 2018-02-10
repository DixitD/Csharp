using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_q2
{
    class HR : Employee
    {

        private int Experience;
        private  int b_salary;
        public HR() { }
        public HR(int Experience,int b_salary)
        {
            this.Experience=Experience;
            this.b_salary=b_salary;
        }
        public override int salary()
        {
            int HRsalary=b_salary + (1000 * Experience);
            return HRsalary;
        }
    }
}
