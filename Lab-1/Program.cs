//Write a program to print your name, address, contact number & city.
using Lab_1;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Select program to run : ");
        Console.WriteLine("1. Personal Information");
        Console.WriteLine("2. User Input");
        Console.WriteLine("3. Prompt");
        Console.WriteLine("4. Area");
        Console.WriteLine("5. Celsius To Fahrenheit vice-versa");
        Console.WriteLine("6. Simple Interest");
        Console.WriteLine("7. Calculator");
        Console.WriteLine("8. Max number");
        Console.WriteLine("9. Swap without using Third variable");

        int choice=Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
            case 1:
                Console.WriteLine("Darhan");
                Console.WriteLine("Morbi Road");
                Console.WriteLine(1234567890);
                Console.WriteLine("Rajkot");
                break;

            case 2:
                UserInput userInput = new UserInput();
                userInput.TakeInput();
                break;

            case 3:
                Prompt prompt = new Prompt();
                prompt.Information();
                break;

             case 4:
                Area area = new Area();
                area.CalculateSquareArea();
                area.CalculateRectangleArea();
                area.CalculateCirculeArea();
                break;

              case 5:
                Celsius_to_Fahrenheit CToF=new Celsius_to_Fahrenheit();
                CToF.FerToCel();
                CToF.CelToFer();
                break;

              case 6:
                SimpleInterest simpleInterest = new SimpleInterest();
                simpleInterest.Interest();
                break;

               case 7:
                Calculator calculator = new Calculator();
                calculator.calc();
                break;

              case 8:
                MaxNumber maxNumber = new MaxNumber();
                maxNumber.number();
                break;

                case 9:
                Swap swap = new Swap();
                swap.num();
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }  

    }
}
