//Cria um array do tipo inteiro com capacidade de armazenar 5 informações
int[] numerosInteiros = new int[5];
//Cria um array do tipo inteiro com capacidade de armazenar 5 informações, utilizando a inferência de tipos
var numerosInteirosDois = new  int[5];
//Cria um array do tipo inteiro com capacidade de armazenar 5 informações, utilizando a inferência de tipos e já informa os valores armazenados;
var numerosInteirosTres = new  int[] {1, 2, 3, 4, 5};

//Imprime o dado armazenado no indice 3 do array.
Console.WriteLine(numerosInteirosTres[3]);

//Atribui um valor ao indice informado no array
numerosInteirosTres[3] = 10;

for (int contador = 0; contador < numerosInteirosTres.Length; contador++)
{
    Console.WriteLine(numerosInteirosTres[contador]);
}