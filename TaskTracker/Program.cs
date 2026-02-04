
using System.Collections;

var shouldContinue = true;

do
{
Console.WriteLine("Welcome to TaskTracker!");
Console.WriteLine("1. List Tasks");
Console.WriteLine("2. About");
Console.WriteLine("3. Exit");
Console.Write("Choose an option: "); 

int.TryParse(Console.ReadLine(), null, out int input);

switch(input)
    {

    case 1:
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

}while(shouldContinue);

void AboutMeInformation()
{
    
    Console.WriteLine("Name: Donald Choe");
    Console.WriteLine("github Username: ilovetweety");
    Console.WriteLine(DateTime.Now);
    Console.WriteLine();
    shouldContinue = false;
}