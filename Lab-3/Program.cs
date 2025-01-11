using Lab_3;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Program to run : ");
        Console.WriteLine("1. Candidate");
        Console.WriteLine("2. Staff");
        Console.WriteLine("3. Bank_Account");
        Console.WriteLine("4. Student");
        Console.WriteLine("5. Salary");
        Console.WriteLine("6. Distance");
        Console.WriteLine("7. Reactangle");
        Console.WriteLine("8. Furniture");
        Console.WriteLine("9. AccountDetails");
        Console.WriteLine("10. SalaryInterface");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Candidate candidate = new Candidate();
                candidate.GetCandidateDetails();
                candidate.DisplayCandidateDetails();
                break;

            case 2:
                Staff s1 = new Staff("Alice", "Admin", 1001);
                Staff s2 = new Staff("Bob", "HOD", 6789);
                Staff s3 = new Staff("Rus", "Ta", 3456);
                Staff s4 = new Staff("Alex", "HOD", 3458);
                Staff s5 = new Staff("Chris", "Admin", 7823);
                s1.display();
                s2.display();
                s3.display();
                s4.display();
                s5.display();
                break;

            case 3:
                Bank_Account bank = new Bank_Account();
                bank.GetAccountBalance();
                bank.DisplayAccountDetails();
                break;

            case 4:
                Student student = new Student();
                student.DisplayStudentDetails();
                break;

            case 5:
                Salary salary = new Salary();
                salary.CalculateSalary();
                break;

            case 6:
                Distance distance = new Distance();
                distance.Addition();
                break;

            case 7:
                Rectangle rectangle = new Rectangle();
                rectangle.Calculate();
                break;

            case 8:
                Table t = new Table("Wood", 40000, 140, 1300);
                t.Display();
                break;


            case 9:
                Interest i = new Interest();
                i.displayDetail();
                break;

            case 10:
                SalaryInterface s = new SalaryInterface();
                s.salary();
                s.basicSalary();
                s.grossSalary();
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}