using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME!");
            UC1 userCase1 = new UC1();
            userCase1.Attendance();

            UC2 userCase2 = new UC2();
            userCase2.DailyWages();

            UC3 userCase3 = new UC3();
            userCase3.Parttime();

            UC4 useCase4 = new UC4();
            useCase4.Case();

            UC5 userCase5 = new UC5();
            userCase5.MonthlyWages();

            UC6 useCase6 = new UC6();
            useCase6.Condition();
        }
    }
}
