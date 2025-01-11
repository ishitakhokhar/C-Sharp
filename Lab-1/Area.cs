using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to calculate area of Square, Rectangle and Circle.

namespace Lab_1
{
    internal class Area
    {  
        public void CalculateCirculeArea()
        {
            Console.WriteLine("Enter radius : "); 
            double radius = Convert.ToDouble(Console.ReadLine());
            double area =3.14 * radius * radius;
            Console.WriteLine("Area of circle is : " + area);
        }
        public void CalculateSquareArea()
        {
            Console.WriteLine("Enter length : ");
            double length = Convert.ToDouble(Console.ReadLine());
            double area = length * length;
            Console.WriteLine("Area of square is : " + area);
        }
        public void CalculateRectangleArea()
        {
            Console.WriteLine("Enter length : ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width : ");
            double width = Convert.ToDouble(Console.ReadLine());
            double area = length* width;
            Console.WriteLine("Area of reactangle is : " + area);
        }
    }
}
