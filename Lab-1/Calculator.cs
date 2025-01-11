using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to create a Simple Calculator for two numbers (Addition,
//Multiplication, Subtraction, Division) [Also using if…else &Switch Case]


namespace Lab_1
{
    internal class Calculator
    {
        public void calc()
        {
            Console.WriteLine("Enter choice");
            char choice=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Number is : " + num1);

            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number is : " + num2);

            if (choice == '+')
            {
                Console.WriteLine("Addition : "+ (num1+num2));
            }
            else if (choice == '-')
            {
                Console.WriteLine("Substraction : "+ (num1-num2));
            }
            else if (choice == '*')
            {
                Console.WriteLine("Multiplication : " + (num1 * num2));
            }
            else if (choice == '/')
            {
                if (num2 != 0)
                {
                    Console.WriteLine("Addition : " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Can not divide by zero");
                }
               
            }

        }
    }

}