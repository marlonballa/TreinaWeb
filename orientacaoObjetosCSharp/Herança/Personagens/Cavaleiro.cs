namespace Personagens
{
    public class Cavaleiro : Personagem
    {
        public Cavaleiro(string nomeCavaleiro, double vidaCavaleiro) : base(nomeCavaleiro, vidaCavaleiro)
        {

        }

        public override void Atacar()
        {
            Console.WriteLine($"O {Nome} atacou com sua espada!");
        }

        public override void AtacarEspecial()
        {
            Console.WriteLine($" {Nome!} deu um especial! ");
        }
    }
}