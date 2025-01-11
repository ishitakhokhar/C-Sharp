using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class User
    {
        string Name;
        int age;
        string Email;
        string city;

        public User(string Name,int age,string Email,string city) {
            this.Name=Name;
            this.age=age;
            this.Email=Email;
            this.city=city;
        }
        public void display()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Enter Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Email");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter City");
                string city = Console.ReadLine();
            }
            if (age > 50)
            {
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Age : " + age);
                Console.WriteLine("Email : " + Email);
                Console.WriteLine("City : " + city);
            }   
        }
    }
}
