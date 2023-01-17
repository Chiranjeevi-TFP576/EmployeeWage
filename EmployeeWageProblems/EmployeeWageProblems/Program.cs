// See https://aka.ms/new-console-template for more information
using EmployeeWageProblems;

//Console.WriteLine("Welcome To EmployeeWage Computation Problems");

//UC1_EmployeePresentOrAbsent.CheckEmployeeStatus();
//UC2_DailyEmployeeWage.DailyWage();
//UC3_PartTimeWage.PartTimeWages();
//UC4_SwitchCase_Statement.EmployeeWagesUsingSwitch();
//UC5_Month_Wage.SalaryFor20DaysInMonth();
//UC6_TotalWorkingHoursandDays.EmpSalaryFor100Hrs();
//UC7_RefractorCodeOfEmployeeWage.ComputeSalaryUsingClassMethod();
//UC8_MultipleCompanyEmployeeWage.ComputeEmpWage("DMart ", 20, 2, 10);
//UC8_MultipleCompanyEmployeeWage.ComputeEmpWage("Amazon ", 10, 4, 20);
//UC9_WagesForEachCompany dmart = new UC9_WagesForEachCompany("Dmart", 20, 2, 10);
//dmart.computeEmpWage();
//Console.WriteLine(dmart.tostring());
//UC9_WagesForEachCompany Reliance = new UC9_WagesForEachCompany("Reliance", 20, 2, 10);
//Reliance.computeEmpWage();
//Console.WriteLine(Reliance.tostring());

//UC10_EmpWageBuilder empWageBuilder = new UC10_EmpWageBuilder();
//empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
//empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
//empWageBuilder.computeEmpWage();

//UC11_EmpWageBuilder empWageBuilder = new UC11_EmpWageBuilder();
//empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
//empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
//empWageBuilder.computeEmpWage();

//UC12_EmpWageBuilder empWageBuilder = new UC12_EmpWageBuilder();
//empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
//empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
//empWageBuilder.computeEmpWage();

EmpWageBuilder empWageBuilder = new EmpWageBuilder();
empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
empWageBuilder.computeEmpWage();
Console.WriteLine("Total Wage for Dmart company :{0} ", empWageBuilder.getTotalWage("Dmart"));
Console.WriteLine("Total Wage for Reliance company :{0} ", empWageBuilder.getTotalWage("Reliance"));