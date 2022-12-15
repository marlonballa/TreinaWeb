//Todos os Controllers devem possuir o seu nome igual ao de seu arquivo
//Dentro de um Controller, um método é chamado de Action

/*
    Como as actions fazem a gestão das rotas, devemos conhecer a estrutura básica de troca de informações, para garantir que a rota executada será a rota correta. 

    Controller.cs (Arquivo controller)

        Dentro da Action, teremos apenas uma chamada para renderização da View, sem informar qual View é. 
        No entanto, para que a renderização aconteça da forma correta, devemos: 

        Dentro da pasta View, teremos uma pasta com o nome do Controller que executará aquela View
            * Dentro dessa pasta, devemos ter um arquivo .cshtml com o nome da action que renderizará essa view. 
            
    Program.cs (arquivo principal da execução)

        Aqui dentro vamos passar as informações para o método responsável por exibir a página. 

        app.MapControllerRoute(
            name: "default", 
            pattern: "{controller=Home}/{action=Index}/{id?}"
        );

        Dizemos que dentro do controller Home, vamos acessar a action Index e, se necessário, utilizar parâmetros adicionais.
*/

//Caso não seja acessada nenhuma rota, será executada a Action Index
using Microsoft.AspNetCore.Mvc;
using toDoListTreinaWeb.ViewModels;
using toDoListTreinaWeb.Models;
namespace Controllers;

//Todo Controller deve ser herdeiro da classe Controller
public class PrimeiroController : Controller
{ 
    //É uma boa prática ter uma action index. 
    public IActionResult Index()
    {
        /* 
            Primeira forma de usar o ViewData
            ViewData["apresentacao"] = "Este e um valor enviado por meio do View Data"; 
        */

        /* 
            Segunda forma de usar o ViewData
            ViewData.Add("apresentacao", "Este e um valor enviado por meio do View Data");            
        */

        var todo = new Todo { 
            Title = "Desenvolvendo aplicações com Razor",
            
            };

        //ViewData["todo"] = todo;

        //O ViewBag é baseado no tipo dinamic e por isso não precisa de conversão de tipos complexos. 
        //ViewBag.Chave = Valor;
        ViewBag.Todo = todo;

        /*
            As estruturas ViewData e ViewBag, armazenam as infomrações apenas quando a requisição que as solicitou, existir.
            TempData: Mantém os dados, como se en sessão, até que sejam consumidos. No momento que o dado é acessado, a informação é apagada do TempData
                * Não trabalha com os tipos complexos. 
        */

        TempData["message"] = "Mensagem vinda da Action Index da View Primeiro";
        //O retorno desta action é a renderização de uma view
        return View();
    }

    public IActionResult Message()
    {
        return View();
    }

    public IActionResult ViewModel()
    {
         var todo = new Todo { 
            Title = "Desenvolvendo aplicações com Razor",
            
            };

        var viewModel = new DetailsTodosViewModels
        {
            Todo = todo,
            PageTitle = "Detalhes da Tarefa"
        };
        

        return View(viewModel);
    }
}


