namespace Notificacoes
{
    public class NotificacaoSms : Notificacao
    {
        public NotificacaoSms(string destinatarioSms, string mensagemSms) : base(destinatarioSms, mensagemSms)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine($"Enviando SMS para { Destinatario}, com a mensagem: { Mensagem }");
        }
    }
}