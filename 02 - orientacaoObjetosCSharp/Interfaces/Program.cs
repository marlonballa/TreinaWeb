using System;
using Itens;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var espada = new Espada("Bone Blade", 15, 15, 225);
            espada.Colecionar();

            var primeiraPocao = new Pocao("Poção da Vida", 12, 99, 173);
            primeiraPocao.Consumir();

            var joiaDoInfinito = new Joia("Brincos de Fusão", 55, 27, 200);
            joiaDoInfinito.Colecionar();
            joiaDoInfinito.Consumir();
        }
    }    
}
