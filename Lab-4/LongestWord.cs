using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class LongestWord
    {
        public void LongestWordLength()
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            String[] word = str.Split(' ');
            int length = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (length < word[i].Length)
                {
                    length = word[i].Length;
                }
            }
            Console.WriteLine("Longest Word in string is : "+length);
        }
    }
}