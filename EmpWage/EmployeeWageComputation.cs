using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class EmployeeWageComputation
    {
        int EmpFullTime = 1;
        public void Tomesh()
        {
           Random random=new Random();
            int Check = random.Next(0, 2);
            if (Check == EmpFullTime)
                Console.WriteLine("Present");
            else
                Console.WriteLine("Absent");
        }
    }
}
