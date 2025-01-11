using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a Hashtable collection class object and preform following
//operations:
//a.Add: Adds a key-value pair.
//b. Remove: Removes a key-value pair by key.
//c. ContainsKey: Checks if a key exists in the hashtable.
//d. ContainsValue: Checks if a value exists in the hashtable.
//e. Clear: Removes all key-value pairs.
namespace Lab_6
{
    internal class HashTableCollection
    {
        public void hashCollection()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Adds a key-value pair");
            Console.WriteLine("Removes a key-value pair by key.");
            Console.WriteLine("Checks if a key exists in the hashtable.");
            Console.WriteLine("Checks if a value exists in the hashtable.");
            Console.WriteLine("Removes all key-value pairs");

        

            while (true)
            {
                Console.WriteLine("Enter choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter key : ");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value : ");
                string value = Console.ReadLine();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add key value pair");
                        ht.Add(key, value);
                        print(ht);
                        Console.WriteLine("Key value pair added successfully");
                        break;

                    case 2:
                        Console.WriteLine("Removes key-value pair by key ");
                        ht.Remove(key);
                        print(ht);
                        break;

                    case 3:
                        Console.WriteLine("Checks if a key exists in the hashtable");
                        if (ht.Contains(key))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Checks if a value exists in the hashtable");
                        if (ht.Contains(value))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;

                    case 5:
                        ht.Remove(key);
                        print (ht);
                        break;
                }
            }
            static void print(Hashtable hashtable)
            {
                foreach (var item in hashtable)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}