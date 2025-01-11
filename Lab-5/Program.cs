using Lab_5;
using static Lab_5.TrafficSignal;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter program to Run : ");
        Console.WriteLine("1. sum");
        Console.WriteLine("2. Area");
        Console.WriteLine("3. Area of circle");
        Console.WriteLine("4. Bank");
        Console.WriteLine("5. Hospital");
        Console.WriteLine("6. Factorial");
        Console.WriteLine("7. TrafficSignal");

        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Sum s = new Sum();
                Console.WriteLine("Enter Integer Number : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Integer Number : ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter float number : ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter float number : ");
                double d = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Addition of Integer number is : " + s.sum(a, b));
                Console.WriteLine("Addition of float number is : " + s.sum(c, d));
                break;

            case 2:
                Area area = new Area();
                Console.WriteLine("Enter Length : ");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter bredth : ");
                double br = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Area of square is : " + area.FindArea(l));
                Console.WriteLine("Area of Rectangle is : " + area.FindArea(l, br));
                break;

            case 3:
                AreaOfCircle areaOfCircle = new AreaOfCircle();
                Console.WriteLine("Enter Length : ");
                double le = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter bredth : ");
                double bre = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Radius : ");
                double r = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Area of square is : " + areaOfCircle.FindArea(le));
                Console.WriteLine("Area of Rectangle is : " + areaOfCircle.FindArea(le, bre));
                Console.WriteLine("Area of circle is : " + areaOfCircle.FindArea(r));
                break;

            case 4:
                Console.WriteLine("Enter Principal : ");
                float principal=Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter Time : ");
                float time = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter Rate : ");
                float Rate = Convert.ToSingle(Console.ReadLine());
                RBI rBI = new RBI();
                HDFC hDFC = new HDFC();
                SBI sBI = new SBI();
                ICICI iCICI = new ICICI();
                Console.WriteLine("RBi intrest is : " + rBI.calculateInterest(time, principal));
                Console.WriteLine("Hdfc interst is : "+hDFC.calculateInterest(time,principal));
                Console.WriteLine("Sbi interst is : "+sBI.calculateInterest(time,principal));
                Console.WriteLine("Icici interst is : " + iCICI.calculateInterest(time, principal));
                break;

            case 5:
                Hospital hospital = new Hospital();
                Apollo apollo = new Apollo();
                Wockhardt wockhardt = new Wockhardt();
                Gokul_Superspeciality gokul_Sup = new Gokul_Superspeciality();

                hospital.HospitalDetails();
                apollo.HospitalDetails();
                wockhardt.HospitalDetails();
                gokul_Sup.HospitalDetails();
                break;

            case 6:
                break;

                case 7:
                TrafficSignal trafficSignal = new TrafficSignal();
                TrafficDel Yellow = TrafficSignal.Yellow;
                TrafficDel Green = TrafficSignal.Green;
                TrafficDel Red = TrafficSignal.Red;
                Yellow();
                Green();
                Red();
                    break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}