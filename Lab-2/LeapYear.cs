using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to find out whether a given year is a leap year or not.

namespace Lab_2
{
    internal class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("Enter year");
            int year=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(year);

            if ((year % 4 == 0 && year % 100 != 0)|| (year % 400 == 0)){
                Console.WriteLine("Leap year");

            }
            else
            {
                {
                    Console.WriteLine("Not Leap Year");
                }
            }
        }
    }
}
