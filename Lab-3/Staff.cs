using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to create a class Staff having data members as Name,
//Department, Designation, Experience & Salary. Accept this data for 5
//different staffs and display only names & salary of those staff who are
//HOD.

namespace Lab_3
{
    internal class Staff
    {
        String Name;
        String Department;
        String Designation;
        int Experirnce;
        double Salary;
 
        public Staff(String Name,String Designation,double Salary) 
        { 
            this.Name = Name;
            this.Designation = Designation;
            this.Salary = Salary;
        }
        public void display()
        {
            if(Designation=="HOD")
            {
                Console.WriteLine("Name : "+ Name +"Salary : " + Salary);
            }
        }
    }
}
