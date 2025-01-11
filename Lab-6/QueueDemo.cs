using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//Create a Queue which takes integer values and perform following
//operations:
//a.Enqueue() - Adds an item into the queue.
//b. Dequeuer() - Returns an item from the beginning of the queue and
// removes it from the queue.
//c. Peek() - Returns an first item from the queue without removing it.
//d. Contains() - Checks whether an item is in the queue or not
//e. Clear() - Removes all the items from the queue

namespace Lab_6
{
    internal class QueueDemo
    {
        public void Demo()
        {
            Queue queue = new Queue();

            Console.WriteLine("1. Adds an item into the queue.");
            Console.WriteLine("2. Returns an item from the beginning of the queue and removes it from the queue.");
            Console.WriteLine("3. Returns an first item from the queue without removing it.");
            Console.WriteLine("4. Checks whether an item is in the queue or not");
            Console.WriteLine("5.  Removes all the items from the queue");

            while (true)
            {
                Console.WriteLine("Enter choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter number : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        queue.Enqueue(num);
                        print(queue);
                        break;

                    case 2:
                        Console.WriteLine("First element : ");
                        queue.Dequeue();
                        print(queue);
                        break;

                    case 3:
                        Console.WriteLine("Top element : ");
                        queue.Peek();
                        print(queue);
                        break;

                    case 4:
                        Console.WriteLine("Stack Contain element or not ?");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        queue.Contains(num1);
                        break;

                    case 5:
                        queue.Clear();
                        break;
                }
            }
        }
        static void print(Queue queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}