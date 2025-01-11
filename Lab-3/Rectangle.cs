using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to calculate area of a Rectangle using constructor.

namespace Lab_3
{
    internal class Rectangle
    {
        public double length;
        public double width;
        public double result;

        public Rectangle()
        {
            Console.WriteLine("Enter Length : ");
            this.length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width");
            this.width = Convert.ToDouble(Console.ReadLine());
        }

        public void Calculate()
        {
            result = length * width;
            Console.WriteLine("Result : " + result);

        }
    }
}
