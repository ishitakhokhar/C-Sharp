using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write program to prompt a user to input his/her name and country name
//and then output will be shown as given: Hello<yourname> from country
//<countryname>.

namespace Lab_1
{
    internal class Prompt
    {
        public void Information()
        {
            Console.WriteLine("Enter your name : ");
            String name = Console.ReadLine();
       
            Console.WriteLine("Enter your country : ");
            String country = Console.ReadLine();
        
            Console.WriteLine("Hello " + name + " from country " + country);
        }
    }
}
