namespace Personagens
{
    public class Personagem
    {
        private string nome = string.Empty;
        public string Nome { get; set; }

        private double vida;
        private double Vida { get; set; }

        //Método Construtor
        public Personagem(string nomePersonagem, double vidaPersonagem)
        {
            Nome = nomePersonagem;
            Vida = vidaPersonagem;
        }
        public void Atacar() { Console.WriteLine($"{ Nome } atacou! "); }
        public void Defender() { Console.WriteLine($"{ Nome }defendeu!"); }
    }
}