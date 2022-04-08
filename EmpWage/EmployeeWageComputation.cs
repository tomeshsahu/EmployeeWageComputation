using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class EmployeeWageComputation
    {
        
      const int EMP_FULL_TIME = 1;
      const int EMP_PART_TIME= 2;
      const int empRatePerHrs = 20;
        public void Tomesh()
        {
            int salary = 0;
            int empHrs = 0;

            Random random = new Random();
            int Check = random.Next(0, 3);

            switch (Check)
            {
                case EMP_FULL_TIME:
                    empHrs = 8;
                    break;

                case EMP_PART_TIME:
                    empHrs = 4;
                    break;

                default:
                    empHrs = 0;
                    break;

                }
                salary = empHrs* empRatePerHrs;
                Console.WriteLine("Employee Salary" + " " + salary );
                 
        }
    }
}
