using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
     class UC1_EmployeePresentOrAbsent
    {
        public static void CheckEmployeeStatus()
        {
            int IS_FULL_TIME = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);//range(0,1)
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }

    }
}
