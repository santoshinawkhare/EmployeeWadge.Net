﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class UC1
    {
        const int IS_FULL_TIME = 1;
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("emp is present");
            }
            else {
                Console.WriteLine("emp is Absent");
            }
        }
    }
}
