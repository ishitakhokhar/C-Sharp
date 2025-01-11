using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class StringMethod
    {
        public void Method()
        {
            String s = "Darshan University";
            String s1 = "University";
            Console.WriteLine("Clone "+s.Clone());
            Console.WriteLine("Compare "+s.CompareTo(s1));
            Console.WriteLine("Contains "+s.Contains("Uni"));
            Console.WriteLine("Ends With "+s.EndsWith("y"));
            Console.WriteLine("Equals "+s.Equals(s1));
            Console.WriteLine("Index Of "+s.IndexOf("e"));
            Console.WriteLine("Insert "+s.Insert(0, "Hello "));
            Console.WriteLine("Last Insex Of "+s.LastIndexOf("s"));
            Console.WriteLine("Length "+s.Length);
            Console.WriteLine("Remove "+s.Remove(0));
            Console.WriteLine("Replace "+s.Replace("University", "Collage"));
            Console.WriteLine("StartWith "+s.StartsWith("D"));
            Console.WriteLine("SubString "+s.Substring(2, 5));
            Console.WriteLine("Trim "+s.Trim());
        }
    }
}
