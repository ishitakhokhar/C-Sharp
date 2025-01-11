using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads 5 numbers from user. Demonstrate concept of
////IndexOutOfRange Exception
///
namespace Lab_4
{
    internal class IndexException
    {
        public void Index()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Number : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter index : ");
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(arr[index]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}