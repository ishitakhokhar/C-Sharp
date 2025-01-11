using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Body Mass Index (BMI) is a measure of health on weight. It can be
//calculated by taking your weight in kilograms and dividing by the square of
//your height in meters. Write a program that prompts the user to enter a
//weight in pounds and height in inches and displays the BMI.
//(Note: -1 pound = 0.45359237 Kg and 1 inch = 0.0254 meters)


namespace Lab_2
{
    internal class BMI
    {
        public void Weight()
        {
            Console.WriteLine("Enter weight in pound : ");
            double pound=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height in Inches : ");
            double inches=Convert.ToDouble(Console.ReadLine());

            double w = pound * 0.45359237;
            double h = inches * 0.0254;

            Console.WriteLine("Body Index Mass : "+(w/(h*h)));
        }
    }
}
