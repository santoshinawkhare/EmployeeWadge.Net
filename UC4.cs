using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class UC4
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

      public void Case()
        {
            const int EMP_RATE_PER_HOURE = 20;
            int empHrs = 0;
            int empWages = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

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
            empWages = empHrs * EMP_RATE_PER_HOURE;
            Console.WriteLine("Employee Daily Wages :" + empWages);
        }  
    }
}
