
using System.Collections;
using TaskTracker.TaskDomain;


internal class Program
{
    private static void Main(string[] args)
    {
        var shouldContinue = true;

        do
        {
            Console.WriteLine("Welcome to TaskTracker!");
            Console.WriteLine("1. List Tasks");
            Console.WriteLine("2. About");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            int.TryParse(Console.ReadLine(), null, out int input);

            switch (input)
            {

                case 1:
                    TaskItem taskOne = new();
                 
                    taskOne.Title = "Clean the chicken coop";
                    
                    TaskItem taskTwo = new();
                  
                    taskTwo.Title = "Finish covert px to rem";

                    
                    TaskItem taskThree = new();
                   
                    taskThree.Title = "Grade week 3 labs";

                    List<TaskItem> taskItems = [];

                    taskItems.Add(taskOne);
                    taskItems.Add(taskTwo);
                    taskItems.Add(taskThree);

                    foreach (var item in taskItems)
                    {
                        
                        Console.WriteLine($"{item.Id}: {item.Title}");
                    }
                    
                    Console.WriteLine(taskItems);
                    Console.WriteLine(TaskItem.TotalCount);

                                      
                    //list the tasks
                    //TODO: add a project reference by turning the domain into a class library
                    //list the tasks
        
                    break;

                case 2:
                    //AboutMeInformation();

                    break;

                case 3:

                    shouldContinue = false;
                    break;

                default:

                    break;

            }

        } while (shouldContinue);

        void AboutMeInformation()
        {

            Console.WriteLine("Name: Donald Choe");
            Console.WriteLine("github Username: ilovetweety");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
            shouldContinue = false;
        }
    }
}

