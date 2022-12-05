using System;
namespace Itens
{
    //Classe responsável por definir as caracteristicas que todo item deve ter: Nome, posição em X e posição em Y. 
    public abstract class Item
    {
        public string Nome { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Item(string nome, int x, int y) 
        {
            Nome = nome;
            x = x;
            y = y;
        }
    }
}