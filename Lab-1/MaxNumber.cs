using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class MaxNumber
    {
        public void number()
        {
            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Number is : " + num1);

            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number is : " + num2);

            Console.WriteLine("Enter Third Number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third Number is : " + num2);

            int max = (num1 > num2) ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            Console.WriteLine("Max number is : " + max);
        }
    }
}
    