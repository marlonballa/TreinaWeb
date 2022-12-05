using Notificacoes;

Console.WriteLine("Escolha o tipo de notificação: 1 E-mail | 2 - SMS | 3 - Whatsapp");
var tipoNotificacao = Console.ReadLine();

Console.WriteLine("Digite o destinatário: ");
var destinatario = Console.ReadLine();

Console.WriteLine("Digite a mensagem: ");
var conteudoMensagem = Console.ReadLine();

//Declarando um objeto do tipo "notificacao"
Notificacao notificacao;


switch (tipoNotificacao)
{
    case "1":
        //Instanciando o objeto, por meio de uma classe concreta. 
        notificacao = new NotificacaoEmail(destinatario, conteudoMensagem);
        notificacao.Enviar();
    break;
    case "2":
        notificacao = new NotificacaoSms(destinatario, conteudoMensagem);
        notificacao.Enviar();
    break;
    case "3":
        notificacao = new NotificacaoWhatsapp(destinatario, conteudoMensagem);
        notificacao.Enviar();
    break;
    default:
        Console.WriteLine("A opção que você escolheu não é válida.");
    break;
}




// Polimorfismo: Um mesmo objeto pode assumir várias formas, de acordo com a necessidade da aplicação. 