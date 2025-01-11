using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a class Hospital with HospitalDetails() method.Create another
//classes Apollo, Wockhardt, Gokul_Superspeciality which overrides
//HospitalDetails() method.

namespace Lab_5
{
    internal class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("Hospital");
        }
    }
    class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo Hospital");
        }
    }
    class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt Hospital");
        }
    }
    class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul_Superspeciality Hospital");
        }
    }
}