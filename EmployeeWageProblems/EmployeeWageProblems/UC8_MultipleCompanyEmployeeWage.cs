using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public class UC8_MultipleCompanyEmployeeWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int ComputeEmpWage(string company, int empRatePerHour, int NumOfWorkingDays, int MaxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= MaxHoursPerMonth && totalWorkingDays <= NumOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + "Emp Hrs" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Salary for Company " + company + "   is:" + totalEmpWage);
            return totalEmpWage;
        }
        public void TotalsalaryForMultipleCompanies()
        {
            ComputeEmpWage("DMart ", 20, 2, 10);
            ComputeEmpWage("Amazon ", 10, 4, 20);
        }
    }
}

