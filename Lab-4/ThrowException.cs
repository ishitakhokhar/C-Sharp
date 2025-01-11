using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to accept a number from the user and throw an exception
//if the number is not an even number.

namespace Lab_4
{
    internal class ThrowException
    {
        public void Throw()
        {
            Console.WriteLine("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (num % 2 != 0)
                {
                    throw new Exception("Number must be even");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurd");
            }
        }
    }
}
