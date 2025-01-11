using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Armstrong
    {
        public void armstrong()
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int orignalnumber = num;
            int sum = 0;
            int length=num.ToString().Length;

            while (num > 0)
            {
                int digit=num%10;
                sum += (int)Math.Pow(digit, length);
                num /= 10;
            }
            if (orignalnumber == sum)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            
                {
                Console.WriteLine("Number is not Armstrong");
            }
        }
    }
}
