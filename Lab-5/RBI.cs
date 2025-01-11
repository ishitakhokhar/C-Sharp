using Lab_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Create a class named RBI with calculateInterest() method. Create another
//classes HDFC, SBI, ICICI which overrides calculateInterest() method.

namespace Lab_5
{
    internal class RBI
    {
        public  virtual float calculateInterest(float time,float prinipal)
        {
            return (time * prinipal * Convert.ToSingle(0.03)) / 100;
        }
    }
    class HDFC:RBI
    {
        public override float calculateInterest(float time, float prinipal)
        {
            return (time * prinipal *Convert.ToSingle(0.03) ) / 100;
        }
    }
    class SBI : RBI
    {
        public override float calculateInterest(float time, float prinipal)
        {
            return (time * prinipal *Convert.ToSingle(0.035) ) / 100;
        }
    }
    class ICICI : RBI
    {
        public override float calculateInterest(float time, float prinipal)
        {
            return (time * prinipal *Convert.ToSingle(0.04) ) / 100;
        }
    }
}
