using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to create interface Calculate. In this interface we have two
//member functions Addition() and Subtraction(). Implements this interface
//in another class named Result.
namespace Lab_4
{
    internal interface Calculator
    {
        int add(int a, int b);
        int sub(int a, int b);
    }
    class Result : Calculator
    {
        public int add(int a, int b)
        {
            return a + b;

        }
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
}