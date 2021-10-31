using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME!");

            /* UC1 userCase1 = new UC1();
             userCase1.Attendance();*/

            /* UC2 userCase2 = new UC2();
             userCase2.DailyWages();*/

            /*  UC3 userCase3 = new UC3();
              userCase3.Parttime();*/

            /*UC4 useCase4 = new UC4();
            useCase4.Case();*/

            /*UC5 userCase5 = new UC5();
            userCase5.MonthlyWages();*/

            /*UC6 useCase6 = new UC6();
            useCase6.Condition();*/

            /*Uc7 useCase7 = new Uc7();
            useCase7.ComputeEmpWage();*/

            /*UC8 Usecase8 = new UC8();
            Usecase8.ComputeEmpWage("Dmart", 10, 20, 100);
            Usecase8.ComputeEmpWage("Reliance", 15, 25, 150);*/

            /* UC9 dmart = new UC9("Dmart", 10, 20, 100);
             UC9 reliance = new UC9("Reliance", 15, 25, 150);
             dmart.EmpWageBuilder();
             Console.WriteLine(dmart.toString());
             reliance.EmpWageBuilder();
             Console.WriteLine(reliance.toString());*/

            /* UC10 companylist = new UC10();
             companylist.addCompany("Dmart", 10, 20, 100);
             companylist.addCompany("Reliance", 15, 25, 150);
             companylist.ComputeEmpWage();*/

           /* UC11*/
            UC10 companyDetails = new UC10();
            companyDetails.addCompany("Dmart", 10, 20, 100);
            companyDetails.addCompany("Reliance", 15, 25, 150);
            companyDetails.ComputeEmpWage();
            Console.WriteLine("Total Wage for Dmart company :" + companyDetails.GetTotlaWage("Dmart"));
            Console.WriteLine("Total Wage for Reliance company :" + companyDetails.GetTotlaWage("Reliance"));
        }
    }
}
