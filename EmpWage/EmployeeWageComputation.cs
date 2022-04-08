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
        const int EMP_PART_TIME = 2;
        const int empRatePerHrs = 20;
        const int WorkingDay = 20;
        public void Tomesh()
        {
            int salary = 0;
            int empHrs = 0;
            int totalSalary = 0;
            int totalHrs = 0;
            for (int day = 1; day <= 20; day++)
            {
                while (totalHrs < 100)
                {
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
                    totalHrs = totalHrs + empHrs;
                    salary = empHrs * empRatePerHrs;
                    totalSalary = totalSalary + salary;
                    Console.WriteLine("Day" + day + " " + "Salary" + " " + salary);
                }
            }
            Console.WriteLine("Total Salary" + " " +totalSalary);
        }
    }
}
