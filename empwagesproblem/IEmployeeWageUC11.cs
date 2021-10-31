using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    interface IEmployeeWageUC11
    {
        public void addCompany(string company, int empRatePerHr, int numWorkingDays, int maxHrsInMonth);
        public void ComputeEmpWage();
    }
}
