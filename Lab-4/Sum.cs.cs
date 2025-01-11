using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to create an abstract class Sum having abstract methods
//SumOfTwo(int a, int b) and SumOfThree(int a, int b, int c). Create another
//class Calculate which extends the abstract class and implements the
//abstract methods.

namespace Lab_4
{
    internal abstract class Sum
    {
        public abstract int SumOfTwo(int a, int b);
        public abstract int SumOfThree(int a, int b, int c);
    }
    class Calc:Sum
    {
        public override int SumOfTwo(int a, int b)
        {
            return a + b;
        }
        public override int SumOfThree(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
