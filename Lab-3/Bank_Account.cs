using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a pogram to Create a class Bank_Account with Account_No, Email,
//User_Name, Account_Type and Account_Balance as data members. Also
//create a Member function GetAccountDetails() & DisplayAccountDetails().

namespace Lab_3
{
    internal class Bank_Account
    {
        int Account_No;
        String Email;
        String User_Name;
        String Account_Type;
        double Account_Balance;

        public void GetAccountBalance()
        {
            Console.WriteLine("Enter Account_No : ");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email : ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter UserName : ");
            User_Name = Console.ReadLine();
            Console.WriteLine("Enter Account-Type : ");
            Account_Type = Console.ReadLine();
            Console.WriteLine("Enter Account_Balance : ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Accoun_No : " + Account_No);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Username : " + User_Name);
            Console.WriteLine("Account_Type : " + Account_Type);
            Console.WriteLine("Account_Balance : " + Account_Balance);
        }
    }
}
