using System;

namespace Itens
{
    //Uma joia pode ser consumida ou colecionada, de acordo com a vontade do jogador. Por isso, devemos implementar as duas interfaces existentes, dentro dessa classe, para que ela possua as duas opções.
    public class Joia : Item, IColecionavel, IConsumivel
    {
        public int Valor { get; set; }

        public Pocao(string nome, int x, int y, int valor) : base(nome, x, y)
        {
            Valor = valor;
        }

        public void Colecionar()
        {
            Console.WriteLine("Joia adicionada ao inventário!");
        }

        public void Consumir() 
        {
            Console.WriteLine($"Você utilizou e agora seu dano aumentou em {Valor} pontos.");
        }
    }
}