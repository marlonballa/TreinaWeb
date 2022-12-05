using Personagens;

var primeiroCavaleiro = new Cavaleiro("Bjornguid", 88);
var primeiroArqueiro = new Arqueiro("Trignort", 97); 
var primeiroMago = new Mago("Merlin", 155, 500);

primeiroArqueiro.Atacar();
primeiroCavaleiro.Defender();
primeiroMago.AtacarEspecial(); 
primeiroCavaleiro.Atacar();
primeiroArqueiro.AtacarEspecial(); 
primeiroArqueiro.Defender();
primeiroCavaleiro.Defender(); 
primeiroMago.AtacarEspecial(); 


/*
    O Conceito de classe abstrata:
    - Uma classe abstrata é uma classe que não pode ser instanciada. Mas, pode servir de base para novas classes; 

    A definição de personagem é abstrata, pois trata de um conceito geral e não faz sentido a existência de uma instância dessa classe. 
    Mas, faz sentido ela ser utilizada como base para classes específicas, cuja instância faz sentido. 
        * Personagem: Abstrato
        * Mago: Real, pode ser instanciado. 

        * Em uma classe abstrata devemos colocar "abstract" em sua declaração

        * O conceito de "abstrato" é extendido para os métodos também. 
*/

