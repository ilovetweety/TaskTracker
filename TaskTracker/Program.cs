
using System.Collections;
using TaskDomain;
using TaskTracker;
using TaskTracker.TaskDomain;



internal class Program
{
    private static void Main(string[] args)
    {
        
        var shouldContinue = true;

        do
        {
            Console.WriteLine("Welcome to TaskTracker!");
            
            foreach (var item in Enum.GetValues<MainMenu>())
{
            Console.WriteLine($"{(int)item}. {item}");
}
            Console.Write("Choose an option: ");

            int.TryParse(Console.ReadLine(), null, out int input);

            switch (input)
            {

                case (int)MainMenu.ListTasks:
                    
                    
                                      
                    //list the tasks
                    //TODO: add a project reference by turning the domain into a class library
                    //list the tasks
        
                    break;

                case (int)MainMenu.AddTask:
                    //AboutMeInformation();
                    
                    break;

                case (int)MainMenu.DeleteTask:

                           
                    break;
                case (int)MainMenu.UpdateTask:

                    break;

                case (int)MainMenu.Exit:

                    shouldContinue = false;
                    break;


                default:
                    shouldContinue = false;

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

