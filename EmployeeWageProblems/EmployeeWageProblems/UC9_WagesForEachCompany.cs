using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    internal class UC9_WagesForEachCompany
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numofWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public UC9_WagesForEachCompany(string company, int empRateHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRateHour;
            this.numofWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numofWorkingDays)
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
                Console.WriteLine("Day: " + totalWorkingDays + "Hrs" + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company:" + company + "is:" + totalEmpWage);
        }
        public string tostring()
        {
            return "Total Emp Wage for Company :" + this.company + "is:" + this.totalEmpWage;
        }
    }
}
