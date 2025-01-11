
using Lab_6;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter program to run : ");
        Console.WriteLine("1. StudentArrayList");
        Console.WriteLine("2. Studentlist");
        Console.WriteLine("3. StackDemo");
        Console.WriteLine("4. QueueDemo");
        Console.WriteLine("5. HashTable");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                StudentArrayList studentArrayList = new StudentArrayList();
                studentArrayList.Demo();
                break;

            case 2:
                StudentList studentList = new StudentList();
                studentList.ListDemo();
                break;

            case 3:
                StackDemo stackDemo = new StackDemo();
                stackDemo.Run();
                break;

            case 4:
                QueueDemo queueDemo = new QueueDemo();
                queueDemo.Demo();
                break;

                case 5:
                HashTableCollection hashTableCollection = new HashTableCollection();
                hashTableCollection.hashCollection();
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
