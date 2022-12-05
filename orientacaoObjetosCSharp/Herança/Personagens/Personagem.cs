namespace Personagens
{
    public abstract class Personagem
    {
        private string nome = string.Empty;
        public string Nome { get; set; }

        private double vida;
        private double Vida { get; set; }

        //Modificador de Acesso: protected
        //Permite que um atributo ou método seja visível apenas dentro da classe ou das classe que herdam dela
        protected int idPersonagem { get; set; }

        //Método Construtor
        public Personagem(string nomePersonagem, double vidaPersonagem)
        {
            Nome = nomePersonagem;
            Vida = vidaPersonagem;
        }
        public virtual void Atacar() { Console.WriteLine($"{ Nome } atacou! "); }
        public void Defender() { Console.WriteLine($"{ Nome } defendeu!"); }

        //Abstrato aqui, mas real nas classes específicas. 
        //Métodos abstratos são obrigatoriamente implementados na classe filha. 
        public abstract void AtacarEspecial();
    }
}