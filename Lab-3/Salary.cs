using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to Define a class Salary which will contain member
//variable Basic, TA, DA, HRA. Write a program using Constructor with default
//values for DA and HRA and calculate the salary of employee.

namespace Lab_3
{
    internal class Salary
    {
        public double TA;
        public double DA;
        public double HRA;

        public Salary()
        {
            Console.WriteLine("Enter TA : ");
            TA = Convert.ToDouble(Console.ReadLine());
            DA = 0.3;
            HRA = 0.4;
        }

        public void CalculateSalary() 
        {
            Console.WriteLine("Total Salary : " + (TA + DA + HRA));
        }
    }
}
