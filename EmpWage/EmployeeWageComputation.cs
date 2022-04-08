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
        int FullTimeWorkingHrs = 8;
        int PartTimeWorkingHrs = 4;
        int EmpWorkingHrs = 20;
        public void Tomesh()
        {
           Random random=new Random();
            int Check = random.Next(0, 2);
            if (Check == EmpFullTime)
            {
                int Salary = (FullTimeWorkingHrs * EmpWorkingHrs);
                Console.WriteLine("Employee is Working Fulltime" + "Salary" +" " + Salary);
            }
            else if(Check == PartTimeWorkingHrs)
            {
                int Salary = (PartTimeWorkingHrs * EmpWorkingHrs);
                Console.WriteLine("Employee is Working PartTime" + "Salary"+ " " + Salary);
            }
            else
                Console.WriteLine("Absent");
        }
    }
}
