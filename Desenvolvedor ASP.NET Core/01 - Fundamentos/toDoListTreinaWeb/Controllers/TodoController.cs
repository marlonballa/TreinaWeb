using Microsoft.AspNetCore.Mvc;

namespace toDoListTreinaWeb.Controllers;

public class TodoController : Controller
{ 
    private readonly AppDbContex _context;

    public TodoController(AppDbContex context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }
}