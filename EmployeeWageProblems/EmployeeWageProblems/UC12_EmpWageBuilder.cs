﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public class UC12_EmpWageBuilder : IEmployee
    {
        
        
            public const int IS_PART_TIME = 1;
            public const int IS_FUL_TIME = 2;

            private int numOfCompany = 0;
            private LinkedList<CompanyEmpWage> companyEmpWageList;

            public UC12_EmpWageBuilder()
            {
                this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            }

            public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
                this.companyEmpWageList.AddLast(companyEmpWage);
            }

            public void computeEmpWage()
            {
                foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
                {
                    companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                    Console.WriteLine(companyEmpWage.toString());
                }
            }
            private int computeEmpWage(CompanyEmpWage companyEmpWage)
            {
                int empHrs = 0, totalHr = 0, totalWorkingDays = 0;

                while (totalHr <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FUL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalHr += empHrs;
                    Console.WriteLine("Days:  {0} and Employee Hrs: {1}", totalWorkingDays, empHrs);

                }
                return totalHr * companyEmpWage.empRatePerHour;
            }
        }
}