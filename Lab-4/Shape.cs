using Lab_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to create interface named Shape.In this interface, we
//have three methods Circle(), Triangle() and Square() which calculates area
//of Circle, Triangle and Square respectively. Implement Shape interface

namespace Lab_4
{
    internal interface Shape
    {
        public double Circle(double r);
        public double Triangle(double br, double h);
        public double Square(double l);
    }
    class Area : Shape
    {
        public double Circle(double r)
        {
            return Math.PI * r * r;
        }
          public double Triangle(double br, double h)
        {
            return br * h * 0.5;
        }
        public double Square(double l)
        {
            return l * l;
        }
    }
}
