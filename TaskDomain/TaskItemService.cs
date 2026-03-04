using System.Security.Cryptography.X509Certificates;
using TaskTracker.TaskDomain;

namespace TaskDomain;

public class TaskItemService
{
List<TaskItem> taskItems = [];

    public void PopulateInitialTaskItems()
    {
        TaskItem taskOne = new ("Clean the chicken coop");
                 
        TaskItem taskTwo = new("Finish covert px to rem");

        TaskItem taskThree = new("Grade week 3 labs");

        

        taskItems.Add(taskOne);
        taskItems.Add(taskTwo);
        taskItems.Add(taskThree);
    }
    public void DisplayTaskItems()
    {
        foreach (var item in taskItems)
                    {
                        
                        Console.WriteLine($"{item.Id}: {item.Title}");
                    }
                    
                    Console.WriteLine(taskItems);
                    Console.WriteLine(TaskItem.TotalCount);

    }

    
    
}
