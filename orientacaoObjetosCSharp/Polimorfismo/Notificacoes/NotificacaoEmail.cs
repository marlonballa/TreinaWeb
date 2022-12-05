namespace Notificacoes
{
    public class NotificacaoEmail : Notificacao
    {
        public NotificacaoEmail(string destinatarioEmail, string mensagemEmail) : base(destinatarioEmail, mensagemEmail)
        {}

        public override void Enviar()
        {
            Console.WriteLine($"Enviando e-mail para { Destinatario}, com a mensagem: { Mensagem }");
        }
    }
}