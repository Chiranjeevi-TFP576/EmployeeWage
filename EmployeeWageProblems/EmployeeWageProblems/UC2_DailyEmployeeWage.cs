using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
   class UC2_DailyEmployeeWage
    {
        public static void DailyWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int Empwage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            Empwage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(" Daily Wage: " + Empwage);
        }
    }
}
