using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class FibonaciSeries
    {
        public void Fibonaci()
        {
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine("Enter number");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);

            for(int i=2;i<number;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }

        }
    }

}
