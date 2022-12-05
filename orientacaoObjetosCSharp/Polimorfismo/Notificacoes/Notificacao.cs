namespace Notificacoes
{
    //Classe que representa todas as informações comuns a todos os tipos de notificações. 
    public abstract class Notificacao
    {
        public string Destinatario { get; set;}
        public string Mensagem { get; set;}

        public Notificacao(string destinatario, string mensagem)
        {
            Destinatario = destinatario;
            Mensagem = mensagem;
        }

        public abstract void Enviar();
    }
}