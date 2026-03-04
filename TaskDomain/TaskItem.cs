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

    public TaskItem(string title)
    {
        Id = ++_totalCount;
        Title = title;
    }
    
    public int Id { get; }
    public string Title { get; set; } = String.Empty;
    public bool IsComplete { get; set; }
}