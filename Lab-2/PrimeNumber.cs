using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to check prime number

namespace Lab_2
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter Number");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);

            if(number % 2 == 0)
            {
                Console.WriteLine("Number is not prime");
            }
            else
            {
                {
                    Console.WriteLine("Number is prime");
                }
            }
        }
    }
}
