using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Program to implement the following multiple inheritance using interface
//Interface : Gross
//Method- Gross_sal()
//Class : Salary
//Data Members - HRA, TA, DA
//Methods - Disp_sal()
//Class : Employee
//Data Members - Name
//Methods - basic_sal()
namespace Lab_3
{
    class Employee
    {
        public string name;
        public double basic_salary;

        public void basicSalary()
        {
            Console.WriteLine("Enter Employee Name : ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary : ");
            this.basic_salary = Convert.ToDouble(Console.ReadLine());
        }
    }
    interface Gross
    {
        void grossSalary();
    }
    class SalaryInterface : Employee, Gross
    {
        public double HRA;
        public double TA;
        public double DA;

        public void salary()
        {
            Console.WriteLine("Enter HRA : ");
            HRA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter TA : ");
            TA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter DA : ");
            DA = Convert.ToDouble(Console.ReadLine());
        }
        public void grossSalary()
        {
            double grossSalary = basic_salary + HRA + TA + DA;
            Console.WriteLine("Gross Salary: " + grossSalary);
        }
       
    }
}
