namespace Personagens
{
    public class Mago : Personagem
    {
        public int Magia {get;set;}

        public Mago(string nomeMago, double vidaMago, int pontosMagia) : base(nomeMago, vidaMago)
        {
            Magia = pontosMagia;
        }

        //sobreescrita de métodos: Permite que uma classe filha sobreescreva uma classe que foi definida na classe pai
        //É necessário adicionar o modificador "virtual" no método da classe pai
        //A palavra reservada override fornece os métodos que podem ser sobreescritos. 

        public override void Atacar()
        {
            Console.WriteLine($"O {Nome} atacou com sua magia!");
        }

        public override void AtacarEspecial()
        {
            Console.WriteLine($" {Nome!} deu um especial! ");
        }
    }
}

