using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class UC5
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public void MonthlyWages() 
        {
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_WORKING_DAYS = 20;
            int empHrs = 0;
            int empWages = 0;
            int totalEmployeeWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

           for (int i= 0; i < NUM_WORKING_DAYS; i++)
            {
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                empWages = empHrs * EMP_RATE_PER_HOUR;
                totalEmployeeWage += empWages;
                Console.WriteLine("Employee Wage :" + empWages);
            }
            Console.WriteLine("Total Employee Wages :" + totalEmployeeWage);
        }

    }
}
