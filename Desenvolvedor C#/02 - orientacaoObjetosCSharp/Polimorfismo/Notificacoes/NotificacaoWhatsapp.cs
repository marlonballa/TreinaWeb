namespace Notificacoes
{
    public class NotificacaoWhatsapp : Notificacao
    {
        public NotificacaoWhatsapp(string destinatarioWhatsApp, string mensagemWhatsApp) : base(destinatarioWhatsApp, mensagemWhatsApp)
        {}

        public override void Enviar()
        {
            Console.WriteLine($"Enviando WhatsApp para { Destinatario }, com a mensagem: { Mensagem }");
        }
    }
}