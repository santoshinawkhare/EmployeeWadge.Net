using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class UC6
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public void Condition()
        {
            const int EMP_RATE_PER_HOURE = 20;
            const int NUM_WOKING_DAYS = 20;
            const int  MAX_HOURS_IN_MONTH = 100;
            int empHr = 0;
            int totalEmpHr = 0;
            int totaWorkingDays = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            while (totalEmpHr <= MAX_HOURS_IN_MONTH && totaWorkingDays < NUM_WOKING_DAYS)
            {
                totaWorkingDays++;
                    switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;
                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                totalEmpHr += empHr;
                Console.WriteLine("Days: " + "" + totalEmpHr +  "EmpHrs :" + empHr);
            }
            int totalEmpWage = totalEmpHr * EMP_RATE_PER_HOURE;
            Console.WriteLine("Total Employree Wage :" + totalEmpWage);
        }
    }
}
