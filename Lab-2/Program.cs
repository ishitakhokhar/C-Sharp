//The marks obtained by a student in 5 different subjects are input through
//the keyboard. The student gets a grade as per the following rules:
//a.Percentage above or equals to 60-first grade
//b. Percentage between 50 to 59-second grade
//c. Percentage between 40 and 49-Third grade
//d. Percentage less than 40-poor Grade
//Write a program to assign the grade obtained by the student.


using Lab_2;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(String[]args)
    {
        Console.WriteLine("Enter which program you want to run");
        Console.WriteLine("1. Student Mark");
        Console.WriteLine("2. Prime Number");
        Console.WriteLine("3. Leap Year");
        Console.WriteLine("4. FibonaciSeries");
        Console.WriteLine("5. Binary");
        Console.WriteLine("6. BMI");

        int choice=Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
            case 1:
                Marks marks = new Marks();
                marks.Mark();
                break;

                case 2:
                PrimeNumber number = new PrimeNumber();
                number.Prime();
                break;

                case 3:
                LeapYear year = new LeapYear();
                year.Year();
                break;

                case 4:
                FibonaciSeries series = new FibonaciSeries();
                series.Fibonaci();
                break;

                case 5:
                Binary binary = new Binary();
                binary.BinaryForm();
                break;

                case 6:
                BMI bMI = new BMI();
                bMI.Weight();
                break;


            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}