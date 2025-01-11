using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to calculate the nPr. (nPr = n! / (n - r)!)

namespace Lab_2
{
    internal class _nPr
    {
        public void Calculate()
        {
            Console.WriteLine("Enter N : ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter R : ");
            int r=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + "P" + r + " = "
                       + nPr(n, r));
        }
        static int fact(int n)
        {
            if(n<=1)
            {
                return 1;
                return n * fact(n - 1);
            }
        }
        static int npr(int n,int r) {
            return fact(n) / fact(n - r);
        }
}
