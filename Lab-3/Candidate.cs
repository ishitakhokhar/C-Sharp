using Lab_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Write a program to create a class named Candidate with ID, Name, Age,
//Weight and Height as data members & also create a member functions like
//GetCandidateDetails() and DisplayCandidateDetails(). 

namespace Lab_3
{
    internal class Candidate
    {
        int id;
        String name;
        int age;
        double height;
        double weight;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height : ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight : ");
            weight = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Height : " + height);
            Console.WriteLine("Weight : " + weight);
        }
    }


}
