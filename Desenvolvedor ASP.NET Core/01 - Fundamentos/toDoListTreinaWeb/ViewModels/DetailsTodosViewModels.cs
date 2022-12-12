using toDoListTreinaWeb.Models;

namespace toDoListTreinaWeb.ViewModels;

public class DetailsTodosViewModels
{ 
    //Instância de Todo
    public Todo Todo { get; set; } = null!;

    //Recebe o titúlo da página
    public string PageTitle { get; set; } = string.Empty;
}