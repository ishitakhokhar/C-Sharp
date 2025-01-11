using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Binary
    {
        public void BinaryForm()
        {
            Console.WriteLine("Enter Integer Number : ");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Binary : " + (Convert.ToString(num,2)));
        }
    }
}
