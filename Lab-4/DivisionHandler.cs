using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to Create a divide by zero exception and handle it.

namespace Lab_4
{
    internal class DivisionHandler
    {
        public void Divide()
        {
            Console.WriteLine("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                int ans = num / 0;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}