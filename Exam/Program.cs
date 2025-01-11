using Exam;
using System.Xml.Linq;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Progaram you want to run");
        Console.WriteLine("1. USer");
        Console.WriteLine("2. Armstron");
        Console.WriteLine("3. Area");
        Console.WriteLine("4. LongestWord");

        Console.WriteLine("Enter choice");
        int choice=Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
           

                case 2:
                Armstrong armstrong = new Armstrong();
                armstrong.armstrong();
                break;

                case 3:
                Area area = new Area();
                Console.WriteLine("Enter Radius : ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of Circle : " + area.FindArea(r));

                Console.WriteLine("Enter base : ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter height : ");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of Triangle : " + area.FindArea(b, h));

                Console.WriteLine("Enter length : ");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter width : ");
                double w = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of square : " + area.FindArea(l,w));
                break;

                case 4:
                Word word = new Word();
                word.display();
                break;
        }
    }
}