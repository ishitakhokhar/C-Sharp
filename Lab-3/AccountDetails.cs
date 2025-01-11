using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

//Write a program for implementing single inheritance which creates one
//class Account_Details for getting account information and another class
//Interest for calculating and displaying total interest from the data inserted
//from account details

namespace Lab_3
{
    internal class AccountDetails
    {
        public int accountNumber;
        public string userName;
        public string email;
        public string type;
        public double balance;

        public AccountDetails()
        {
            Console.WriteLine("Enter Account Number : ");
            this.accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User Name : ");
            this.userName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            this.email = Console.ReadLine();
            Console.WriteLine("Enter Type : ");
            this.type = Console.ReadLine();
            Console.WriteLine("Enter Balance : ");
            this.balance = Convert.ToDouble(Console.ReadLine());
        }
    }
        class Interest : AccountDetails
        {
            public double time;
            public double rate;

            public Interest()
            {
                Console.WriteLine("Enter Time : ");
                this.time = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Rate : ");
                this.rate = Convert.ToDouble(Console.ReadLine());
            }

            public void displayDetail()
            {
                Console.WriteLine("Total Interest : "+(balance*time*rate)/100);
            }
        }
    
}





