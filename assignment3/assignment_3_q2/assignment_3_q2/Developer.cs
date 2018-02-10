using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_q2
{
    class Developer : Employee
    {
        private int Experience;
        private int b_salary;
        public Developer() { }
        public Developer(int Experience,int b_salary)
        {
            this.Experience=Experience;
            this.b_salary=b_salary;
        }
        public override int salary()
        {
            int devsalary=this.b_salary + (2000 * this.Experience);
            return devsalary;
        }
    }
}
