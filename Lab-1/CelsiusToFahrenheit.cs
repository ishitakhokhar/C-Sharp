using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Ta sks;
namespace Lab_1
{

//    Write a program to calculate Celsius to Fahrenheit and vice-versa using
//function.
    internal class Celsius_to_Fahrenheit
    {
        public void CelToFer()
        {
            Console.WriteLine("Enter  temperature in Celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * (9 / 5) + 32;
            Console.WriteLine("Temperature in fahrenheit is : " + fahrenheit);
        }
        public void FerToCel()
        {
            Console.WriteLine("Enter  temperature in Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in celsius is : " + celsius);
        }
    }
}
