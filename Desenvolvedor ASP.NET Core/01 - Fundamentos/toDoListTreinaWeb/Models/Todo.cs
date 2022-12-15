namespace toDoListTreinaWeb.Models;

public class Todo
{ 
    public int IdTodo { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}