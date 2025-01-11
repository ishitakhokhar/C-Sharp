using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program to Define a class Distance have data members dist1, dist2,
//dist3. Initialize the two data members using constructor and store their
//addition in third data member using function and display addition.

namespace Lab_3
{
    internal class Distance
    {
        public int dist1;
        public int dist2;
        public int dist3;

        public Distance()
        {
            Console.WriteLine("Enter Distance 1 : ");
            this.dist1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Distance 2 : ");
            this.dist2 = Convert.ToInt32(Console.ReadLine());
        }
        public void Addition()
        {
            dist3 = dist1 + dist2;
            Console.WriteLine("Total distance : " + dist3);
        }
    }
}
