using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Student
    {
        public void getDetails()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Marks of first Subject : ");
                int marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Marks of Second Subject : ");
                int marks2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Marks of Second Subject : ");
                int marks3 = Convert.ToInt32(Console.ReadLine());
            }
           
        }
    }
}
