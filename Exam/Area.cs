using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Area
    {
        public double FindArea(double r)
        {
            return 3.14 * r * r;
        }
        public double FindArea(double b, double h)
        {
            return b * h;
        }
        public double FindArea(int l, int w)
        {
            return l * w;
        }
    }
}
