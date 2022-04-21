using System;
using EmpWage;

class program
{

    public static void Main(string[] args)
    {
        EmployeeWageComputation company = new EmployeeWageComputation();
        company.Compute("xamptech", 20, 100, 20);
        company.Compute("DMart", 10, 20, 30);

    }
}