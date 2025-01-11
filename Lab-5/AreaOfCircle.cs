using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class AreaOfCircle
    {
        public double FindArea(double l)
        {
            return l * l;
        }
        public double FindArea(double l, double b)
        {
            return l * b;
        }
        public  double FindArea(int r)
        {
            return 3.14 * r*r;
        }
    }
}
