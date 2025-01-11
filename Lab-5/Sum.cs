using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program using method overloading by changing datatype of
//arguments to perform addition of two integer numbers and two float
//numbers.

namespace Lab_5
{
    internal class Sum
    {
        public int sum(int a, int b)
        {
            return a + b;
        }
        public double sum(double a, double b)
        {
            return a+ b;
        }
    }
}
