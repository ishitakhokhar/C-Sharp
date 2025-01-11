using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//Create a Stack which takes integer values and perform following
//operations:
//a.Push() - To Add new item in stack
//b.Pop() - To Remove item from the stack
//c. Peek() – To Return the top item from the stack.
//d. Contains() - To Checks whether an item exists in the stack or not.
//e. Clear() - To clear items from stack

namespace Lab_6
{
    internal class StackDemo
    {
        public void Run()
        {
            Stack stack = new Stack();
            Console.WriteLine("1. Add new item in stack : ");
            Console.WriteLine("2. To Remove item from the stack ");
            Console.WriteLine("3. To Return the top item from the stack.");
            Console.WriteLine("4.  To Checks whether an item exists in the stack or not.");
            Console.WriteLine("5. To clear items from stack");

            while (true)
            {
                Console.WriteLine("Enter choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        stack.Push(num);
                        print(stack);
                        break;

                    case 2:
                        stack.Pop();
                        print(stack);
                        break;

                    case 3:
                        stack.Peek();
                        print(stack);
                        break;

                    case 4:
                        Console.WriteLine("Stack Contain element or not ?");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        stack.Contains(num1);
                        break;

                    case 5:
                        stack.Clear();
                        break;
                }

            }
        }
        static void print(Stack stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}