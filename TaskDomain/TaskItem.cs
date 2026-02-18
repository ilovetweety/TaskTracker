namespace TaskTracker.TaskDomain;

/// <summary>
/// This class is a template/blueprint for our todo items
/// </summary>
public class TaskItem
{
    private static int _totalCount = 0;
    public static int TotalCount
    {
        get => _totalCount;
    }

    public TaskItem()
    {
        ++_totalCount;
    }
    
    public int Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public bool IsComplete { get; set; }
}