﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class ChangeCase
    {
        public void Case()
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            string x = "";
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (Char.IsUpper(c))
                {
                    x += Char.ToLower(c);
                }
                else
                {
                    x += Char.ToUpper(c);
                }
            }
            Console.WriteLine(x);
        }
    }
}
