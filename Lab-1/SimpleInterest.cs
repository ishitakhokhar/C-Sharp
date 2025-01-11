using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to find out Simple Interest using function. (I = PRN / 100)

namespace Lab_1
{
    internal class SimpleInterest
    {
        public void Interest()
        {
            Console.WriteLine("Enter principal number : ");
            double pnumber=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Principal number is : " + pnumber);

            Console.WriteLine("Enter rate value : ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rate value is : " + rate);

            Console.WriteLine("Enter time value : ");
            double time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Time value is : " + time);

            double interest = (pnumber * rate * time) / 100;
            Console.WriteLine("Interest is : " + interest);
        }
    }
}
