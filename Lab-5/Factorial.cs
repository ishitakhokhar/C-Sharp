using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Factorial
    {
        public static int Calculate(int n)
        {
            int fact = 1;
            for (int i = 2; i < n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}