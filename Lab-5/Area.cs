using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
//Write a program using method overloading by changing number of
//arguments to calculate area of square and rectangle.

namespace Lab_5
{
    internal class Area
    {
        public double FindArea(double l)
        {
            return l * l;
        }
        public double FindArea(double l,double b)
        {
            return l * b;
        }
    }
}
