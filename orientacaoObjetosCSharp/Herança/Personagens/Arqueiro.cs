
namespace Personagens
{
    public class Arqueiro : Personagem
    {
        public Arqueiro(string nomeArqueiro, double vidaArqueiro) : base(nomeArqueiro, vidaArqueiro)
        {

        } 

        public override void Atacar()
        {
            Console.WriteLine($"O { Nome} atacou com suas flechas!");
        }

        public override void AtacarEspecial()
        {
            Console.WriteLine($" {Nome!} deu um especial! ");
        }
    }
}