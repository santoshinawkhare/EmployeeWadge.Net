using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class UC8
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public void ComputeEmpWage(string Company, int EMP_RATE_PER_HOUR, int NUM_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_WORKING_DAYS)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " EmpHrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Monthly Employee Wage for Company : " + Company + " is : " + totalEmpWage);
        }
    }
}

