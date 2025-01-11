using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Marks
    {
        public void Mark() {
            Console.WriteLine("Enter marks of subject 1");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of subject 2");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of subject 3");
            double s3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of subject 4");
            double s4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of subject 5");
            double s5 = Convert.ToDouble(Console.ReadLine());

            double total = s1 + s2 + s3 + s4 + s5;

            double marks = (total * 100) / 500;

            if (marks >= 60)
            {
                Console.WriteLine("First division");
            }
            else if (marks >= 50 && marks <= 59)
            {
                Console.WriteLine("Second division");
            }
            else if (marks >= 40 && marks <= 49)
            {
                Console.WriteLine("Third division");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
