using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    internal class UC4_SwitchCase_Statement
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void EmployeeWagesUsingSwitch()
        {
            int empHrs = 0;
            int Empwage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0;
                    break;
            }
            Empwage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emplyoee Wages :" + Empwage);
        }


    }
}
