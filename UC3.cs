using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class UC3
    {
       public const int IS_FULL_TIME = 1;
       public const int IS_PART_TIME = 2;

        public void Parttime()
        {
            const int EMP_RATE_PER_HOUR = 20;
            int empHr = 0;
            int empWages = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                empHr = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHr = 4;
            }
            else
            {
                empHr = 0;
            }
            empWages = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("empWages part time :" + empWages);

        }
    }
}
