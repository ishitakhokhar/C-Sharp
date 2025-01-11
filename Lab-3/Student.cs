using Lab_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

//Write a program with following specifications:
//Class Name: Student
//Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
//Get Students Details using constructor and DisplayStudentDetails() using
//member function

namespace Lab_3
{
    internal class Student
    {
        double Enrollment_no;
        string Student_Name;
        int Semester;
        double CPI;
        double SPI;

        public Student()
        {
            Console.WriteLine("Enter Enrollment Number : ");
            this.Enrollment_no = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter StudentName : ");
            this.Student_Name = Console.ReadLine();
            Console.WriteLine("Enter Semester : ");
            this.Semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter CPI : ");
            this.CPI = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter SPI : ");
            this.SPI = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Enrollment Number : " + this.Enrollment_no);
            Console.WriteLine("StudentName : " + this.Student_Name);
            Console.WriteLine("Semester : " + this.Semester);
            Console.WriteLine("CPI : " + this.CPI);
            Console.WriteLine("SPI : " + this.SPI);
        }
    }
}
