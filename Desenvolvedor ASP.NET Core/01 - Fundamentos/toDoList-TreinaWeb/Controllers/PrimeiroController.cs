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

namespace Controllers;

//Todo Controller deve ser herdeiro da classe Controller
public class PrimeiroController : Controller
{ 
    //É uma boa prática ter uma action index. 
    public IActionResult Index()
    {
        //O retorno desta action é a renderização de uma view
        return View();
    }
}


