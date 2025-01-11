using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Reflection;

//Create an ArrayList for StudentName and perform following operations:
//a.Add() - To Add new student in list
//b.Remove() - To Remove Student with specified index
//c. RemoveRange() - To Remove student with specified range.
//d. Clear() - To clear all the student from the list


namespace Lab_6
{
    internal class StudentArrayList
    {
        public void Demo()
        {
            ArrayList studentName = new ArrayList();
            Console.WriteLine("1. Add new student : ");
            Console.WriteLine("2. Remove student with specified index : ");
            Console.WriteLine("3. Remove student with specified range : ");
            Console.WriteLine("4. Clear all the student from the list : ");

            while (true)
            {
                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Enter name of student : ");
                        String name = Console.ReadLine();
                        studentName.Add(name);
                        print(studentName);
                        Console.WriteLine("Student Added Successfully");
                        break;

                    case 2:
                        Console.WriteLine("Enter index : ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        studentName.RemoveAt(index);
                        print(studentName);
                        Console.WriteLine("Student Remove Successfully");
                        break;

                    case 3:
                        Console.WriteLine("Enter Starting range : ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter ending range : ");
                        int end = Convert.ToInt32(Console.ReadLine());
                        studentName.RemoveRange(start, end);
                        print(studentName);
                        Console.WriteLine("Student Remove Successfully");
                        break;

                    case 4:
                        studentName.Clear();
                        print(studentName);
                        Console.WriteLine("All student are clear Successfully");
                        break;
                }
            }
        }
        static void print(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}