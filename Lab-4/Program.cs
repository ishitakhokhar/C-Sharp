using Lab_4;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Program To Run : ");
        Console.WriteLine("1. DivisonHandler");
        Console.WriteLine("2. IndexOutOfRange");
        Console.WriteLine("3. ThrowException");
        Console.WriteLine("4. Sum");
        Console.WriteLine("5. Calculator");
        Console.WriteLine("6. Shape");
        Console.WriteLine("7. String Method");
        Console.WriteLine("8. Change Case");
        Console.WriteLine("9. Longest Word in String");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                DivisionHandler handler = new DivisionHandler();
                handler.Divide();
                break;

            case 2:
                IndexException exception = new IndexException();
                exception.Index();
                break;

            case 3:
                ThrowException throwException = new ThrowException();
                throwException.Throw();
                break;

            case 4:
                Calc calculate = new Calc();
                Console.WriteLine("Enter first number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(calculate.SumOfTwo(num1, num2));
                Console.WriteLine("Enter third number : ");
                int num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(calculate.SumOfThree(num1, num2, num3));
                break;

            case 5:
                Result result = new Result();
                Console.WriteLine("Enter first number : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(result.add(a, b));
                Console.WriteLine(result.sub(a, b));
                break;

            case 6:
                Area area = new Area();
                Console.WriteLine("Enter Radius : ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of Circle : " + area.Circle(r));
                Console.WriteLine("Enter Breath : ");
                double br = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Height : ");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of Triangle : " + area.Triangle(br, h));
                Console.WriteLine("Enter Length : ");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of square : " + area.Square(l));
                break;

            case 7:
                StringMethod method = new StringMethod();
                method.Method();
                break;

            case 8:
                 ChangeCase changeCase = new ChangeCase();
                changeCase.Case();
                break;

                case 9:
                 LongestWord word = new LongestWord();
                word.LongestWordLength();
                break;

            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
}
